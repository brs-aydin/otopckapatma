using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoKapatma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int gerisayim;//geri sayimi formda ki istediğim her bloğa kullanmak için int değerine tanıdım

    

        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox1.Text!="")//Textbox boş değilse yapılacaklar 
            {

                int sayi = Convert.ToInt32(textBox1.Text);//sayı değerini textboxta ki yazılana eşitliyorum

                gerisayim = sayi * 60;//Saat olarak hesapladığım ve timer intervalini dakika yaptığım için 60 ile çarpıyorum 
                label1.Text = gerisayim.ToString();//labeli geri sayımdaki ilk sayıya eşitliyorum ki 1 dk sayı gelmesi beklenmesin
               //burda da gizleme işlemi false olan gözükmüyor true olan gözüküyor
                textBox1.Visible = false;
                button1.Enabled = false;//buton kullanıma kapıyoruz.
                label2.Visible = false;
                label1.Visible = true;
                label3.Visible = true;
                pictureBox1.Visible = true;
                timer1.Start();//Zamanlayıcı baslıyor
            }
          
           
        }

   
        private void timer1_Tick(object sender, EventArgs e)
        {

                gerisayim--;//geri sayımda ki sayı düşüyor (intervale dikkat edin dakika için 60000 kullanıyoruz saniye için 1000)
                label1.Text = gerisayim.ToString();//labeli otomatik düzeltmesi icin yine geri sayıma bağladık
                if (gerisayim == 0)//geri sayım 0 i gösterdiğinde
                {

                    timer1.Stop();//timer duracak
                    System.Diagnostics.Process.Start("shutdown", "-f -s");//kapatma kodu calısacak
                
                }
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            //gizleme işlemleri
            label1.Visible = false;
            label3.Visible = false;
            pictureBox1.Visible = false;
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
          //gizleme işlemleri
            textBox1.Visible = true;
            button1.Enabled = true;
            label2.Visible = true;
            label1.Visible = false;
            label3.Visible = false;
            pictureBox1.Visible = false;
            textBox1.Clear();//textbox içinde ki kalan veriler silinecek
            timer1.Stop();//timer duracak
        }

  

      
     
        }
    }

