using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TSC.Class;

namespace TSC.View
{
    public partial class LogBox : UserControl
    {
        int _row = 0;
        int selRow = 0;
        bool hasSel = false, forceSel = false;
        int _topRow = 0; // First visible row
        int rowsVisible = 10, colsVisible = 7;
        Font drawFont = new Font(FontFamily.GenericMonospace/*"Courier New"*/, 12, GraphicsUnit.Pixel);
        Brush linesTextColor = Brushes.White;
        Brush selectionBrush = Brushes.LightSkyBlue;
        Brush selectionTextBrush = Brushes.White;
        float fontHeight;
        float fontWidth;
        bool hasFocus = false;
        int linesWidth = 100;
        bool ignoreScrollChange = false;
        int maxLines = 2000;
        public bool Autoscroll = true;
        List<LogLine> lines = new List<LogLine>();

        public LogBox()
        {
            InitializeComponent();
            fontHeight = drawFont.Height;
            log.MouseWheel += MouseWheelHandler;
        }

        private void DrawRow(Graphics g, int line, LogLine logline, float y)
        {
            int p = logline.text.IndexOf(" : ");
            string time = "", text = "";
            if (p < 0)
                text = logline.text;
            else
            {
                time = logline.text.Substring(0, p);
                text = logline.text.Substring(p + 3);
            }

            //Pen bgPen = Pens.White;
            //g.DrawLine(bgPen, 0, 27, log.Width, 27);
            //g.DrawLine(bgPen, log.Width*3 / 5, 0, log.Width*3 / 5, 27);
            //g.DrawLine(bgPen, log.Width * 4 / 5, 0, log.Width * 4 / 5, 27);

            // draw Nc Pos and Nc Alarm Exist

            //string NcPos = Main.main._3DControl1.ncPosX.ToString() + ", " + Main.main._3DControl1.ncPosY.ToString() + ", " + Main.main._3DControl1.ncPosZ.ToString();

            //g.DrawString(nc.X.ToString(), drawFont, linesTextColor, 10, 3);
            //g.DrawString(" " + nc.Y.ToString(), drawFont, linesTextColor, 70, 3);
            //g.DrawString(" " + nc.Z.ToString(), drawFont, linesTextColor, 140, 3);

            //g.DrawString(nc.NCmode(), drawFont, linesTextColor, (log.Width * 3 / 5) + 10, 3);
            //g.DrawString(nc.NCstate(), drawFont, linesTextColor, (log.Width * 4 / 5) + 5, 3);


            g.DrawString(text, drawFont, linesTextColor, linesWidth + 24, y);
            g.DrawString(time, drawFont, linesTextColor, linesWidth - fontWidth * time.Length + 22, y);
        }


        private void log_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SizeF sz = g.MeasureString("MMMMMMMMMM", drawFont);
            fontWidth = (int)(sz.Width / 10) + 1;
            fontHeight = (int)Math.Ceiling(sz.Height);
            string maxl = lines.Count.ToString();
            linesWidth = (int)(fontWidth * 12 + 6);
            rowsVisible = (int)Math.Ceiling((double)(log.Height - 30) / fontHeight);
            colsVisible = (int)Math.Ceiling((double)(log.Width - linesWidth) / fontWidth);

            int r;
            int rmax = rowsVisible;
            if (topRow + rmax >= lines.Count)
                rmax = lines.Count - topRow;
            for (r = 0; r < rmax; r++)
            {
                DrawRow(g, topRow + r, lines.ElementAt(topRow + r), r * fontHeight + 5);
            }
            ScrollBottom();
        }

        private void MouseWheelHandler(object sender, MouseEventArgs e)
        {
            if (e.Delta != 0)
            {
                if (e.Delta > 0)
                    topRow -= rowsVisible / 2;
                else
                    topRow += rowsVisible / 2;
               log.Invalidate();
            }
        }

