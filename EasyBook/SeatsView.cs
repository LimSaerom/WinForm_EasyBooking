using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EasyBook
{
    public partial class SeatsView : Form
    {
        private int maxSeats;  // 최대 선택 가능한 좌석 수
        private int selectedSeats = 0;  // 선택된 좌석 수

        // ResView에서 전달된 num_cEA, num_ecEA 값을 받아서 설정
        public SeatsView(int seatCount)
        {
            InitializeComponent();

            maxSeats = seatCount;        //최대 4명 제한
        }

        // 폼 로드 시 초기화
        private void SeatsView_Load(object sender, EventArgs e)
        {

            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            // 랜덤 객체 생성
            Random random = new Random();

            // 폼이 화면 안에 나타날 수 있도록 랜덤 위치 계산
            int randomX = random.Next(0, screenWidth - this.Width);
            int randomY = random.Next(0, screenHeight - this.Height);

            // 폼의 위치를 랜덤 값으로 설정
            this.Location = new Point(randomX, randomY);

            // seatsToSelect로 선택 가능한 좌석 수가 결정됨
            selectedSeats = 0;
            lbl_info.Text = "선택 인원수 : " + selectedSeats.ToString() + "명\n결제 금액 : " + (5000 * selectedSeats) + "원";
        }

        // 좌석 선택 클릭 이벤트
        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            // 이미 선택된 좌석은 클릭 불가능
            if (clickedButton.BackColor == Color.Red)
            {
                MessageBox.Show("이미 선택된 좌석입니다.");
                return;
            }

            // 좌석 수가 선택할 수 있는 수를 초과하면 선택 불가
            if (selectedSeats >= maxSeats)
            {
                MessageBox.Show("선택 가능한 좌석 수를 초과했습니다.");
                return;
            }

            clickedButton.BackColor = Color.Red;
            selectedSeats++;

            lbl_info.Text = "선택 인원수 : " + selectedSeats.ToString() + "명\n결제 금액 : " + (5000 * selectedSeats) + "원";

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

            selectedSeats = 0;

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Button button)
                {
                    // 선택된 좌석을 원래 색상으로 되돌리기
                    button.BackColor = Color.WhiteSmoke; // 기본 배경색으로 되돌리기
                }
                lbl_info.Text = "선택 인원수 : " + selectedSeats.ToString() + "명\n결제 금액 : " + (5000 * selectedSeats) + "원";
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            // 선택된 좌석 수와 실제 클릭된 좌석 수 비교
            if (selectedSeats != maxSeats)
            {
                MessageBox.Show("예매 인원수와 선택 좌석의 수량이 맞지 않습니다.");
                return; // 잘못된 경우는 함수 종료
            }

            // 선택된 좌석 수와 클릭된 좌석 수가 일치하면 다음 동작을 진행
            MessageBox.Show("예매가 완료되었습니다! \n\n\n예매 정보는 개인정보에서 확인 하실 수 있습니다.");
        }
    }
}
