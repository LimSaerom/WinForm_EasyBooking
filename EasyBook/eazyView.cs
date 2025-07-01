using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.IO;


namespace EasyBook
{
    public partial class eazyView : Form
    {
        eazyMemmanagerView eazyMemmanagerOpen = new eazyMemmanagerView();
        ResView ResViewOpen = new ResView();
        Main mainOepn = new Main();

        //private List<Movie> movieList = new List<Movie>();  // 영화 목록을 저장할 리스트
        private int currentMovieIndex = 0;  // 현재 표시 중인 영화의 인덱스

        
        string connstr;          //연결
        SqlConnection conn;
        SqlCommand cmd;

        public eazyView()
        {
            InitializeComponent();
        }



        private async void eazyView_Load(object sender, EventArgs e)
        {
            mainOepn.ttsplay("큰 화면 예매 진행을 시작합니다. 음성 도움이 필요하시면 상단에 위치한 음성안내 버튼을 눌러주세요.");

            connstr = "Server=localhost\\SQLEXPRESS;Database=EasyBook;Trusted_Connection=True;";          //DBMS와 연결
            conn = new SqlConnection(connstr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;


            cmd.CommandText = "SELECT Title FROM ResInfo";
            SqlDataReader reader = cmd.ExecuteReader();

            cb_search.Items.Clear();

            while (reader.Read())
            {
                // 각 Title을 콤보박스에 추가
                cb_search.Items.Add(reader["Title"].ToString());
            }
            
            reader.Close();  // 리더 종료

        }


        private void lbl_Join_MouseEnter(object sender, EventArgs e)
        {
            lbl_Join.BackColor = Color.OrangeRed;
            lbl_Join.ForeColor = Color.White;                   //폰트색상은 ForeColor로 변경
            lbl_Join.Font = new Font("Malgun Gothic", 30, FontStyle.Bold);
        }

        private void lbl_Join_MouseLeave(object sender, EventArgs e)
        {
            lbl_Join.BackColor = Color.White;
            lbl_Join.ForeColor = Color.Black;                   //폰트색상은 ForeColor로 변경
            lbl_Join.Font = new Font("Malgun Gothic", 20, FontStyle.Bold);


            Color activeBorderColor = SystemColors.ActiveBorder;
        }

        private void lbl_Login_MouseEnter(object sender, EventArgs e)
        {
            lbl_Login.BackColor = Color.OrangeRed;
            lbl_Login.ForeColor = Color.White;                   //폰트색상은 ForeColor로 변경
            lbl_Login.Font = new Font("Malgun Gothic", 30, FontStyle.Bold);
        }

        private void lbl_Login_MouseLeave(object sender, EventArgs e)
        {
            lbl_Login.BackColor = Color.White;
            lbl_Login.ForeColor = Color.Black;                   //폰트색상은 ForeColor로 변경
            lbl_Login.Font = new Font("Malgun Gothic", 20, FontStyle.Bold);


            Color activeBorderColor = SystemColors.ActiveBorder;
        }

        private void btn_Res_MouseEnter(object sender, EventArgs e)
        {
            btn_Res.BackColor = Color.Green;
            btn_Res.ForeColor = Color.White;                   //폰트색상은 ForeColor로 변경
            btn_Res.Font = new Font("Malgun Gothic", 40, FontStyle.Bold);
        }

        private void btn_Res_MouseLeave(object sender, EventArgs e)
        {
            btn_Res.BackColor = Color.White;
            btn_Res.ForeColor = Color.Black;                   //폰트색상은 ForeColor로 변경
            btn_Res.Font = new Font("Malgun Gothic", 30, FontStyle.Bold);


            Color activeBorderColor = SystemColors.ActiveBorder;
        }

        private void btn_Res_Click(object sender, EventArgs e)
        {
            
            ResViewOpen.Show_gboxEazy();
            ResViewOpen.ShowDialog();
            
        }

        private void lbl_Join_Click(object sender, EventArgs e)
        {
            eazyMemmanagerOpen.JoinEazy();
            eazyMemmanagerOpen.ShowDialog();
        }

        private void lbl_Login_Click(object sender, EventArgs e)
        {
            eazyMemmanagerOpen.LoginEazy();
            eazyMemmanagerOpen.ShowDialog();
        }

        private void cbox_tts_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_tts.Checked)
            {
                mainOepn.ttsplay("영화,뮤지컬 등 대분류를 선택하시면 예매 가능한 상품이 표기됩니다.");
                mainOepn.ttsplay("좌측에는 상품의 이미지가 표시됩니다. 우측에는 상품정보가 표시됩니다.");
                mainOepn.ttsplay("제목으로 상품을 검색할 수 있습니다. 혹은 목록보기를 통해 현재 상영중인 영화 목록을 확인 하실 수 있습니다.");
                mainOepn.ttsplay("상품정보를 확인하신 후 하단 예매하기를 선택하시면 예매창으로 넘어갑니다.");
            }
            else
            {
                mainOepn.ttsplay("");
            }

        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;  // 클릭된 버튼을 확인

