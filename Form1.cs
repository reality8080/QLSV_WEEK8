using QLSV.Interface.Service.Create;
using QLSV.Interface.Service.Delete;
using QLSV.Interface.Service.Read;
using QLSV.Interface.Service.Update;
using QLSV.Model;
using System.Threading.Tasks;

namespace QLSV
{
    public partial class Form1 : Form
    {
        private readonly IServiCreateStu _cSer;
        private readonly IServiReadStu _rSer;
        private readonly IServiDeleteStu _dSer;
        private readonly IServiUpdateStu _uSer;
        public Form1(IServiCreateStu cSer, IServiReadStu rSer, IServiDeleteStu dSer, IServiUpdateStu uSer)
        {
            InitializeComponent();
            _cSer = cSer;
            _rSer = rSer;
            _dSer = dSer;
            _uSer = uSer;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadStudents();
        }

        private async void viewBtn_Click(object sender, EventArgs e)
        {
            await LoadStudents();
            mssvTxb.Clear();
            nametXb.Clear();
            facultytxB.Clear();
            AVGTxb.Clear();
        }

        private async void AddBtn_Click(object sender, EventArgs e)
        {
            Student student = new Student(nametXb.Text, facultytxB.Text, Convert.ToDecimal(AVGTxb.Text));
            await _cSer.CreateStuAsync(student);
            await LoadStudents();
            nametXb.Clear();
            facultytxB.Clear();
            AVGTxb.Clear();
        }

        private async void UpdateBtn_Click(object sender, EventArgs e)
        {
            await _uSer.UpdateStudent(Convert.ToInt16(mssvTxb.Text), nametXb.Text, facultytxB.Text, Convert.ToDecimal(AVGTxb.Text));
            await LoadStudents();
            mssvTxb.Clear();
            nametXb.Clear();
            facultytxB.Clear();
            AVGTxb.Clear();
        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            await _dSer.DeleteById(Convert.ToInt16(mssvTxb.Text));
            await LoadStudents();
            mssvTxb.Clear();
            nametXb.Clear();
            facultytxB.Clear();
            AVGTxb.Clear();
        }

        private async Task LoadStudents()
        {
            try
            {
                var stus = await _rSer.ReadAll();
                infoDGV.DataSource = stus;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách sinh viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void infoDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = infoDGV.Rows[e.RowIndex];
                mssvTxb.Text = row.Cells["Id"].Value?.ToString();
                nametXb.Text = row.Cells["Name"].Value?.ToString();
                facultytxB.Text = row.Cells["Faculty"].Value?.ToString();
                AVGTxb.Text = row.Cells["dtb"].Value?.ToString();
            }
        }

        private void infoDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (infoDGV.SelectedRows.Count > 0)
            {
                DataGridViewRow row = infoDGV.SelectedRows[0];
                mssvTxb.Text = row.Cells["Id"].Value?.ToString();
                nametXb.Text = row.Cells["Name"].Value?.ToString();
                facultytxB.Text = row.Cells["Faculty"].Value?.ToString();
                AVGTxb.Text = row.Cells["dtb"].Value?.ToString();
            }
        }

        private void nametXb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void facultytxB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mssvTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AVGTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
