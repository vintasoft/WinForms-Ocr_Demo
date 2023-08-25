using System;
using System.Drawing;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Ocr;
using Vintasoft.Imaging.UI.VisualTools.UserInteraction;
using Vintasoft.Imaging.UI.VisualTools;


namespace OcrDemo
{
    /// <summary>
    /// Represents a visual tool for viewing and editing the text recognition regions.
    /// </summary>
    public class RecognitionRegionEditorTool : MultiRectangularSelectionTool
    {

        #region Constants

        /// <summary>
        /// Minimum selection size.
        /// </summary>
        const int MIN_SELECTION_SIZE = 10;

        #endregion



        #region Fields

        /// <summary>
        /// New rectangle.
        /// </summary>
        RectangularSelection _newRectangle = null;

        /// <summary>
        /// The current interaction area action.
        /// </summary>
        InteractionAreaAction _currentInteractionAreaAction;

        /// <summary>
        /// The focused region bounding box.
        /// </summary>
        Rectangle _focusedRegionBoundingBox = Rectangle.Empty;

        /// <summary>
        /// Recognition regions.
        /// </summary>
        RecognitionRegion[] _regions;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RecognitionRegionEditorTool"/> class.
        /// </summary>
        public RecognitionRegionEditorTool()
            : base()
        {
        }

        #endregion



        #region Properties

        Brush _regionsBrush = new SolidBrush(Color.FromArgb(24, 0, 192, 0));
        /// <summary>
        /// Gets or sets the brush used to highlight the region.
        /// </summary>
        public Brush RegionsBrush
        {
            get
            {
                return _regionsBrush;
            }
            set
            {
                _regionsBrush = value;
            }
        }

        Pen _regionsPen = new Pen(Color.FromArgb(192, 0, 128, 0));
        /// <summary>
        /// Gets or sets the pan used to stroke the region.
        /// </summary>
        public Pen RegionsPen
        {
            get
            {
                return _regionsPen;
            }
            set
            {
                _regionsPen = value;
            }
        }

        RecognitionRegion _focusedRegion = null;
        /// <summary>
        /// Gets or sets the selected region.
        /// </summary>
        public RecognitionRegion FocusedRegion
        {
            get
            {
                return _focusedRegion;
            }
            set
            {
                if (value == null)
                {
                    FocusedSelectionItem = null;
                }
                else
                {
                    _focusedRegionLanguages = value.Languages;
                    Rectangle recognitionBbox = value.GetBoundingBox();
                    if (FocusedSelectionItem != null &&
                        recognitionBbox == FocusedSelectionItem.SelectedRect)
                        return;
                    // search selected region
                    foreach (RectangularSelection rectangle in Selection)
                    {
                        if (rectangle.SelectedRect == recognitionBbox)
                        {
                            FocusedSelectionItem = rectangle;
                            break;
                        }
                    }
                }
            }
        }

        Brush _focusedRegionBrush = new SolidBrush(Color.FromArgb(128, 0, 255, 255));
        /// <summary>
        /// Gets or sets the brush used to highlight the focused region.
        /// </summary>
        public Brush FocusedRegionBrush
        {
            get
            {
                return _focusedRegionBrush;
            }
            set
            {
                _focusedRegionBrush = value;
            }
        }

        Pen _focusedRegionPen = new Pen(Color.FromArgb(192, 64, 128, 0));
        /// <summary>
        /// Gets or sets the pan used to stroke the focused region.
        /// </summary>
        public Pen FocusedRegionPen
        {
            get
            {
                return _focusedRegionPen;
            }
            set
            {
                _focusedRegionPen = value;
            }
        }

        OcrLanguage[] _focusedRegionLanguages;
        /// <summary>
        /// Gets or sets the OCR languages of the focused region.
        /// </summary>
        public OcrLanguage[] FocusedRegionLanguages
        {
            get
            {
                return _focusedRegionLanguages;
            }
            set
            {
                _focusedRegionLanguages = value;
            }
        }

        #endregion



        #region Methods

        #region PUBLIC

        /// <summary>
        /// Adds new recognition region to the recognition regions and
        /// begins the region building.
        /// </summary>
        /// <param name="rectangle">A rectangle that represents new recognition region.</param>
        public new void AddAndBuild(RectangularSelection rectangle)
        {
            _newRectangle = new RectangularSelection();
            Rectangle selectionRectangleSelectionBoundingBox = new Rectangle(0, 0, this.ImageViewer.Image.Width, this.ImageViewer.Image.Height);
            _newRectangle.SelectionBoundingBox = selectionRectangleSelectionBoundingBox;
            RectangularObjectBuilder builder = new RectangularObjectBuilder(_newRectangle);
            builder.InteractionAreas[0].ActionMouseButton = ActionButton;

            ((IInteractiveObject)_newRectangle).InteractionController = builder;

            Selection.Add(_newRectangle);
            FocusedItem = _newRectangle;
            InvalidateItem(_newRectangle);
        }

        /// <summary>
        /// Sets the recognition regions.
        /// </summary>
        /// <param name="regions">Recognition regions.</param>
        public void SetRegions(RecognitionRegion[] regions)
        {
            _focusedRegionBoundingBox = Rectangle.Empty;
            if (FocusedRegion != null)
                _focusedRegionBoundingBox = FocusedRegion.Rectangle.GetBoundingBox();

            if (ImageViewer.Image == null)
                return;

            _regions = regions;
            Selection.Clear();
            if (_regions != null)
            {
                Rectangle selectionRectangleSelectionBoundingBox = new Rectangle(0, 0, this.ImageViewer.Image.Width, this.ImageViewer.Image.Height);
                foreach (RecognitionRegion recognitionRegion in _regions)
                {
                    Rectangle recognitionBbox = recognitionRegion.GetBoundingBox();
                    RectangularSelection selectionRectangle = new RectangularSelection(recognitionBbox, _regionsBrush, _regionsPen);
                    selectionRectangle.SelectionBoundingBox = selectionRectangleSelectionBoundingBox;
                    Selection.Add(selectionRectangle);
                    if (!_focusedRegionBoundingBox.IsEmpty && recognitionBbox == _focusedRegionBoundingBox)
                        FocusedRegion = recognitionRegion;
                }
            }

            if (!_focusedRegionBoundingBox.IsEmpty)
            {
                _focusedRegionBoundingBox = Rectangle.Empty;
                OnFocusedRegionChanged();
            }
        }

