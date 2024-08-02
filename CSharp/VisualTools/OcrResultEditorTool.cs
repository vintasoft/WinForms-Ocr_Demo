using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Forms;

using Vintasoft.Imaging.UI.VisualTools;
using Vintasoft.Imaging.Ocr;
using Vintasoft.Imaging.Ocr.Results;
using Vintasoft.Imaging;

namespace OcrDemo
{
    /// <summary>
    /// Represents a visual tool for viewing and editing the OCR results.
    /// </summary>
    public class OcrResultEditorTool : CompositeVisualTool
    {

        #region Constants

        /// <summary>
        /// Minimum tool selection size.
        /// </summary>
        const int MIN_SELECTION_SIZE = 10;

        #endregion



        #region Fields

        /// <summary>
        /// Page objects.
        /// </summary>
        ColoredObjects<OcrObject> _ocrObjects;


        /// <summary>
        /// The rectangular selection tool.
        /// </summary>
        RectangularSelectionTool _selectionTool;

        /// <summary>
        /// The list of selected objects.
        /// </summary>
        List<OcrObject> _selectedObjects;

        /// <summary>
        /// The collection of readonly objects.
        /// </summary>
        ReadOnlyCollection<OcrObject> _selectedObjectsAsReadOnly;


        /// <summary>
        /// The visual tool that allows to highlight recognition results.
        /// </summary>
        HighlightTool<OcrObject> _resultViewerTool;

        /// <summary>
        /// Highlighted selected objects.
        /// </summary>
        ColoredObjects<OcrObject> _highlightedObjects = null;


        /// <summary>
        /// A value indicating whether the Shift key is pressed.
        /// </summary>
        bool _isShiftKeyDown = false;

        /// <summary>
        /// A value indicating whether the Control key is pressed.
        /// </summary>
        bool _isCtrlKeyDown = false;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrResultEditorTool"/> class
        /// </summary>
        public OcrResultEditorTool()
            : base()
        {
            _selectionTool = new RectangularSelectionTool();
            _selectionTool.SelectionChanged += new EventHandler<SelectionChangedEventArgs>(selectionTool_SelectionChanged);

            _resultViewerTool = new HighlightTool<OcrObject>();

            VisualTools = new VisualTool[] { _selectionTool, _resultViewerTool };

            FocusedObjectBrush = new SolidBrush(Color.FromArgb(128, 0, 255, 255));
            FocusedObjectPen = new Pen(Color.FromArgb(192, 64, 128, 0));

            _selectedObjects = new List<OcrObject>();
            _selectedObjectsAsReadOnly = _selectedObjects.AsReadOnly();
        }

        #endregion



        #region Properties

        OcrPage _page;
        /// <summary>
        /// Gets or sets the current OCR page.
        /// </summary>
        public OcrPage Page
        {
            get
            {
                return _page;
            }
            set
            {
                if (_page != value)
                {
                    _page = value;
                    Update();
                }
            }
        }

        OcrObjectType _objectsType = OcrObjectType.Word;
        /// <summary>
        /// Gets or sets selected object type.
        /// </summary>
        public OcrObjectType ObjectsType
        {
            get
            {
                return _objectsType;
            }
            set
            {
                _objectsType = value;
                Update();
            }
        }

        Brush _objectsBrush = new SolidBrush(Color.FromArgb(24, 0, 192, 0));
        /// <summary>
        /// Gets or sets the brush used to highlight the object.
        /// </summary>
        public Brush ObjectsBrush
        {
            get
            {
                return _objectsBrush;
            }
            set
            {
                _objectsBrush = value;
            }
        }

        Pen _objectsPen = new Pen(Color.FromArgb(192, 0, 128, 0));
        /// <summary>
        /// Gets or sets the pen used to stroke the object.
        /// </summary>
        public Pen ObjectsPen
        {
            get
            {
                return _objectsPen;
            }
            set
            {
                _objectsPen = value;
            }
        }

        OcrObject _focusedObject = null;
        /// <summary>
        /// Gets or sets the focused object.
        /// </summary>
        public OcrObject FocusedObject
        {
            get
            {
                return _focusedObject;
            }
            set
            {
                _focusedObject = value;
                _resultViewerTool.SelectedItem = value;
                OnFocusedObjectChanged();
            }
        }

