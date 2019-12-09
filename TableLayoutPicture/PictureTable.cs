using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableLayoutPicture
{
    public partial class PictureTable : UserControl
    {
        [Category("#Custom"), Description("Image of OK")]
        public Image ImageOK { get; set; }
        [Category("#Custom"), Description("Image of NOK")]
        public Image ImageNG { get; set; }

        PictureBoxSizeMode _pictureSizeMode;
        [Category("#Custom"), Description("Size mode of the picture")]
        public PictureBoxSizeMode PictureSizeMode
        {
            get
            {
                return _pictureSizeMode;
            }
            set
            {
                if (value == PictureBoxSizeMode.AutoSize)
                {
                    value = PictureBoxSizeMode.Zoom;
                }
                _pictureSizeMode = value;
            }
        }

        private int _rowCount;
        [Category("#Custom"), Description("The row count of table")]
        public int RowCount
        {
            get
            {
                return _rowCount;
            }
            set
            {
                table.SuspendLayout();
                if (value > 1)
                {
                    _rowCount = value;
                }
                else
                {
                    _rowCount = 1;
                }
                table.RowCount = _rowCount;

                table.RowStyles.Clear();
                for (int i = 0; i < _rowCount; i++)
                {
                    table.RowStyles.Add(new RowStyle(SizeType.Percent, 0.5f));
                }
                ResetPictureBoxes(_columnCount, _rowCount);
                table.ResumeLayout();
            }
        }

        private int _columnCount;
        [Category("#Custom"), Description("The column count of table")]
        public int ColumnCount
        {
            get
            {
                return _columnCount;
            }
            set
            {
                table.SuspendLayout();
                if (value > 1)
                {
                    _columnCount = value;
                }
                else
                {
                    _columnCount = 1;
                }
                table.ColumnCount = _columnCount;

                table.ColumnStyles.Clear();
                for (int i = 0; i < _columnCount; i++)
                {
                    table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.5f));
                }
                ResetPictureBoxes(_columnCount, _rowCount);
                table.ResumeLayout();
            }
        }

        public enum IndexOrder
        {
            LeftToRightThenUpToDown = 0,
            LeftToRightThenDownToUp,
            RightToLeftThenUpToDown,
            RightToLeftThenDownToUp,
            UpToDownThenLeftToRight,
            UpToDownThenRightToLeft,
            DownToUpThenLeftToRight,
            DownToUpThenRightToLeft
        }


        [Category("#Custom"), Description("The order to index the picture in the table")]
        public IndexOrder Order { get; set; }

        public PictureTable()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row">1 base</param>
        /// <param name="column">1 base</param>
        /// <param name="ok"></param>
        public void ShowImage(int row, int column, bool ok)
        {
            int row_0 = row - 1;
            int column_0 = column - 1;
            if (row_0 < 0 || column_0 < 0)
            {
                return;
            }
            if (row_0 < _rowCount && column_0 < _columnCount)
            {
                (table.Controls[row_0 * _columnCount + column_0] as PictureBox).Image = ok ? ImageOK : ImageNG;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index">1 base</param>
        /// <param name="ok"></param>
        public void ShowImage(int index, bool ok)
        {
            ConvertIndexToRowAndColumn(index, out int row, out int column);

            ShowImage(row, column, ok);
        }

        /// <summary>
        /// Clear all image in the table
        /// </summary>
        public void ClearImage()
        {
            for (int i = 0; i < _rowCount; i++)
            {
                for (int j = 0; j < _columnCount; j++)
                {
                    (table.Controls[i * _columnCount + j] as PictureBox).Image = null;
                }
            }
        }

        /// <summary>
        /// Convert the index to row and column
        /// </summary>
        /// <param name="index">1 base</param>
        /// <param name="row">1 base</param>
        /// <param name="column">1 base</param>
        private void ConvertIndexToRowAndColumn(int index, out int row, out int column)
        {
            int div = (index - 1) / _columnCount;
            int mod = (index - 1) % _columnCount;

            int div2 = (index - 1) / _rowCount;
            int mod2 = (index - 1) % _rowCount;

            switch (Order)
            {
                case IndexOrder.LeftToRightThenUpToDown:
                    row = div + 1;
                    column = mod + 1;
                    break;

                case IndexOrder.LeftToRightThenDownToUp:
                    row = _rowCount - div;
                    column = mod + 1;
                    break;

                case IndexOrder.RightToLeftThenUpToDown:
                    row = div + 1;
                    column = _columnCount - mod;
                    break;

                case IndexOrder.RightToLeftThenDownToUp:
                    row = _rowCount - div;
                    column = _columnCount - mod;
                    break;

                case IndexOrder.UpToDownThenLeftToRight:
                    row = mod2 + 1;
                    column = div2 + 1;
                    break;

                case IndexOrder.UpToDownThenRightToLeft:
                    row = mod2 + 1;
                    column = _columnCount - div2;
                    break;

                case IndexOrder.DownToUpThenLeftToRight:
                    row = _rowCount - mod2;
                    column = div2 + 1;
                    break;

                case IndexOrder.DownToUpThenRightToLeft:
                    row = _rowCount - mod2;
                    column = _columnCount - div2;
                    break;

                default:
                    row = div + 1;
                    column = mod + 1;
                    break;
            }
        }


        private void ResetPictureBoxes(int columnCount, int rowCount)
        {
            table.Controls.Clear();

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    PictureBox picture = new PictureBox();
                    picture.SizeMode = _pictureSizeMode;
                    table.Controls.Add(picture, j, i);
                }
            }
        }
    }
}