            if (clickedButton != null)
            {
                // 왼쪽 버튼이 클릭된 경우
                if (clickedButton.Name == "btn_left")
                {
                    if (cb_search.SelectedIndex > 0)
                    {
                        // 왼쪽 버튼 클릭: SelectedIndex를 1 감소시켜 이전 아이템으로 이동
                        cb_search.SelectedIndex--;
                    }
                    else
                    {
                        // 맨 처음에 있을 경우, 마지막 항목으로 이동
                        cb_search.SelectedIndex = cb_search.Items.Count - 1;
                    }
                }
                // 오른쪽 버튼이 클릭된 경우
                else if (clickedButton.Name == "btn_right")
                {
                    if (cb_search.SelectedIndex < cb_search.Items.Count - 1)
                    {
                        // 오른쪽 버튼 클릭: SelectedIndex를 1 증가시켜 다음 아이템으로 이동
                        cb_search.SelectedIndex++;
                    }
                    else
                    {
                        // 맨 마지막에 있을 경우, 첫 번째 항목으로 이동
                        cb_search.SelectedIndex = 0;
                    }
                }
            }

            cb_search_SelectionChangeCommitted(sender, e);
        }

        private void btn_left_MouseEnter(object sender, EventArgs e)
        {
            btn_left.ForeColor = Color.Red;                   //폰트색상은 ForeColor로 변경
        }

        private void btn_left_MouseLeave(object sender, EventArgs e)
        {
            btn_left.ForeColor = Color.Black;                   //폰트색상은 ForeColor로 변경
        }

        private void btn_right_MouseEnter(object sender, EventArgs e)
        {
            btn_right.ForeColor = Color.Red;                   //폰트색상은 ForeColor로 변경
        }

        private void btn_right_MouseLeave(object sender, EventArgs e)
        {
            btn_right.ForeColor = Color.Black;                   //폰트색상은 ForeColor로 변경
        }

        private void tb_search_Click(object sender, EventArgs e)
        {
            tb_search.Clear();
            tb_search.ForeColor = Color.Black;
        }

        private async void btn_search_Click(object sender, EventArgs e)
        {

            string imagePath;
            string title = tb_search.Text;
            string StartDate;


            cmd.CommandText = "SELECT Title,Image, StartDate, Overview, Director FROM ResInfo WHERE Title = @title";
            cmd.Parameters.Clear();  // 기존 파라미터 초기화
            cmd.Parameters.AddWithValue("@title", title);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                imagePath = reader["Image"].ToString();  // 'Image' 컬럼의 값을 가져옴
                
                lbl_Title.Text = reader["Title"].ToString();                  // 제목을 레이블에 출력 
                lbl_StartDate.Text = Convert.ToDateTime(reader["StartDate"]).ToString("yyyy-MM-dd");     // 개봉일을 레이블에 출력
                lbl_Overview.Text = reader["Overview"].ToString();
                lbl_Director.Text = reader["Director"].ToString();


                if (!string.IsNullOrEmpty(imagePath))
                {
                    try
                    {
                        string fullImageUrl = "https://image.tmdb.org/t/p/w500" + imagePath;

                        using (HttpClient client = new HttpClient())
                        {
                            byte[] imageBytes = await client.GetByteArrayAsync(fullImageUrl);

                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                pbox_Poster.Image = Image.FromStream(ms);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("이미지 로드 실패: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("이미지가 존재하지 않습니다.");
                }
            }
            else
            {
                MessageBox.Show("해당 제목의 정보가 없습니다.");
            }
            
            reader.Close();  // 리더 종료

        }

        private async void cb_search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string imagePath;
            string title = cb_search.SelectedItem.ToString();
            string StartDate;

            cmd.CommandText = "SELECT Title,Image, StartDate, Overview, Director FROM ResInfo WHERE Title = @title";
            cmd.Parameters.Clear();  // 기존 파라미터 초기화
            cmd.Parameters.AddWithValue("@title", title);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                imagePath = reader["Image"].ToString();  // 'Image' 컬럼의 값을 가져옴

                lbl_Title.Text = reader["Title"].ToString();                  // 제목을 레이블에 출력 
                lbl_StartDate.Text = Convert.ToDateTime(reader["StartDate"]).ToString("yyyy-MM-dd");     // 개봉일을 레이블에 출력
                lbl_Overview.Text = reader["Overview"].ToString();
                lbl_Director.Text = reader["Director"].ToString();


                if (!string.IsNullOrEmpty(imagePath))
                {
                    try
                    {
                        string fullImageUrl = "https://image.tmdb.org/t/p/w500" + imagePath;

                        using (HttpClient client = new HttpClient())
                        {
                            byte[] imageBytes = await client.GetByteArrayAsync(fullImageUrl);

                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                pbox_Poster.Image = Image.FromStream(ms);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("이미지 로드 실패: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("이미지가 존재하지 않습니다.");
                }
            }
            else
            {
                MessageBox.Show("해당 제목의 정보가 없습니다.");
            }

            reader.Close();  // 리더 종료
        }

        private void eazyView_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();  // 연결 종료
        }
    }   

}
