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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
        }

        private void ClientForm_Activated(object sender, EventArgs e)
        {
            AgencyEntities db = Helper.GetContext();
            List<Client> clients = db.Client.ToList();
            dgv_Data.RowCount = clients.Count;
            dgv_Data.ColumnCount = 8;
            dgv_Data.Columns[0].HeaderCell.Value = "Номер";
            dgv_Data.Columns[1].HeaderCell.Value = "Фамилия";
            dgv_Data.Columns[2].HeaderCell.Value = "Имя";
            dgv_Data.Columns[3].HeaderCell.Value = "Отчество";
            dgv_Data.Columns[4].HeaderCell.Value = "Пол";
            dgv_Data.Columns[5].HeaderCell.Value = "Возвраст";
            dgv_Data.Columns[6].HeaderCell.Value = "Вес";
            dgv_Data.Columns[7].HeaderCell.Value = "Знак зодиака";
            for (int i = 0; i < clients.Count; i++)
            {
                dgv_Data.Rows[i].Cells[0].Value = clients[i].ID_clienta;
                dgv_Data.Rows[i].Cells[1].Value = clients[i].Familiy;
                dgv_Data.Rows[i].Cells[2].Value = clients[i].Name;
                dgv_Data.Rows[i].Cells[3].Value = clients[i].Otchestvo;
                string pol;
                if (clients[i].ID_Pol == 1)
                {
                    pol = "Мужской";
                }
                else
                {
                    pol = "Женский";
                }
                dgv_Data.Rows[i].Cells[4].Value = pol;
                dgv_Data.Rows[i].Cells[5].Value = clients[i].Vozrast;
                dgv_Data.Rows[i].Cells[6].Value = clients[i].Ves;
                dgv_Data.Rows[i].Cells[7].Value = clients[i].Znak_zodiaka;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int index = dgv_Data.CurrentRow.Index;
            int id = Convert.ToInt32(dgv_Data.Rows[index].Cells[0].Value.ToString());
            AgencyEntities db = Helper.GetContext();
            Client client = db.Client.Where(x=> x.ID_clienta == id).FirstOrDefault();
            UpdateForm form = new UpdateForm(client);
            form.Show();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int index = dgv_Data.CurrentRow.Index;
            int id = Convert.ToInt32(dgv_Data.Rows[index].Cells[0].Value.ToString());
            Helper helper = new Helper();
            if (MessageBox.Show("Вы точно хотите удалить клиента по номером " + id + "?","Предупреждение",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string answer = helper.RemoveClient(id);
                MessageBox.Show(answer);
            }
        }
    }
}
