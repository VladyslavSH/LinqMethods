using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqMethods
{
    
    public partial class Form1 : Form
    {
        List<News> news = null;
        public Form1()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            news = new List<News>
            {
                new News{Title = "Гражданская война: главарь 'ДНР' прозрел и сдался Украине", Text = "Как установили правоохранители, мужчина присоединился к террористам еще в сентябре 2014 года. Изначально он вошел в состав так называемого 'Индустриального оплота Донбасса', где занимался поставкой в ОРДО удобрений, горюче-смазочных материалов и других товаров, закупкой зерна и конечной продукции сельского хозяйства.'Впоследствии, возглавив по предложению Захарченко' министерство агропромышленной политики и продовольствия' террористов, злоумышленник под кураторством российских спецслужб обеспечивал формирование штата и функционирование фейкового ведомства. Среди прочего, он также 'санкционировал' прибытие на оккупированные территории Донбасса грузов так называемого 'российского гуманитарного конвоя', - написано в сообщении." },
                new News{Title = "Джим Керри снялся в необычной постельной сцене", Text = "Голливудский актер Джим Керри, который недавно дал откровенное интервью, снялся в сериале 'Шучу' в необычной сексуальной сцене. По сюжету, партнершей его героя является онкобольная девушка, пишет The Daily Mail. В телевизионном шоу Керри предстает в образе звезды детских передач. А сам герой за пределами экранов переживает далеко не лучший период в жизни. В одной из сцен он занимается сексом с онкобольной девушкой, с которой знакомится во время посещения одной из больниц. Отмечается, что сама роль довольно драматична."}
            };
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = news[0].Title;
            textBox2.Text = news[0].Text;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(@"D:\Git\JimKerry.jpg");
            
        }
    }

    class News
    {
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
