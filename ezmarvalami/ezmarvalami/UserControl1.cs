using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ezmarvalami
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            //var eredmeny = from x in context.Instructors
            //             select x;
            //listBox1.DataSource = eredmeny.ToList();
            listBox1.DisplayMember = "Name";


            //hány elemből állt az a ábla ami az instruktorok at tartalmazza?
            var oktatoszam = context.Instructors.Count();

            var legmagasabbstatusz = (from x in context.Instructors
                                     select x.StatusFk).Max(); //úgy is lehet h Sort, és első eleme

            //listázd ki a legmagassabb beosztású oktatókat!!
            var legrangosabb = from x in contex.Instructors
                               where x.StatusFk == legmagasabbstatusz
                               select x.Name;
            label1.Text = legrangosabb;
            MessageBox.Show($"{string.Join(',', legrangosabb)}");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedItem == null)
            {
                return;
            }
            Instructor instructor = listBox1.SelectedItem as Instructor;

            var orak = from x in context.Lessons
                       where x.InsructorFk == instructor.InsructorSk
                       select new{
                                    Kurzus = x.CourseFkNavigation.Name,
                                    kod = x.CourseFkNavigation.Code,
                                    Nap = x.DayFkNavigation.Name,
                                    Sav = x.TimeFkNavigation.Name,
                                    terem = x.RoomFkNavigation.Name
                            };
            dataGridView1.DataSource = orak.ToLIst();

        }
    }
    class Reszletora
    {

        public string Kurzus { get; set; }
        public string Nap { get; set; }
        public string Sav { get; set; }
    }
}