        /// <summary>
        /// Gets or sets the brush used to highlight the focused object.
        /// </summary>
        public Brush FocusedObjectBrush
        {
            get
            {
                return _resultViewerTool.SelectedItemBrush;
            }
            set
            {
                _resultViewerTool.SelectedItemBrush = value;
            }
        }

        /// <summary>
        /// Gets or sets the pen used to stroke the focused object.
        /// </summary>
        public Pen FocusedObjectPen
        {
            get
            {
                return _resultViewerTool.SelectedItemPen;
            }
            set
            {
                _resultViewerTool.SelectedItemPen = value;
            }
        }

        /// <summary>
        /// Gets the collection of readonly objects.
        /// </summary>
        public ReadOnlyCollection<OcrObject> SelectedObjects
        {
            get
            {
                return _selectedObjectsAsReadOnly;
            }
        }

        ListBox _selectedObjectsListBox;
        /// <summary>
        /// Gets or sets the listbox for selected objects.
        /// </summary>
        public ListBox SelectedObjectsListBox
        {
            get
            {
                return _selectedObjectsListBox;
            }
            set
            {
                if (_selectedObjectsListBox != null)
                    _selectedObjectsListBox.SelectedIndexChanged -= new EventHandler(selectedObjectsListBox_SelectedIndexChanged);

                _selectedObjectsListBox = value;
                if (_selectedObjectsListBox != null)
                    _selectedObjectsListBox.SelectedIndexChanged += new EventHandler(selectedObjectsListBox_SelectedIndexChanged);
            }
        }

        Brush _selectedObjectsBrush = new SolidBrush(Color.FromArgb(48, 255, 0, 0));
        /// <summary>
        /// Gets or sets the brush used to highlight the selected object.
        /// </summary>
        public Brush SelectedObjectsBrush
        {
            get
            {
                return _selectedObjectsBrush;
            }
            set
            {
                _selectedObjectsBrush = value;
            }
        }

        Pen _selectedObjectsPen = new Pen(Color.FromArgb(192, 255, 0, 0));
        /// <summary>
        /// Gets or sets the pen used to stroke the selected object.
        /// </summary>
        public Pen SelectedObjectsPen
        {
            get
            {
                return _selectedObjectsPen;
            }
            set
            {
                _selectedObjectsPen = value;
            }
        }

        #endregion



        #region Methods

        #region PUBLIC

        /// <summary>
        /// Updates the highlighted selected objects.
        /// </summary>
        public void Update()
        {
            _resultViewerTool.Items.Clear();

            _highlightedObjects = null;
            FocusedObject = null;

            if (_page == null)
                return;

            RefreshHighlightedObjects();

            if (_selectedObjectsListBox != null)
                _selectedObjectsListBox.Items.Clear();
        }

        /// <summary>
        /// Removes the specified OCR object from the selected OCR objects.
        /// </summary>
        /// <param name="index">The zero-based index of OCR object.</param>
        public void RemoveObjectFromSelectedObjects(int index)
        {
            OcrObject obj = _selectedObjects[index];
            _selectedObjects.Remove(obj);

            if (_selectedObjectsListBox != null)
                _selectedObjectsListBox.Items.Remove(obj);

            SyncHighlightObjectsWithSelectedObjects();
        }

        /// <summary>
        /// Sets the text of focused OCR object.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetFocusedObjectText(string text)
        {
            OcrTextObject focusedOcrTextObject = (OcrTextObject)FocusedObject;
            // if object text is changed
            if (focusedOcrTextObject.Text != text)
            {
                // create results editor
                OcrResultsEditor editor = new OcrResultsEditor(_page);
                editor.SetObjectText(focusedOcrTextObject, text);
                editor.ValidateResults();

                if (_selectedObjectsListBox != null)
                {
                    int index = _selectedObjects.IndexOf(FocusedObject);
                    if (index >= 0)
                    {
                        _selectedObjectsListBox.BeginUpdate();
                        _selectedObjectsListBox.Items.RemoveAt(index);
                        _selectedObjectsListBox.Items.Insert(index, FocusedObject);
                        _selectedObjectsListBox.SelectedIndex = index;
                        _selectedObjectsListBox.EndUpdate();
                    }
                }
            }
        }

