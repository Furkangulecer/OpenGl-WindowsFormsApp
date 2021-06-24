using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.Platform.Windows;

namespace _18_701_006
{
    public partial class Form1 : Form
    {
        float alfa = 0;

        public Form1()
        {
            InitializeComponent();
            OpenGlControl.InitializeContexts();
            //ik işlem
            Gl.glClearColor(0.0f, 0.0f, 0.5f, 0.0f);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glOrtho(0.0, 1.0, 0.0, 1.0, -1.0, 1.0);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MyPaint(object sender, PaintEventArgs e)
        {
           
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glShadeModel(Gl.GL_SMOOTH);

            // Gl.glTranslatef(x,y,z);
            Gl.glPushMatrix();

            Gl.glTranslatef(0.5f, 0.5f, 0); //geri
            Gl.glRotatef(alfa, 0, 0, 1);
            Gl.glTranslatef(-0.5f, -0.5f, 0); //merkez çakıştırma
            Gl.glBegin(Gl.GL_TRIANGLES);
               Gl.glColor3f(1.0f, 0.0f, 0.0f); //kırmızı
               Gl.glVertex3f(0.5f, 1.0f, 0.0f);

               Gl.glColor3f(1.0f, 1.0f, 0.0f);  //sarı
               Gl.glVertex3f(0.0f, 0.0f, 0.0f);

               Gl.glColor3f(0.0f, 0.0f, 1.0f);  
               Gl.glVertex3f(1.0f, 0.0f, 0.0f);

            Gl.glEnd();
            Gl.glPopMatrix();

        }

        private void buttonDondur_Click(object sender, EventArgs e)
        {
            alfa = (alfa + 10) % 360;
            OpenGlControl.Refresh();
             
        }

        private void MyKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F)
                alfa = (alfa + 5) % 360;
            if (e.KeyCode == Keys.G)
                alfa = (alfa - 5) % 360;
            OpenGlControl.Refresh();

        }
    }
}
