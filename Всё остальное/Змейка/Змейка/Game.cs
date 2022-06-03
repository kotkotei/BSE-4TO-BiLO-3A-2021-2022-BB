using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Threading;

namespace Змейка
{
    class Game//Класс соединяющий объекты и реализующий логику игры
    {
        Snake my_snake = new Snake(Color.Green);
        Food my_food = new Food(Color.Red);
        Block my_block =new  Block (Color.Black);

        public int count = 0;
        int l = 50; //Масштаб одоного блока
        Color pole = Color.White;
        PictureBox myPb;

        public Game(PictureBox n_myPb)
        {
            myPb  = n_myPb;
            LoadLevel(1);
            RandomFood();
            RandomFood();
            Show();
        }

        public void LoadLevel (int n)
        {
            StreamReader sr = new StreamReader(n.ToString() + ".txt");
            int str = 0;
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                for (int i=0; i<s.Length; i++)
                {
                    if (s[i] == '*')
                    {
                        my_block.Add(new Mypoint(i, str));

                    }
                    else if (s[i] == '$')
                    {
                        my_snake.Add(new Mypoint(i, str));

                    }
                }
                str++;
               
            }
            sr.Close();
                                 
        }
        public void Edacollision()
        {
            for (int i = 0; i < my_food.body.Count; i++)
            {
                if (my_food.body[i].x==my_snake.body[0].x && my_food.body[i].y ==my_snake.body[0].y)
                {
                    my_food.Delete(i); //удалить старую еду
                    my_snake.AddHvost(); //Удалить хвост
                    RandomFood(); // Добавить новую еду
                    count++;
                }
            }
        }
      

        public void RandomFood()
        {
            bool f = false;
            Mypoint p;

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

            } while (f);   
            my_food.Add(p);
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
            for (int i = 0; i< my_snake.body.Count; i++)
            {
                if (i == 0)
                {
                    gr.FillRectangle(color_snake1, my_snake.body[i].x * k, my_snake.body[i].y * k, k, k);
                }
                else
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
                my_snake.Move(0,  1);
            }
            else if (k == 3)
            {
                my_snake.Move(1,0);
            }
            else if (k == 4)
            {
                my_snake.Move(-1, 0);
            }

            Edacollision();
            a = Crush();
            if (a== true)
            {
                Show();
            }
            Show();
            return a;
        }
        public bool Crush()
        {
            bool t = true;
            for (int i = 0; i < my_block.body.Count; i++)
            {
                if (my_snake.body[0].x== my_block.body[i].x && my_snake.body[0].y ==my_block.body[i].y)
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