        /// <summary>
        /// Deletes focused object from the OCR results.
        /// </summary>
        /// <param name="index">The object index.</param>
        public void DeleteFocusedObject(int index)
        {
            OcrResultsEditor editor = new OcrResultsEditor(_page);

            OcrObject obj = _selectedObjects[index];
            editor.RemoveObjects(new OcrObject[] { obj });
            editor.ValidateResults();

            if (FocusedObject == obj)
                FocusedObject = null;

            RefreshHighlightedObjects();

            _selectedObjects.RemoveAt(index);
            SyncHighlightObjectsWithSelectedObjects();
            if (_selectedObjectsListBox != null)
                _selectedObjectsListBox.Items.RemoveAt(index);
        }

        /// <summary>
        /// Sets the specified array of OCR objects as selected.
        /// </summary>
        /// <param name="objects">Objects to set as selected.</param>
        public void SetSelectedObjects(params OcrObject[] objects)
        {
            _selectedObjects.Clear();
            if (objects != null)
                _selectedObjects.AddRange(objects);

            if (_selectedObjectsListBox != null)
            {
                _selectedObjectsListBox.BeginUpdate();
                _selectedObjectsListBox.Items.Clear();
                if (objects != null)
                    _selectedObjectsListBox.Items.AddRange(objects);

                _selectedObjectsListBox.EndUpdate();
            }

            SyncHighlightObjectsWithSelectedObjects();
        }

        #endregion


        #region PROTECTED

        /// <summary>
        /// Resets the tool.
        /// </summary>
        protected override void Reset()
        {
            base.Reset();
            _isCtrlKeyDown = false;
            _isShiftKeyDown = false;
        }

        /// <summary>
        /// Raises the MouseMove event.
        /// </summary>
        /// <param name="e">A VisualToolMouseEventArgs that contains the event data.</param>
        protected override void OnMouseMove(VisualToolMouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (_page == null)
                return;
            if (!_selectionTool.Rectangle.IsEmpty)
                return;

            if (_selectedObjects.Count == 1)
                if (_selectedObjects[0] == FocusedObject)
                    return;

            Point location = ImageViewer.PointToImage(e.Location);
            // if location on image
            if (location.X >= 0 && location.X < ImageViewer.Image.Width &&
                location.Y >= 0 && location.Y < ImageViewer.Image.Height)
            {
                OcrObject obj = _ocrObjects.Find(location);
                _resultViewerTool.SelectedItem = obj;
                _focusedObject = obj;
                OnFocusedObjectChanged();
            }
        }

        /// <summary>
        /// Raises the MouseUp event.
        /// </summary>
        /// <param name="e">A VisualToolMouseEventArgs that contains the event data.</param>
        protected override void OnMouseUp(VisualToolMouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (_selectionTool.Rectangle.Width >= MIN_SELECTION_SIZE ||
                _selectionTool.Rectangle.Height >= MIN_SELECTION_SIZE)
            {
                _selectionTool.Rectangle = Rectangle.Empty;
                return;
            }

            _selectionTool.Rectangle = Rectangle.Empty;

            if (_page == null)
                return;

            Point location = ImageViewer.PointToImage(e.Location);
            OcrObject obj = _ocrObjects.Find(location);
            if (_isShiftKeyDown || _isCtrlKeyDown)
            {
                if (obj != null)
                    AddObjectsToSeletedObjects(_isCtrlKeyDown, obj);
            }
            else
            {
                if (obj != null)
                    SetSelectedObjects(obj);
                else
                    SetSelectedObjects(null);
            }
        }

