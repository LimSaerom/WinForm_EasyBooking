using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBook
{
    public partial class ResView : Form
    {
        public ResView()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.Enabled = false;
            gboxN.Enabled = false;

            lbl_cLoc.Text = "-";
            lbl_ecLoc.Text = "-";

            lbl_cDate.Text = "-";
            lbl_ecDate.Text = "-";

            lbl_cTime.Text = "-";
            lbl_ecTime.Text = "-";

            
            
        }

        public void Show_gboxNormal()
        {
            gbox_Normal.Visible = true;
            gbox_eazy.Visible = false;
        }

        public void Show_gboxEazy()
        {
            gbox_Normal.Visible = false;
            gbox_eazy.Visible = true;
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView[] treeview = {treeView1, treeView2};

            foreach (TreeView tr in treeview)
            {
                if(tr.Name == "treeView1")                 //일반 예매창
                {
                    if (e.Node.Parent != null)
                    {
                        monthCalendar1.Enabled = true;
                        lbl_cLoc.Text = e.Node.Text;
                    }
                    else
                    {
                        // 다른 노드는 달력 비활성화
                        monthCalendar1.Enabled = false;
                    }
                }

                if (tr.Name == "treeView2")                //쉬운 예매창
                {
                    if (e.Node.Parent != null)
                    {
                        monthCalendar2.Enabled = true;
                        lbl_ecLoc.Text = e.Node.Text;
                    }
                    else
                    {
                        // 다른 노드는 달력 비활성화
                        monthCalendar2.Enabled = false;
                    }
                }
            }
        }

        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            MonthCalendar[] monthCalendars = { monthCalendar1, monthCalendar2 };

            foreach(MonthCalendar Calendar in monthCalendars)
            {
                if(Calendar.Name == "monthCalendar1")
                {
                    if (monthCalendar1.SelectionStart != null)
                    {
                        gboxN.Enabled = true;
                        lbl_cDate.Text = monthCalendar1.SelectionStart.ToShortDateString();
                        //ToString() 사용하면 시간까지 출력됨 -> 해결방법 //ToString("yyyy-mm-dd")
                    }
                }

                if (Calendar.Name == "monthCalendar2")
                {
                    if (monthCalendar2.SelectionStart != null)
                    {
                        gboxE.Enabled = true;
                        lbl_ecDate.Text = monthCalendar2.SelectionStart.ToShortDateString();
                    }
                }
            }
        }


        private void CheckBoxN_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cbox = sender as CheckBox;

            if (cbox != null && cbox.Checked)
            {
                lbl_cTime.Text = cbox.Text;  // 체크된 라디오 버튼의 텍스트를 lbl_cTime에 표시
            }
            else
            {
                lbl_cTime.Text = "-";
            }

            // 그룹박스 비활성화 처리
            if (cBox1.Checked || cBox2.Checked || cBox3.Checked)
            {
                gbox_2D.Enabled = false;
                DisableOtherCheckBoxes(cbox, cBox1, cBox2, cBox3);
            }
            else
            {
                gbox_2D.Enabled = true;
                EnableAllCheckBoxes(cBox1, cBox2, cBox3);
            }

            // gbox_4D 관련 처리
            if (cBox4.Checked || cBox5.Checked || cBox6.Checked)
            {
                gbox_4D.Enabled = false;
                DisableOtherCheckBoxes(cbox, cBox4, cBox5, cBox6);
            }
            else
            {
                gbox_4D.Enabled = true;
                EnableAllCheckBoxes(cBox4, cBox5, cBox6);
            }
        }

        private void CheckBoxE_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cbox = sender as CheckBox;

            if (cbox != null && cbox.Checked)
            {
                lbl_ecTime.Text = cbox.Text;  // 체크된 라디오 버튼의 텍스트를 lbl_cTime에 표시
            }
            else
            {
                lbl_ecTime.Text = "-";
            }

            // 그룹박스 비활성화 처리
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                gbox_e2D.Enabled = false;
                DisableOtherCheckBoxes(cbox, checkBox1, checkBox2, checkBox3);
            }
            else
            {
                gbox_e2D.Enabled = true;
                EnableAllCheckBoxes(checkBox1, checkBox2, checkBox3);
            }

            // gbox_4D 관련 처리
            if (checkBox4.Checked || checkBox5.Checked || checkBox6.Checked)
            {
                gbox_e4D.Enabled = false;
                DisableOtherCheckBoxes(cbox, checkBox4, checkBox5, checkBox6);
            }
            else
            {
                gbox_e4D.Enabled = true;
                EnableAllCheckBoxes(checkBox4, checkBox5, checkBox6);
            }
        }

        // 선택된 체크박스를 제외한 다른 체크박스를 비활성화
        private void DisableOtherCheckBoxes(CheckBox selectedCheckBox, params CheckBox[] checkBoxes)
        {
            foreach (var checkBox in checkBoxes)
            {
                if (checkBox != selectedCheckBox)
                {
                    checkBox.Enabled = false;
                }
            }
        }

        // 모든 체크박스를 활성화
        private void EnableAllCheckBoxes(params CheckBox[] checkBoxes)
        {
            foreach (var checkBox in checkBoxes)
            {
                checkBox.Enabled = true;
            }
        }

        private void Btn_cSeat_Click(object sender, EventArgs e)
        {
            if (lbl_cLoc.Text == "-" || lbl_cDate.Text == "-" || lbl_cTime.Text == "-" || num_cEA.Value == 0)
            {
                MessageBox.Show("미선택된 항목이 있습니다.");
                return;
            }

            int seatCount = (int)num_cEA.Value;

            //선택 좌석의 수량의 값을 매개변수로 받음
            SeatsView seatsView = new SeatsView(seatCount);
            seatsView.ShowDialog();

        }

        private void Btn_ecSeat_Click(object sender, EventArgs e)
        {
            if (lbl_ecLoc.Text == "-" || lbl_ecDate.Text == "-" || lbl_ecTime.Text == "-" || num_ecEA.Value == 0)
            {
                MessageBox.Show("미선택된 항목이 있습니다.");
                return;
            }

            int seatCount = (int)num_ecEA.Value;
            SeatsView seatsView = new SeatsView(seatCount);
            seatsView.ShowDialog();
        }

        private void num_ecEA_ValueChanged(object sender, EventArgs e)
        {

            NumericUpDown[] numUpDown = { num_cEA, num_ecEA };

            foreach(NumericUpDown num in numUpDown)
            {
                if(num.Value > 4)
                {
                    MessageBox.Show("최대 4매까지만 선택 가능합니다.");
                    num.Value = 4;
                }
            }
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
