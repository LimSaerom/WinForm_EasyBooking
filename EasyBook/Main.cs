using System;
using System.Drawing;
using System.Speech.Synthesis;                         //TTS 사용을 위한 네임스페이스
using System.Windows.Forms;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EasyBook
{
    public partial class Main : Form
    {

        public SpeechSynthesizer speech;  // SpeechSynthesizer 객체를 클래스 필드로 선언(다른 폼에서도 사용할수있게 public 선언)

        public Main()
        {
            InitializeComponent();
            InitializeTTS();  // 생성자에서 TTS 초기화
        }


        public void InitializeTTS()
        {

            speech = new SpeechSynthesizer();  // TTS 출력을 위한 인스턴스 생성
            speech.SetOutputToDefaultAudioDevice();
            speech.SelectVoice("Microsoft Heami Desktop");
        }


        public void ttsplay(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                speech.SpeakAsyncCancelAll(); // 텍스트가 빈 문자열이면 음성을 취소
            }
            else
            {
                speech.SpeakAsync(text);  // 텍스트를 비동기적으로 음성 출력
            }

        }
        private void Main_Load(object sender, EventArgs e)
        {
            pbox_Example.Visible = false;          //선택버튼만 출력하기 위함
            textBox1.Text = " ";

            ttsplay("통합예약프로그램입니다. 예매진행 방법을 선택해주세요.");
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btn_easyView_Click(object sender, EventArgs e)
        {
            eazyView eazyViewOpen = new eazyView();              //인스턴스 선언
            eazyViewOpen.ShowDialog();                           //하나의 창만 작업 가능 = 쉬운예매관련 창만 작업 가능
                                                                 //show() 사용시 여러개의 창을 동시 작업 가능   
        }

        private void btn_normalView_Click(object sender, EventArgs e)
        {
            normalView normalViewOpen = new normalView();
            normalViewOpen.ShowDialog();

        }

        private void btn_easyView_MouseEnter(object sender, EventArgs e)
        {

            string easyImage = "\\Project\\EasyBook\\EasyBook\\Resources\\EasyView_Example.png";            //프로젝트 리소스폴더에 저장해서 사용



            pbox_Example.Visible = true;
            pbox_Example.Image = Image.FromFile(easyImage);
            pbox_Example.SizeMode = PictureBoxSizeMode.Zoom;          //예시화면이기 때문에 원본의 크기가 유지되어야함(꽉찬화면은 비교가 어려움)


            //버전 설명 문구
            textBox1.Font = new Font("Malgun Gothic", 18, FontStyle.Bold);      //맑은 고딕, 18pt, 굵게
            textBox1.Text = "[큰 화면 예매 진행]은\r\n 큰 글씨와 간소화된 예매 절차,\r\n 음성안내 서비스를\r\n 지원하고 있습니다.\r\n";


            //TTS 출력을 위한 코드
            ttsplay("하단 예시를 참고해주세요. 큰 화면 예매 진행은 큰 글씨와 간소화된 예매 절차, 음성안내 서비스를 지원하고 있습니다.");

        }

        private void btn_easyView_MouseLeave(object sender, EventArgs e)
        {
            pbox_Example.Visible = false;
            textBox1.Text = " ";
            ttsplay("");
        }

        private void btn_normalView_MouseEnter(object sender, EventArgs e)
        {
            //예시용 이미지 표현
            string normalImage = "\\Project\\EasyBook\\EasyBook\\Resources\\NormalView_Example.png";               //프로젝트 리소스폴더에 저장해서 사용

            pbox_Example.Visible = true;
            pbox_Example.Image = Image.FromFile(normalImage);
            pbox_Example.SizeMode = PictureBoxSizeMode.Zoom;


            //버전 설명 문구
            textBox1.Font = new Font("Malgun Gothic", 10, FontStyle.Regular);      //맑은 고딕, 18pt, 굵게
            textBox1.Text = "\r\n\r\n[예매 진행]은\r\n 프로그램 사용이 익숙한 분들께\r\n 권고 드립니다.";

            ttsplay(" 하단 예시를 참고해주세요. 예매 진행은 프로그램 사용이 익숙한 분들께 권고 드립니다.");
        }

        private void btn_normalView_MouseLeave(object sender, EventArgs e)
        {
            pbox_Example.Visible = false;
            textBox1.Text = " ";
            ttsplay("");
        }

    }
}
