using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;

using System.Windows.Forms;
using System.Threading;

namespace Проект
{
    public class Game
    {
        Snake my_snake = new Snake(Color.Green);
        Food my_food = new Food(Color.Red);
        Food my_food2 = new Food(Color.Blue);
        Block my_block = new Block(Color.Black);

        public int count = 0;
        int l = 50;// Масштаб одного блока
        Color pole = Color.White;
        PictureBox myPb;

        public Game(PictureBox n_myPb)
        {
            myPb = n_myPb;
            LoadLevel(1);
            RandomFood();
            
            Show();
        }

        public void LoadLevel(int n)
        {
            StreamReader sr = new StreamReader(n.ToString() + ".txt");
            int str = 0;
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '*')
                    {
                        my_block.Add(new MyPoint(i, str));

                    }
                    else if (s[i] == '$')
                    {
                        my_snake.Add(new MyPoint(i, str));

                    }
                }
                str++;
            }
            sr.Close();
        }
        public void EdaColision()
        {
            for (int i = 0; i < my_food2.body.Count; i++)
            {
                for (int j = 0; j < my_snake.body.Count; j++)
                {

                    if (my_food2.body[i].x == my_snake.body[j].x && my_food2.body[i].y == my_snake.body[j].y)
                    {
                        my_food2.Delete(i);
                        count--;
                        //my_snake.AddHvost();
                        RandomFood();

                    }
                }
            }
            for (int i = 0; i < my_food.body.Count; i++)
            {
                for (int j = 0; j < my_snake.body.Count; j++)
                {

                    if (my_food.body[i].x == my_snake.body[j].x && my_food.body[i].y == my_snake.body[j].y)
                    {
                        my_food.Delete(i);
                        count++;
                        //my_snake.AddHvost();
                        RandomFood();
                        
                    }
                }
            }
        }
        public void RandomFood()
        {
            /*bool f = false;
            MyPoint p;
            do
            {
                f = false;
                p = my_food.RandomFood(l, l);
                for (int i = 0; i < my_snake.body.Count; i++)
                {
                    if (p.x == my_snake.body[i].x && p.y == my_snake.body[i].y)
                    {
                        f = true;
                    }
                }
                for (int i = 0; i < my_block.body.Count; i++)
                {
                    if (p.x == my_block.body[i].x && p.y == my_block.body[i].y)
                    {
                        f = true;
                    }
                }
                for (int i = 0; i < my_food.body.Count; i++)
                {
                    if (p.x == my_food.body[i].x && p.y == my_food.body[i].y)
                    {
                        f = true;
                    }
                }
            } while (f);*/
            MyPoint p = my_food.RandomFood(l, l);
            my_food.Add(p);
            Thread.Sleep(100);
            MyPoint r = my_food2.RandomFood(l, l);
            my_food2.Add(r);
            Thread.Sleep(100);
        }
        public void Show()
        {
            int k = myPb.Width / l;
            Graphics gr = Graphics.FromImage(myPb.Image);
            SolidBrush cl = new SolidBrush(pole);
            gr.FillRectangle(cl, 0, 0, myPb.Width, myPb.Height);
            SolidBrush color_snake1 = new SolidBrush(Color.Purple);
            SolidBrush color_snake = new SolidBrush(my_snake.color);
            for (int i = 0; i < my_snake.body.Count; i++)
            {
                /*if (i == 0)
                {
                    gr.FillRectangle(color_snake1, my_snake.body[i].x * k, my_snake.body[i].y * k, k, k);
                }
                else*/
                {
                    gr.FillRectangle(color_snake, my_snake.body[i].x * k, my_snake.body[i].y * k, k, k);
                }

            }
            SolidBrush color_block = new SolidBrush(my_block.color);
            for (int i = 0; i < my_block.body.Count; i++)
            {
                gr.FillRectangle(color_block, my_block.body[i].x * k, my_block.body[i].y * k, k, k);
            }
            SolidBrush color_food = new SolidBrush(my_food.color);
            for (int i = 0; i < my_food.body.Count; i++)
            {
                gr.FillRectangle(color_food, my_food.body[i].x * k, my_food.body[i].y * k, k, k);
            }
            SolidBrush color_food2 = new SolidBrush(my_food2.color);
            for (int i = 0; i < my_food2.body.Count; i++)
            {
                gr.FillEllipse(color_food2, my_food2.body[i].x * k, my_food2.body[i].y * k, k, k);
            }

            myPb.Refresh();

        }
        public bool Move(int k)
        {
            bool a = true;
            if (k == 1)
            {
                my_snake.Move(0, -1);
            }
            else if (k == 2)
            {
                my_snake.Move(0, 1);

            }
            else if (k == 3)
            {
                my_snake.Move(1, 0);
            }
            else if (k == 4)
            {
                my_snake.Move(-1, 0);
            }
            EdaColision();
            a = Crush();
            if (a == true)
            {
                Show();
            }

            return a;

        }
        public bool MoveFood2()
        {
            my_food2.Move();
            EdaColision();
            bool f = true;
            for (int i = 0; i < my_food2.body.Count; i++)
            {
                if (my_food2.body[i].y > l)
                {
                    f = false;
                }
            }

            Show();
            return f;
            /*my_food2.Move();
            Show();*/
        }

        public bool MoveFood()
        {
            my_food.Move();
            EdaColision();
            bool f = true;
            for (int i=0; i< my_food.body.Count; i++)
            {
                if (my_food.body[i].y > l)
                {
                    f = false;
                }
            }
            
            Show();
            return f;
        }
        public bool Crush()
        {
            bool t = true;
            for (int i = 0; i < my_block.body.Count; i++)
            {
                if (my_snake.body[0].x == my_block.body[i].x && my_snake.body[0].y == my_block.body[i].y)
                {
                    t = false;
                    break;
                }
            }
            for (int i = 1; i < my_snake.body.Count; i++)
            {
                if (my_snake.body[0].x == my_snake.body[i].x && my_snake.body[0].y == my_snake.body[i].y)
                {
                    t = false;
                    break;
                }
            }
            return t;
        }
    }
}
