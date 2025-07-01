using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Http;
using System.IO;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace EasyBook
{
    public partial class normalView : Form
    {
        public normalView()
        {
            InitializeComponent();
        }

        MemManagerView MemViewOpen = new MemManagerView();
        ResView ResViewOpen = new ResView();

        string connstr;          //연결
        SqlConnection conn;
        SqlCommand cmd;

        private async void normalView_Load(object sender, EventArgs e)
        {
            string imagePath;
            string title = lbl_title3.Text;

            
            connstr = "Server=localhost\\SQLEXPRESS;Database=EasyBook;Trusted_Connection=True;";          //DBMS와 연결
            conn = new SqlConnection(connstr);
            conn.Open();
            
            cmd = new SqlCommand();
            cmd.Connection = conn;
            
            cmd.CommandText = "SELECT Image FROM ResInfo WHERE Title = @title";       //Member 테이블 정보 조회
            cmd.Parameters.Clear();  // 기존 파라미터 초기화
            cmd.Parameters.AddWithValue("@title", title);
            
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                imagePath = reader["Image"].ToString();  // 'Image' 컬럼의 값을 가져옴

                if (!string.IsNullOrEmpty(imagePath))
                {
                    try
                    {
                        // URL 경로를 생성하여 이미지 로드
                        string fullImageUrl = "https://image.tmdb.org/t/p/w500" + imagePath;

                        // HttpClient를 사용하여 이미지를 다운로드
                        using (HttpClient client = new HttpClient())
                        {
                            // 이미지 다운로드
                            byte[] imageBytes = await client.GetByteArrayAsync(fullImageUrl);

                            // 다운로드한 바이트 배열을 메모리 스트림에 로드
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                // MemoryStream에서 이미지를 PictureBox에 설정
                                pbox_Poster3.Image = Image.FromStream(ms);
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
            conn.Close();  // 연결 종료
        }

        private void lbl_Join_MouseEnter(object sender, EventArgs e)
        {
            lbl_Join.BackColor = Color.Black;
            lbl_Join.ForeColor = Color.White;                   //폰트색상은 ForeColor로 변경
            lbl_Join.Font = new Font("Malgun Gothic", 12, FontStyle.Bold);

        }

        private void lbl_Join_MouseLeave(object sender, EventArgs e)
        {
            lbl_Join.BackColor = Color.White;
            lbl_Join.ForeColor = Color.Black;                   //폰트색상은 ForeColor로 변경
            lbl_Join.Font = new Font("Malgun Gothic", 10, FontStyle.Regular);


            Color activeBorderColor = SystemColors.ActiveBorder;

        }

        private void lbl_Login_MouseEnter(object sender, EventArgs e)
        {
            lbl_Login.BackColor = Color.Black;
            lbl_Login.ForeColor = Color.White;
            lbl_Login.Font = new Font("Malgun Gothic", 12, FontStyle.Bold);
        }

        private void lbl_Login_MouseLeave(object sender, EventArgs e)
        {
            lbl_Login.BackColor = Color.White;
            lbl_Login.ForeColor = Color.Black;
            lbl_Login.Font = new Font("Malgun Gothic", 10, FontStyle.Regular);
        }

        private void lbl_Login_Click(object sender, EventArgs e)
        {
            MemViewOpen.Login();
            MemViewOpen.ShowDialog();
        }

        private void lbl_Join_Click(object sender, EventArgs e)
        {
            MemViewOpen.Join();
            MemViewOpen.ShowDialog();
        }

        private void btn_Res_Click(object sender, EventArgs e)
        {
            
            ResViewOpen.Show_gboxNormal();
            ResViewOpen.ShowDialog();

        }
    }
}

