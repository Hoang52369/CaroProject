using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cờ_Caro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DrawChessBoard();  
        }
        //void DrawChessBoard()
        //{


        //    for (int i = 0; i < Cons.ChessBoardWeight; i++)
        //    {
        //        for(int j=0;j < Cons.ChessBoardHeight; j++)
        //        {
                    
        //            Button btn = new Button() { Width = Cons.ButtonSize , Height = Cons.ButtonSize };
        //            btn.FlatStyle = FlatStyle.Flat;
        //            btn.Text = (j + 1).ToString(); // Đặt text là số thứ tự
        //            // Thiết lập kích thước nút
        //            btn.Location = new Point(i *Cons.ButtonSize, j* Cons.ButtonSize);
        //            // Thêm nút vào panel
        //            panelChessBoard.Controls.Add(btn);
        //        }
                
        //    }
        //}
        void DrawChessBoard()
        {
            for (int i = 0; i < Cons.ChessBoardWeight; i++)
            {
                for (int j = 0; j < Cons.ChessBoardHeight; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.ButtonSize,
                        Height = Cons.ButtonSize,
                        Location = new Point(j * Cons.ButtonSize, i * Cons.ButtonSize) // Đặt vị trí theo hàng và cột
                    };
                    btn.FlatStyle = FlatStyle.Flat;
                    panelChessBoard.Controls.Add(btn);
                }
            }
        }
    }
}
