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
    public partial class UpdateForm : Form
    {
        private int id_clienta;
        public UpdateForm(Client client)
        {
            InitializeComponent();
            cb_Pol.Items.Add("Мужской");
            cb_Pol.Items.Add("Женский");
            id_clienta = client.ID_clienta;
            tb_Familiya.Text = client.Familiy;
            tb_Name.Text = client.Name;
            tb_Otchestvo.Text = client.Otchestvo;
            cb_Pol.SelectedIndex = client.ID_Pol - 1;
            nud_Vozrast.Value = client.Vozrast;
            nud_Ves.Value = client.Ves;
            tb_znak.Text = client.Znak_zodiaka;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string Familiy = tb_Familiya.Text.Replace(" ", "");
            string Name = tb_Name.Text.Replace(" ", "");
            string Otchestvo = tb_Otchestvo.Text.Replace(" ", "");
            Byte ID_Pol = Convert.ToByte(cb_Pol.SelectedIndex + 1);//+1, тк в базе 1 - мужской, 2 женский
            Byte Vozrast = Convert.ToByte(nud_Vozrast.Value);
            Int16 Ves = Convert.ToInt16(nud_Ves.Value);
            string Znak_zodiaka = tb_znak.Text.Trim();
            if (Familiy != "" && Name != "" && Otchestvo != "" && Znak_zodiaka != "")
            {
                Helper helper = new Helper();
                string answer = helper.UpdateClient(id_clienta,Familiy,Name,Otchestvo,ID_Pol,Vozrast,Ves,Znak_zodiaka);
                MessageBox.Show(answer);
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите все поля");
            }
        }
    }
}