        private int row
        {
            get { return _row; }
            set { _row = value; }
        }
        private int topRow
        {
            get { return _topRow; }
            set
            {
                _topRow = value; if (_topRow >= lines.Count) _topRow = lines.Count - 1;
                if (_topRow < 0) _topRow = 0;
                ignoreScrollChange = true;
                scroll.Maximum = Math.Max(_topRow, scroll.Maximum);
                scroll.Value = _topRow;
                ignoreScrollChange = false;
            }
        }
        public void Clear()
        {
            topRow = _row = selRow = 0;
            lines.Clear();
        }
        public void Add(LogLine l)
        {
            if (!hasFocus)
                while (lines.Count >= maxLines)
                {
                    _row--;
                    selRow--;
                    lines.RemoveAt(0);
                }
            lines.Add(l);
        }
        private void CursorDown()
        {
            if (row < lines.Count - 1)
            {
                row++;
                PositionShowCursor();
            }
        }
        private void CursorHome()
        {
            _row = topRow = 0;
            PositionShowCursor();
        }
        private void CursorEnd()
        {
            _row = lines.Count - 1;
            topRow = Math.Max(0, lines.Count - rowsVisible - 1);
            PositionShowCursor();
        }
        private void CursorPageDown()
        {
            if (row + rowsVisible < lines.Count)
            {
                topRow += rowsVisible - 1;
                row += rowsVisible - 1;
                PositionShowCursor();
            }
            else
            {
                row = lines.Count - 1;
                PositionShowCursor();
            }
        }
        private void CursorPageUp()
        {
            if (topRow > 0)
            {
                topRow -= rowsVisible - 1;
                row -= rowsVisible - 1;
                if (topRow < 0) topRow = 0;
                if (row < 0) { row = 0; }
                PositionShowCursor();
            }
            else
            {
                row = 0;
                PositionShowCursor();
            }
        }
        private void PositionShowCursor()
        {
            PositionShowCursor(false, true);
        }
        private void PositionShowCursor(bool repaint, bool moved)
        {
            scroll.Maximum = lines.Count();
            repaint |= hasSel;
            if (row < topRow)
            {
                topRow = row;
                repaint = true;
            }
            else if (row > topRow + rowsVisible - 2)
            {
                topRow = row - rowsVisible + 2;
                repaint = true;
            }
            if (moved)
            {
                if (Control.ModifierKeys == Keys.Shift)
                {
                    repaint = true;
                    hasSel = true;
                }
                else
                {
                    if (!forceSel)
                    {
                        selRow = row;
                        hasSel = false;
                    }
                }
            }
            else
            {
                selRow = row;
                hasSel = false;
            }
            log.Invalidate();

        }
        private void CursorUp()
        {
            if (row > 0)
            {
                row--;
                PositionShowCursor();
            }
        }

        public string getSelection()
        {
            if (lines.Count == 0) return ""; // Nothing to copy
            int rstart = row;
            int rend = selRow;
            if (row > selRow)
            {
                rstart = selRow;
                rend = row;
            }
            int i;
            rend = Math.Min(rend, lines.Count - 1);
            rstart = Math.Min(rstart, lines.Count - 1);
            StringBuilder sb = new StringBuilder();
            for (i = rstart; i <= rend; i++)
            {
                sb.AppendLine(lines[i].text);
            }
            return sb.ToString();
        }
        public bool hasSelection
        {
            get { return row != selRow; }
        }

        private void scrollRows_ValueChanged(object sender, EventArgs e)
        {
            topRow = scroll.Value;
            log.Invalidate();
        }

        private void scroll_ValueChanged(object sender, EventArgs e)
        {
            if (!ignoreScrollChange)
            {
                topRow = scroll.Value;
                log.Invalidate();
            }
        }

        public void UpdateBox()
        {
            ignoreScrollChange = true;
            topRow = Math.Min(topRow, lines.Count - rowsVisible - 1);
            scroll.Maximum = Math.Max(0, lines.Count - rowsVisible - 1);
            scroll.Value = topRow;
            scroll.LargeChange = Math.Max(1, rowsVisible - 1);
            if (Autoscroll && !hasFocus)
                ScrollBottom();
            ignoreScrollChange = false;
            log.Invalidate();
        }

        public void ScrollBottom()
        {
            if (lines.Count >= rowsVisible - 1)
            {
                topRow = lines.Count - rowsVisible + 1;
            }
        }

        public void UpdateLog()
        {
            log.Invalidate();
        }

    }
}
