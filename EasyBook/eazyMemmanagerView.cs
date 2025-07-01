using Microsoft.SqlServer.Server;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace EasyBook
{
    public partial class eazyMemmanagerView : Form
    {

        public eazyMemmanagerView()
        {
            InitializeComponent();
        }

        
        string connstr;          //연결
        SqlConnection conn;
        SqlCommand cmd;
        

        private void eazyMemmanagerView_Load(object sender, EventArgs e)
        {
            connstr = "Server=localhost\\SQLEXPRESS;Database=EasyBook;Trusted_Connection=True;";          //DBMS와 연결
            conn = new SqlConnection(connstr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

        }

        public void resetForm()
        {
            GroupBox gbox = new GroupBox();
            Label lbl = new Label();
            Button btn = new Button();
            TextBox tb = new TextBox();
            MaskedTextBox mtb = new MaskedTextBox();

            gbox.Visible = true;
            lbl.Visible = true;
            btn.Visible = true;
            tb.Visible = true;
            mtb.Visible = true;

            /* 
            gbox_manager.Text = "로그인";    //그룹박스 text명
            btn_Login.Visible = true;       //로그인 - 로그인 버튼
            btn_join.Visible = true;        //로그인 - 회원가입 이동 버튼
            btn_Nmem.Visible = true;        //로그인 - 비회원예매 이동 버튼
            gbox_ex.Visible = true;         //회원가입 - 입력예시
            btn_Insert.Visible = true;      //회원가입 - 회원정보 db 전송 버튼
            btn_idCheck.Visible = true;     //회원가입 - 회원정보 db 확인 버튼
            btn_nonInsert.Visible = true;   //비회원예매 - 비회원정보 db 전송 버튼
            */

            Size = new Size(1200, 700);
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            
            gbox_manager.Size = new Size(600, 600);
            gbox_manager.Location = new Point(12,12);

            lbl_id.Location = new Point(5, 60);
            tb_id.Location = new Point(lbl_id.Location.X + 200, lbl_id.Location.Y);

            lbl_pw.Location = new Point(5, 120);
            tb_pw.Location = new Point(lbl_pw.Location.X + 200, lbl_pw.Location.Y);

            lbl_pw2.Location = new Point(5, 180);
            tb_pw2.Location = new Point(lbl_pw2.Location.X + 200, lbl_pw2.Location.Y);

            lbl_name.Location = new Point(5,240);
            tb_name.Location = new Point(lbl_name.Location.X + 200, lbl_name.Location.Y);

            lbl_resident.Location = new Point(5,300);
            mtb_resident.Location = new Point(lbl_resident.Location.X + 200, lbl_resident.Location.Y);
            mtb_resident.Mask = "000000-0000000";
            mtb_resident.ValidatingType = typeof(int);  // 숫자만 입력받도록 설정(타입이 다르면 입력 자체가 안됨)


            lbl_hp.Location = new Point(5,360);
            mtb_hp.Location = new Point(lbl_hp.Location.X + 200, lbl_hp.Location.Y);
            mtb_hp.Mask = "000-0000-0000";
            mtb_hp.ValidatingType = typeof(int);


            lbl_addr.Location = new Point(5,420);
            tb_addr.Location = new Point(lbl_addr.Location.X + 200, lbl_addr.Location.Y);

            lbl_mail.Location = new Point(5,480);
            tb_mail.Location = new Point(lbl_mail.Location.X + 200, lbl_mail.Location.Y);

            btn_Login.Location = new Point(420, 590);
            btn_join.Location = new Point(570, 530);
            btn_Insert.Location = new Point(570, 580);
            btn_idCheck.Location = new Point(570, 630);
            btn_nonInsert.Location = new Point(730, 530);
            btn_Nmem.Location = new Point(730, 630);

        }

        public void LoginEazy()
        {
            resetForm();

            btn_Login.Visible = true;       //로그인 - 로그인 버튼
            btn_join.Visible = true;        //로그인 - 회원가입 이동 버튼
            btn_Nmem.Visible = true;        //로그인 - 비회원예매 이동 버튼

            gbox_manager.Text = "로그인";         //회원가입 - 입력예시
            gbox_ex.Visible = false;         //회원가입 - 입력예시
            btn_Insert.Visible = false;      //회원가입 - 회원정보 db 전송 버튼
            btn_idCheck.Visible = false;     //회원가입 - 회원정보 db 확인 버튼
            btn_nonInsert.Visible = false;   //비회원예매 - 비회원정보 db 전송 버튼

            lbl_pw2.Visible = false;
            tb_pw2.Visible = false;
            lbl_name.Visible = false;
            tb_name.Visible = false;
            lbl_resident.Visible = false;
            mtb_resident.Visible = false;


            //초기_로그인시 설정값
            this.Size = new Size(650, 360);             //폼 사이즈
            this.MaximumSize = new Size(650, 360);             //최대사이즈 고정
            this.MinimumSize = new Size(650, 360);             //최소사이즈 고정
            
            gbox_manager.Size = new Size(610, 260);
            btn_Login.Location = new Point(450, 60);
            btn_join.Location = new Point(btn_Login.Location.X - 160, btn_Login.Location.Y + 130);
            btn_Nmem.Location = new Point(btn_Login.Location.X, btn_Login.Location.Y + 130);

        }

        public void JoinEazy()
        {
            resetForm();

            Size = new Size(1200, 700);
            this.MinimumSize = new Size(1200, 700);
            this.MaximumSize = new Size(1200, 700);

            btn_Login.Visible = false;       //로그인 - 로그인 버튼
            btn_join.Visible = false;        //로그인 - 회원가입 이동 버튼
            btn_Nmem.Visible = false;        //로그인 - 비회원예매 이동 버튼
            btn_nonInsert.Visible = false;   //비회원예매 - 비회원정보 db 전송 버튼


            gbox_manager.Text = "회원가입";         //회원가입 - 입력예시
            lbl_id.Text = "아이디";
            lbl_pw.Text = "비밀번호";
            gbox_ex.Visible = true;         //회원가입 - 입력예시
            btn_Insert.Visible = true;      //회원가입 - 회원정보 db 전송 버튼
            btn_idCheck.Visible = true;     //회원가입 - 회원정보 db 확인 버튼
            

            lbl_pw2.Visible = true;
            tb_pw2.Visible = true;
            lbl_name.Visible = true;
            tb_name.Visible = true;
            lbl_resident.Visible = true;
            mtb_resident.Visible = true;

            btn_idCheck.Location = new Point(440, 60);
            btn_Insert.Location = new Point(200, 550);

        }

        public void NonmemEazy()
        {
            resetForm();

            this.Size = new Size(650, 360);             //폼 사이즈
            this.MaximumSize = new Size(650, 360);             //최대사이즈 고정
            this.MinimumSize = new Size(650, 360);             //최소사이즈 고정
            gbox_manager.Size = new Size(610, 260);


            gbox_manager.Text = "비회원 정보입력";    //그룹박스 text명
            btn_Login.Visible = false;       //로그인 - 로그인 버튼
            btn_join.Visible = true;        //로그인 - 회원가입 이동 버튼
            btn_Nmem.Visible = false;        //로그인 - 비회원예매 이동 버튼
            gbox_ex.Visible = false;         //회원가입 - 입력예시
            btn_Insert.Visible = false;      //회원가입 - 회원정보 db 전송 버튼
            btn_idCheck.Visible = false;     //회원가입 - 회원정보 db 확인 버튼
            btn_nonInsert.Visible = true;   //비회원예매 - 비회원정보 db 전송 버튼

            btn_nonInsert.Location = new Point(450, 60);
            btn_join.Location = new Point(450, 180);

            lbl_id.Text = "비회원 이름";
            lbl_pw.Text = "주문 비밀번호";

            lbl_hp.Location = new Point(lbl_pw.Location.X, lbl_pw.Location.Y + 60);
            mtb_hp.Location = new Point(tb_pw.Location.X, tb_pw.Location.Y + 60);
            mtb_hp.Mask = "000-0000-0000";
            mtb_hp.ValidatingType = typeof(int);

        }

        private void btn_join_Click(object sender, EventArgs e)
        {
            btn_join.Visible = false;
            btn_nonInsert.Visible = false;
            JoinEazy();

        }

        private void btn_idCheck_Click(object sender, EventArgs e)
        {
            //DB와 프로그램 ID 중복 체크
            string inputID = tb_id.Text;

            cmd.CommandText = "SELECT COUNT(*) FROM Member WHERE UserID = @id";       //Member 테이블 정보 조회


            cmd.Parameters.Clear();  // 기존 파라미터 초기화
            cmd.Parameters.AddWithValue("@id", inputID);


            int count = (int)cmd.ExecuteScalar();

            if (count > 0)  // 중복된 아이디가 있으면
            {
                MessageBox.Show("이미 사용중인 아이디 입니다.");
            }
            else  // 중복된 아이디가 없으면
            {
                MessageBox.Show("사용 가능한 아이디 입니다.");
            }
            
        }

        private void btn_Nmem_Click(object sender, EventArgs e)
        {
            btn_Nmem.Visible = false;
            btn_join.Visible = false;
            NonmemEazy();

        }

        private void btn_nonInsert_Click(object sender, EventArgs e)          //비회원 예매하기 버튼을 눌렀을때 DB에 정보 전송
        {
            string sql;

            //비회원ID 8자리 랜덤 생성
            string NMID = CheckNMID();                             //메서드 이용해서 중복 방지
            string hpNo = mtb_hp.Text.Replace("-", "");           // "-" 제거

            TextBox[] textBoxes = { tb_id, tb_pw };

            foreach (TextBox tb in textBoxes)
            {
                if (tb.Text == string.Empty)  // 빈 문자열이나 공백일 경우
                {
                    MessageBox.Show("누락된 정보가 있습니다.", "재확인", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;  // 빈 필드가 있으면 더 이상 진행하지 않음
                }
            }

            MaskedTextBox[] maskedTextBoxes = { mtb_hp };

            foreach (MaskedTextBox mtb in maskedTextBoxes)
            {
                if (mtb.Text == string.Empty)  // 빈 문자열이나 공백일 경우
                {
                    MessageBox.Show("누락된 정보가 있습니다.", "재확인", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;  // 빈 필드가 있으면 더 이상 진행하지 않음
                }
            }


            sql = "INSERT INTO NonMember (NMID,NMName,NMPW,NMContact) " + "VALUES (@id, @name, @password, @phone)";

            cmd.CommandText = sql;
            cmd.Parameters.Clear();  // 기존 파라미터를 지운다.
            cmd.Parameters.AddWithValue("@id", NMID);
            cmd.Parameters.AddWithValue("@name", tb_id.Text);              //회원 ID tb를 그대로 이름만 바꿔서 사용
            cmd.Parameters.AddWithValue("@password", tb_pw.Text);
            cmd.Parameters.AddWithValue("@phone", hpNo);

            cmd.ExecuteNonQuery();
            MessageBox.Show("비회원 예매 정보 저장 완료.", "비회원 예매 진행", MessageBoxButtons.OK, MessageBoxIcon.Information);

            foreach (TextBox tb in textBoxes)
            {
                tb.Text = string.Empty;
            }
            foreach (MaskedTextBox mtb in maskedTextBoxes)
            {
                mtb.Text = string.Empty;
            }
        }
        private string CheckNMID()            //비회원 ID 중복방지를 위해 DB조회 → 중복없을때까지 난수 생성하는 로직
        {
                
            string NMID;
            int count;
            Random rand = new Random();

            do
            {
                // 8자리 랜덤 숫자 생성
                NMID = rand.Next(10000000, 100000000).ToString();

                // DB에서 해당 NMID가 이미 존재하는지 확인
                cmd.CommandText = "SELECT COUNT(*) FROM NonMember WHERE NMID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", NMID);

                count = (int)cmd.ExecuteScalar();  // 해당 ID가 DB에 존재하면 count가 1 이상

            } while (count > 0);  // 중복된 NMID가 있을 경우 반복해서 새로운 ID 생성

            return NMID;
        }


        public void btn_Insert_Click(object sender, EventArgs e)          //회원가입 버튼을 눌렀을때 DB에 정보 전송
        {
            //DB에 새로운 정보 입력
            string sql;

            //DB에 입력값만을 전송하기 위해 형식 제거
            string resNo = mtb_resident.Text.Replace("-", "");    // "-" 제거
            string hpNo = mtb_hp.Text.Replace("-", "");           // "-" 제거


            if (tb_pw.Text != tb_pw2.Text)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다. 다시 입력해주세요.", "중복 확인", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;      //불일치시 회원가입 불가
            }

            //정보 기재누락일 시 회원가입 불가
            TextBox[] textBoxes = { tb_id, tb_pw, tb_pw2, tb_name, tb_addr, tb_mail };

            foreach (TextBox tb in textBoxes)
            {
                if (tb.Text == string.Empty)  // 빈 문자열이나 공백일 경우
                {
                    MessageBox.Show("누락된 정보가 있습니다.", "재확인", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;  // 빈 필드가 있으면 더 이상 진행하지 않음
                }
            }


            MaskedTextBox[] maskedTextBoxes = { mtb_resident, mtb_hp };

            foreach (MaskedTextBox mtb in maskedTextBoxes)
            {
                if (mtb.Text == string.Empty)  // 빈 문자열이나 공백일 경우
                {
                    MessageBox.Show("누락된 정보가 있습니다.", "재확인", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;  // 빈 필드가 있으면 더 이상 진행하지 않음
                }
            }



            /// <summary>
            /// DB입력
            /// 1. tbox.Text를 직접 기재하는 것 보다 파라메터를 통해 sql 데이터 입력하는게 보안상 더 안전함
            /// 2. 실제 칼럼명을 기재 2. @id 등은 파라메터 3. 하단에 파라미터 값으로 Text입력값을 추가해줌
            /// </summary>

            sql = "INSERT INTO Member (UserID,Password,Name,ResidentNO,Contact,Addr,Email,SignDate,MemStatus) " +
              "VALUES (@id, @password, @name, @resident, @phone, @address, @email, @SignDate, 'Y')";


            cmd.CommandText = sql;
            cmd.Parameters.Clear();  // 기존 파라미터를 지운다.
            cmd.Parameters.AddWithValue("@id", tb_id.Text);
            cmd.Parameters.AddWithValue("@password", tb_pw.Text);
            cmd.Parameters.AddWithValue("@name", tb_name.Text);
            cmd.Parameters.AddWithValue("@resident", resNo);                //MaskedTextBox 사용하는 값들은 변수 생성해서 직접 입력으로 변경
            cmd.Parameters.AddWithValue("@phone", hpNo);                    //MaskedTextBox 사용하는 값들은 변수 생성해서 직접 입력으로 변경
            cmd.Parameters.AddWithValue("@address", tb_addr.Text);
            cmd.Parameters.AddWithValue("@email", tb_mail.Text);
            cmd.Parameters.AddWithValue("@SignDate", DateTime.Today);          //현재 날짜를 표시해주는 키워드
            cmd.Parameters.AddWithValue("@Status", 'Y');

            cmd.ExecuteNonQuery();
            MessageBox.Show("회원가입이 완료되었습니다.", "가입 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //정보 DB로 전송 후 초기화 시킴
            TextBox[] textBoxs = { tb_id, tb_pw, tb_pw2, tb_name, tb_addr, tb_mail};
            
            foreach(TextBox tb in textBoxs)
            {
                tb.Text = string.Empty;
            }
            foreach (MaskedTextBox mtb in maskedTextBoxes)
            {
                mtb.Text = string.Empty;
            }

        }


        private void eazyMemmanagerView_FormClosing(object sender, FormClosingEventArgs e)
        {
            resetForm();
        }
    }
}

