using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            cb_Pol.Items.Add("Мужской");
            cb_Pol.Items.Add("Женский");
            cb_Pol.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Familiy = tb_Familiya.Text.Replace(" ", "");
            client.Name = tb_Name.Text.Replace(" ", "");
            client.Otchestvo = tb_Otchestvo.Text.Replace(" ", "");
            client.ID_Pol = Convert.ToByte(cb_Pol.SelectedIndex + 1);//+1, тк в базе 1 - мужской, 2 женский
            client.Vozrast = Convert.ToByte(nud_Vozrast.Value);
            client.Ves = Convert.ToInt16(nud_Ves.Value);
            client.Znak_zodiaka = tb_znak.Text.Trim();
            if(client.Familiy!="" && client.Name!="" && client.Otchestvo!="" && client.Znak_zodiaka != "")
            {
                Helper helper = new Helper();
                string answer = helper.AddClient(client);
                MessageBox.Show(answer);
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите все поля");
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