        /// <summary>
        /// Raises the KeyDown event.
        /// </summary>
        /// <param name="e">A KeyEventArgs that contains the event data.</param>
        protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.Shift)
                _isShiftKeyDown = true;
            if (e.Control)
                _isCtrlKeyDown = true;
        }

        /// <summary>
        /// Raises the KeyUp event.
        /// </summary>
        /// <param name="e">A KeyEventArgs that contains the event data.</param>
        protected override void OnKeyUp(System.Windows.Forms.KeyEventArgs e)
        {
            base.OnKeyUp(e);

            if (!e.Shift)
                _isShiftKeyDown = false;
            if (!e.Control)
                _isCtrlKeyDown = false;
        }

        #endregion


        #region PRIVATE

        /// <summary>
        /// Handler of the RectangularSelectionTool.SelectionChanged event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="SelectionChangedEventArgs"/> instance containing the event data.</param>
        private void selectionTool_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_page == null)
                return;

            if (e.Rectangle.Width < MIN_SELECTION_SIZE && e.Rectangle.Height < MIN_SELECTION_SIZE)
                return;

            OcrObject[] objects = _page.GetObjects(ObjectsType, e.Rectangle);
            if (objects.Length > 0)
            {
                if (_isShiftKeyDown || _isCtrlKeyDown)
                    AddObjectsToSeletedObjects(false, objects);
                else
                    SetSelectedObjects(objects);
            }
        }

        /// <summary>
        /// Adds newly selected OCR objects to the selected OCR objects.
        /// </summary>
        /// <param name="removeIfContains">A value indicating whether visual tool must remove
        /// the object from the selected objects if object is already selected.</param>
        /// <param name="objects">Newly selected objects.</param>
        private void AddObjectsToSeletedObjects(bool removeIfContains, params OcrObject[] objects)
        {
            if (_selectedObjectsListBox != null)
                _selectedObjectsListBox.BeginUpdate();

            for (int i = 0; i < objects.Length; i++)
            {
                OcrObject obj = objects[i];
                if (!_selectedObjects.Contains(obj))
                {
                    _selectedObjects.Add(obj);
                    if (_selectedObjectsListBox != null)
                        _selectedObjectsListBox.Items.Add(obj);
                }
                else if (removeIfContains)
                {
                    _selectedObjects.Remove(obj);
                    if (_selectedObjectsListBox != null)
                        _selectedObjectsListBox.Items.Remove(obj);
                }
            }
            if (_selectedObjectsListBox != null)
                _selectedObjectsListBox.EndUpdate();
            SyncHighlightObjectsWithSelectedObjects();
        }

        /// <summary>
        /// Raises the FocusedObjectChanged event.
        /// </summary>
        private void OnFocusedObjectChanged()
        {
            if (FocusedObjectChanged != null)
                FocusedObjectChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// Synchronizes the highlight OCR objects with selected OCR objects.
        /// </summary>
        private void SyncHighlightObjectsWithSelectedObjects()
        {
            if (_highlightedObjects != null)
            {
                if (_highlightedObjects.Objects.Length == _selectedObjects.Count)
                {
                    bool needSynchronize = false;
                    for (int i = 0; i < _selectedObjects.Count; i++)
                    {
                        if (_selectedObjects[i] != _highlightedObjects.Objects[i])
                        {
                            needSynchronize = true;
                            break;
                        }
                    }
                    if (!needSynchronize)
                        return;
                }

                _resultViewerTool.Items.Remove(_highlightedObjects);
            }

            _highlightedObjects = new ColoredObjects<OcrObject>(_selectedObjects.ToArray());
            _highlightedObjects.Brush = SelectedObjectsBrush;
            _highlightedObjects.Pen = SelectedObjectsPen;
            _resultViewerTool.Items.Add(_highlightedObjects);
        }

        /// <summary>
        /// Refreshes the highlighted OCR objects from the OCR recognition results.
        /// </summary>
        private void RefreshHighlightedObjects()
        {
            if (_ocrObjects != null)
                _resultViewerTool.Items.Remove(_ocrObjects);

            _ocrObjects = new ColoredObjects<OcrObject>(_page.GetObjects(_objectsType));
            _ocrObjects.Pen = ObjectsPen;
            _ocrObjects.Brush = ObjectsBrush;
            _resultViewerTool.Items.Add(_ocrObjects);
        }

        /// <summary>
        /// Handler of the ListBox.SelectedIndexChanged event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void selectedObjectsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedObjectsListBox.SelectedIndex >= 0)
                FocusedObject = (OcrObject)_selectedObjectsListBox.SelectedItem;
        }

        #endregion

        #endregion



        #region Events

        public event EventHandler FocusedObjectChanged;

        #endregion

    }
}
