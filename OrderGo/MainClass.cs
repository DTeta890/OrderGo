using System.Windows.Forms;

namespace OrderGo
{
    class MainClass
    {
        public static void sno(DataGridView gv, string snoGV)
        {
            int count = 0;
            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[snoGV].Value = count;
            }
        }
        public static void showWindow(Form openWin, Form closeWin, Form MDI)
        {
            closeWin.Close();
            openWin.WindowState = FormWindowState.Maximized;
            openWin.MdiParent = MDI;
            openWin.Show();
        }
        public static void showWindow(Form openWin, Form MDI)
        {
            openWin.WindowState = FormWindowState.Maximized;
            openWin.MdiParent = MDI;
            openWin.Show();
        }
        public static void showMessage(string msg, string type)
        {
            if (type == "success")
                MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (type == "error")
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void resetEnable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Clear();
                    tb.Enabled = true;
                }
                else if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.SelectedIndex = -1;
                    cb.Enabled = true;
                }
                else if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Checked = false;
                    rb.Enabled = true;
                }
                else if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Checked = false;
                    cb.Enabled = true;
                }
                else if (c is NumericUpDown)
                {
                    NumericUpDown ud = (NumericUpDown)c;
                    ud.Text = "0";
                    ud.Enabled = true;
                }
                else if (c is Button)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                }
            }
        }
        public static void resetDisable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Clear();
                    tb.Enabled = false;
                }
                else if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.SelectedIndex = -1;
                    cb.Enabled = false;
                }
                else if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Checked = false;
                    rb.Enabled = false;
                }
                else if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Checked = false;
                    cb.Enabled = false;
                }
                else if (c is NumericUpDown)
                {
                    NumericUpDown ud = (NumericUpDown)c;
                    ud.Text = "0";
                    ud.Enabled = false;
                }
                else if (c is Button)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
        }
        public static void EnableControls(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = true;
                }
                else if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                }
                else if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                }
                else if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                }
                else if (c is NumericUpDown)
                {
                    NumericUpDown ud = (NumericUpDown)c;
                    ud.Enabled = true;
                }
                else if (c is Button)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                }
            }
        }
        public static void DisableControls(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = false;
                }
                else if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                }
                else if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                }
                else if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;
                }
                else if (c is NumericUpDown)
                {
                    NumericUpDown ud = (NumericUpDown)c;
                    ud.Enabled = false;
                }
                else if (c is Button)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
        }
    }
}