        #endregion


        #region PROTECTED

        /// <summary>
        /// Finishes an active interaction.
        /// </summary>
        /// <param name="item">Active item.</param>
        /// <param name="invalidateItem">A value indicating whether the active item must be invalidated.</param>
        protected override void FinishInteraction(IInteractiveObject item, bool invalidateItem)
        {
            if (item != null &&
                item.InteractionController is RectangularObjectBuilder &&
                _currentInteractionAreaAction != InteractionAreaAction.Cancel)
            {
                base.FinishInteraction(item, invalidateItem);
                if (_newRectangle.SelectedRect.Width > MIN_SELECTION_SIZE ||
                   _newRectangle.SelectedRect.Height > MIN_SELECTION_SIZE)
                {
                    RegionOfInterest regionOfInterest = new RegionOfInterest(Rectangle.Round(_newRectangle.SelectedRect));
                    _focusedRegion = new RecognitionRegion(
                        regionOfInterest,
                        _focusedRegionLanguages,
                        RecognitionRegionType.RecognizeSingleBlock,
                        0);
                    OnFocusedRegionChanged();
                }
                else
                {
                    Selection.Remove(_newRectangle);
                }
                _newRectangle = null;
            }
            else
                base.FinishInteraction(item, invalidateItem);
        }

        /// <summary>
        /// Raises the interaction event for specified interactive object. 
        /// </summary>
        /// <param name="item">The interactive object.</param>
        /// <param name="args">The interaction event args.</param>
        protected override bool OnInteraction(IInteractiveObject item, InteractionEventArgs args)
        {
            _currentInteractionAreaAction = args.Action;
            return base.OnInteraction(item, args);
        }

        /// <summary>
        /// Occurs when focused item is changed.
        /// </summary>
        /// <param name="e">An event args that contains the event data.</param>
        protected override void OnFocusedItemChanged(PropertyChangedEventArgs<IInteractiveObject> e)
        {
            base.OnFocusedItemChanged(e);

            RectangularSelection oldValue = (RectangularSelection)e.OldValue;
            if (e.OldValue != null)
            {
                oldValue.Brush = _regionsBrush;
                oldValue.Pen = _regionsPen;
            }
            RectangularSelection newValue = (RectangularSelection)e.NewValue;
            if (e.NewValue != null)
            {
                newValue.Brush = _focusedRegionBrush;
                newValue.Pen = _focusedRegionPen;
            }

            if (_newRectangle != null || !_focusedRegionBoundingBox.IsEmpty)
                return;

            if (FocusedSelectionItem == null)
                _focusedRegion = null;
            else
            {
                Rectangle focusedRectangle = Rectangle.Round(newValue.SelectedRect);
                foreach (RecognitionRegion region in _regions)
                    if (region.GetBoundingBox() == focusedRectangle)
                    {
                        _focusedRegion = region;
                        break;
                    }
            }

            OnFocusedRegionChanged();
        }

        /// <summary>
        /// Raises the <see cref="FocusedRectangleInteractionFinished"/> event.
        /// </summary>
        /// <param name="e">An <see cref="EventArgs"/> 
        /// that contains the event data.</param>
        protected override void OnFocusedRectangleInteractionFinished(EventArgs e)
        {
            base.OnFocusedRectangleInteractionFinished(e);

            if (_newRectangle != null)
                return;

            if (FocusedSelectionItem != null)
            {
                if (FocusedSelectionItem.SelectedRect == _focusedRegion.Rectangle.GetBoundingBox())
                    return;

                RegionOfInterest region = new RegionOfInterest(Rectangle.Round(FocusedSelectionItem.SelectedRect));
                RecognitionRegion newRegion = new RecognitionRegion(
                    region,
                    _focusedRegionLanguages,
                     RecognitionRegionType.RecognizeSingleBlock,
                    _focusedRegion.TextRotation);

                PropertyChangedEventArgs<RecognitionRegion> args = new PropertyChangedEventArgs<RecognitionRegion>(
                    _focusedRegion, newRegion);

                for (int i = 0; i < _regions.Length; i++)
                {
                    if (_regions[i].Rectangle == _focusedRegion.Rectangle)
                    {
                        _regions[i] = newRegion;
                        break;
                    }
                }
                _focusedRegion = newRegion;

                if (FocusedRegionInteractionFinished != null)
                    FocusedRegionInteractionFinished(this, args);
            }
        }

        /// <summary>
        /// Raises the FocusedRegionChanged event.
        /// </summary>
        protected void OnFocusedRegionChanged()
        {
            if (FocusedRegionChanged != null)
                FocusedRegionChanged(this, EventArgs.Empty);
        }

        #endregion

        #endregion



        #region Events

        /// <summary>
        /// Occurs when focused region is changed.
        /// </summary>
        public event EventHandler FocusedRegionChanged;

        /// <summary>
        /// Occurs when interaction with focused region is finished.
        /// </summary>
        public event PropertyChangedEventHandler<RecognitionRegion> FocusedRegionInteractionFinished;

        #endregion

    }
}
