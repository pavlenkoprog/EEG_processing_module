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
        [ Description( "Fired when SelectedMin or SelectedMax changes." )]
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
            int UserHeightMax = Height - 5;
            int UserWidthMax = Width - 30;

            //paint background in white
            //e.Graphics.FillRectangle( Brushes.White , ClientRectangle );
            //paint selection range in blue
            Rectangle selectionRect = new Rectangle(
                ( selectedMin - Min ) * UserWidthMax / ( Max - Min ) + 15 ,
                UserHeightMax - 5 ,
                ( selectedMax - selectedMin ) * UserWidthMax / ( Max - Min ) ,
                6 );
            e.Graphics.FillRectangle( Brushes.DodgerBlue , selectionRect );
            //draw a black frame around our control
            e.Graphics.DrawRectangle( Pens.LightGray , 15 , UserHeightMax - 21 , Width - 30 , 3);
            //draw a simple vertical line at the Value position
            for(int n=Max ;n>=0 ;n-- )
            {
            e.Graphics.DrawLine( Pens.LightGray ,
                ( n - Min ) * UserWidthMax / ( Max - Min ) +15 , UserHeightMax - 5 ,
                ( n - Min ) * UserWidthMax / ( Max - Min ) +15, UserHeightMax );
            }
            DrowThumb( (selectedMin - Min ) * UserWidthMax / ( Max - Min ) +15, e );
            DrowThumb( ( selectedMax - Min ) * UserWidthMax / ( Max - Min ) +15 , e );
        }

        //Рисую бегунки (Pos - позиция на шкале)
        void DrowThumb (int Pos , PaintEventArgs e )
        {
            int UserHeightMax = Height - 5;
            e.Graphics.FillPolygon( Brushes.DodgerBlue , new Point[ ]
                {
                    new Point(Pos,UserHeightMax - 10),new Point(Pos-5,UserHeightMax - 15),
                    new Point(Pos-5,UserHeightMax - 15),new Point(Pos-5,UserHeightMax - 25),
                    new Point(Pos-5,UserHeightMax - 25),new Point(Pos+5,UserHeightMax - 25),
                    new Point(Pos+5,UserHeightMax - 25),new Point(Pos+5,UserHeightMax - 15),
                    new Point(Pos+5,UserHeightMax - 15),new Point(Pos,UserHeightMax - 10)
                }
                );

        }

        void SelectionRangeSlider_MouseDown( object sender , MouseEventArgs e )
        {
            int UserWidthMax = Width - 30;
            //check where the user clicked so we can decide which thumb to move
            int pointedValue = Min + e.X * ( Max - Min ) / UserWidthMax;
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
            int UserWidthMax = Width - 30;
            //if the left button is pushed, move the selected thumb
            if( e.Button != MouseButtons.Left )
                return;
            int pointedValue = Min + e.X * ( Max - Min ) / UserWidthMax-1 ;
            if( movingMode == MovingMode.MovingMin && ( pointedValue < SelectedMax ) && ( pointedValue > 0 ) )
                SelectedMin = pointedValue;
            else if( movingMode == MovingMode.MovingMax && ( pointedValue > SelectedMin ) && ( pointedValue < Max ) )
                SelectedMax = pointedValue;
        }

        /// <summary>
        /// To know which thumb is moving
        /// </summary>
        enum MovingMode { MovingMin, MovingMax }
        MovingMode movingMode;
    }
}
