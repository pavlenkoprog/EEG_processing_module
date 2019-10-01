using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainModuleEEGprocessing
{
    /// <summary>
    /// Very basic slider control with selection range.
    /// </summary>
    [Description( "Very basic slider control with selection range." )]
    public partial class SelectionRangeSlider : UserControl
    {
        /// <summary>
        /// Minimum value of the slider.
        /// </summary>
        [Description( "Minimum value of the slider." )]
        public int Min
        {
            get { return min; }
            set { min = value; Invalidate( ); }
        }
        int min = 0;
        /// <summary>
        /// Maximum value of the slider.
        /// </summary>
        [Description( "Maximum value of the slider." )]
        public int Max
        {
            get { return max; }
            set { max = value; Invalidate( ); }
        }
        int max = 50;
        /// <summary>
        /// Minimum value of the selection range.
        /// </summary>
        [Description( "Minimum value of the selection range." )]
        public int SelectedMin
        {
            get { return selectedMin; }
            set
            {
                selectedMin = value;
                if( SelectionChanged != null )
                    SelectionChanged( this , null );
                Invalidate( );
            }
        }
        int selectedMin = 0;
        /// <summary>
        /// Maximum value of the selection range.
        /// </summary>
        [Description( "Maximum value of the selection range." )]
        public int SelectedMax
        {
            get { return selectedMax; }
            set
            {
                selectedMax = value;
                if( SelectionChanged != null )
                    SelectionChanged( this , null );
                Invalidate( );
            }
        }
        int selectedMax = 50;
        
        /// <summary>
        /// Fired when SelectedMin or SelectedMax changes.
        /// </summary>
        [Description( "Fired when SelectedMin or SelectedMax changes." )]
        public event EventHandler SelectionChanged;

        public SelectionRangeSlider()
        {
            InitializeComponent( );
            //avoid flickering
            SetStyle( ControlStyles.AllPaintingInWmPaint , true );
            SetStyle( ControlStyles.OptimizedDoubleBuffer , true );
            Paint += new PaintEventHandler( SelectionRangeSlider_Paint );
            MouseDown += new MouseEventHandler( SelectionRangeSlider_MouseDown );
            MouseMove += new MouseEventHandler( SelectionRangeSlider_MouseMove );
        }

        void SelectionRangeSlider_Paint( object sender , PaintEventArgs e )
        {
            //paint background in white
            e.Graphics.FillRectangle( Brushes.White , ClientRectangle );
            //paint selection range in blue
            Rectangle selectionRect = new Rectangle(
                ( selectedMin - Min ) * Width / ( Max - Min ) ,
                Height-Height / 5 ,
                ( selectedMax - selectedMin ) * Width / ( Max - Min ) ,
                Height/5 );
            e.Graphics.FillRectangle( Brushes.Blue , selectionRect );
            for( int n = 10 ; n <= 0 ; n-- )
            {
                e.Graphics.DrawLine( Pens.Black ,
                    1 , 0 ,
                    2 , Height );
            }
            //draw a black frame around our control
            //e.Graphics.DrawRectangle( Pens.Black , 0 , 0 , Width - 1 , Height - 1 );
            //draw a simple vertical line at the Value position

        }

        void SelectionRangeSlider_MouseDown( object sender , MouseEventArgs e )
        {
            //check where the user clicked so we can decide which thumb to move
            int pointedValue = Min + e.X * ( Max - Min ) / Width;
            //int distValue = Math.Abs( pointedValue - Value );
            int distMin = Math.Abs( pointedValue - SelectedMin );
            int distMax = Math.Abs( pointedValue - SelectedMax );
            int minDist = Math.Min( distMin , distMax ) ;
            
            if( minDist == distMin )
                movingMode = MovingMode.MovingMin;
            else
                movingMode = MovingMode.MovingMax;
            //call this to refreh the position of the selected thumb
            SelectionRangeSlider_MouseMove( sender , e );
        }

        void SelectionRangeSlider_MouseMove( object sender , MouseEventArgs e )
        {
            //if the left button is pushed, move the selected thumb
            if( e.Button != MouseButtons.Left )
                return;
            int pointedValue = Min + e.X * ( Max - Min ) / Width;
            if( movingMode == MovingMode.MovingMin )
                SelectedMin = pointedValue;
            else if( movingMode == MovingMode.MovingMax )
                SelectedMax = pointedValue;
        }

        /// <summary>
        /// To know which thumb is moving
        /// </summary>
        enum MovingMode { MovingMin, MovingMax }
        MovingMode movingMode;
    }
}
