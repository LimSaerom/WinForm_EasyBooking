# 📒 [Notion Page](https://www.notion.so/EasyBooking-22973547a8828191a3a3f4b8fbfe9350)

⚙️ .Net Winform  
⚙️ C#  
⚙️ Window11  
⚙️ Visual Studio 2022  
⚙️ SQL SERVER 2014

# EasyBooking
![image.png](Notion_Image/image.png)

# 프로젝트 개요

복잡한 예매 절차에 익숙하지 않은 디지털 취약계층(노년층 등)을 위해, 절차를 최소화 하고 접근성을 높인 PC용 통합예매프로그램 제작을 목표로 하였습니다.

# 기술 스택

- `C#`
- `Window11`
- `Visual Studio 2022`
- `WinForms`
- `SQL Server 2014`

### **기술 선정 이유**

✅ C#
Winform과의 높은 호환성으로 인해 자연스럽게 C#을 사용하게 되었으며, 이전에 간단한 C# 프로젝트를 경험해본 바 있어 빠르게 개발에 착수할 수 있었습니다. 객체지향적인 구조와 명확한 문법 덕분에 로직 구성과 코드 유지보수가 수월했고, .NET 라이브러리를 활용해 다양한 기능을 비교적 쉽게 구현할 수 있었습니다

✅ WinForms

이번 프로젝트는 Windows 환경에서 실행되는 데스크탑 프로그램을 개발하는 것이 목적이었고, UI 프레임워크로는 Winform이 지정되어 있었습니다. Winform은 C# 기반으로 동작하며, 시각적인 UI 구성과 빠른 프로토타이핑이 가능해 초기 화면 구현에 효율적이었습니다. 프로젝트를 진행하면서 이벤트 기반 프로그래밍의 구조를 이해하고, 사용자 인터페이스와 로직을 연결하는 방식에 익숙해질 수 있었습니다.

✅ SQL Server
데이터 저장 및 관리를 위해 SQL Server를 도입하였습니다. C#과의 연동이 원활하고, 구조화된 데이터 관리에 적합하다는 점에서 선택하게 되었으며, 실제 프로젝트에서 테이블 설계, 쿼리 작성, 데이터 연동 등의 과정을 경험하면서 관계형 데이터베이스에 대한 이해도를 높일 수 있었습니다.

# 주요 기능

✅ 선택형 UI(초기 인터페이스 선택)

- 프로그램 실행 시, 큰화면 / 일반화면 중 선택 가능한 초기 인터페이스 제공
- 선택지에는 Button 컨트롤을 사용, 각 버튼에 음성 안내 자동 출력
- 버튼 Hover 시, 중앙에 해당 모드의 설명과 이미지 예시를 함께 표시
    
    
    ![image.png](Notion_Image/image%201.png)
    
    ![image.png](Notion_Image/image%202.png)
    

✅ 예매 가능 리스트 조회

- Tab 컨트롤을 활용해 문화상품별 조회 메뉴 제공 (현재는 영화 탭만 구현)
- 제목 검색, 리스트 선택, 또는 앞/뒤 버튼을 통한 순차 탐색 등 다양한 조회 방식 지원
- 음성 안내 기능 활성화 시, 마우스 Hover에 따라 각 UI 요소의 역할을 TTS로 안내
(취약계층을 위한 [큰 화면] 인터페이스 한정 제공 기능)
- 고대비 아이콘을 함께 적용하여 시각·청각 접근성 동시 지원
    
    
    ![image.png](Notion_Image/image.png)
    
    ![image.png](Notion_Image/image%203.png)
    
    ![검색창 사용](Notion_Image/image%204.png)
    
    검색창 사용
    
    ![콤보컨트롤 사용(DB정보 연결)](Notion_Image/image%205.png)
    
    콤보컨트롤 사용(DB정보 연결)
    
    ![좌우컨트롤로 콤보박스 인덱스 변경](Notion_Image/image%206.png)
    
    좌우컨트롤로 콤보박스 인덱스 변경
    

✅ 회원 기능(회원가입, 로그인, 비밀번호 찾기)

- 기본적인 회원가입 및 로그인 기능 구현
- 사용자 정보는 SQL Server에 저장하고, 로그인 시 정보 검증을 통해 접근 제어
- 비밀번호 찾기 기능을 통해 사용자가 입력한 정보 기반으로 비밀번호 복구 가능
- 사용자 편의성을 고려한 기본적인 유효성 검사 및 예외 처리 적용

✅ 영화 예매 기능(영화관, 날짜, 시간, 좌석 선택)

- CGV 예매 시스템 UI 구조 참고, 단계별 선택 방식 구현
- 상영관 → 날짜 → 시간 → 인원 선택 순으로 예매 진행
- 이전 단계 미선택 시, 다음 단계 UI는 비활성화 처리
- 선택한 예매 정보(상영관, 날짜, 시간 등)는 하단에 요약 표시
- '좌석 예매' 버튼 클릭 시 좌석 선택 창 팝업
    - **좌석 선택 창 위치를 랜덤화**하여 반복 클릭 등 단순 매크로 방지 처리 적용
    - 선택한 인원 수만큼 좌석 선택 가능
    - 이미 예약된 좌석 클릭 시 선택 불가 안내 팝업 출력

![image.png](Notion_Image/image%207.png)

![좌석 선택창 초기 화면](Notion_Image/image%208.png)

좌석 선택창 초기 화면

![image.png](Notion_Image/image%212.png)

![선택 인원수와 결제 금액 하단에 표기](Notion_Image/image%209.png)

선택 인원수와 결제 금액 하단에 표기

- 트러블 슈팅 (1/2)
<details>    
    🚨 문제 배경
    
    실시간 상영 영화 목록을 자동으로 불러오기 위해, TMDB의 Now Playing API(C#, RestSharp 사용)를 통해 데이터를 연동하고자 함. API 문서 및 인증키를 발급받아 테스트했으나, WinForm 환경에서 **인증 오류 및 호출 실패** 발생.
    
    💡 진행 과정 및 임시 해결방안
    
    인증키 관련 설정, 패키지 버전, 등을 점검하며 디버깅 시도했으나 지속적인 호출 실패 출력.
    일정 내 기능 구현을 위해, API 응답 데이터를 수동으로 JSON 저장 후 SQL Server에 직접 입력하여 예매 시스템 구성 완료
    
1. API 사용을 위해 패키지 설치 및 적용
        
        ```csharp
        using RestSharp;                     //영화 API 사용을 위함
        using System.Collections.Generic;          //기타 JSON 형식 API 사용을 위함
        ```
        
2. TMDB API(개인KEY아님) 호출
        
        ```csharp
        private async void eazyView_Load(object sender, EventArgs e)
        {
        	mainOepn.ttsplay("큰 화면 예매 진행을 시작합니다. 음성 도움이 필요하시면 상단에 위치한 음성안내 버튼을 눌러주세요.");
        
        /// <summary>
        /// TMDB Open API 사용을 위한 코드
        /// 
        /// </summary>
        
        	var client = new RestClient("https://api.themoviedb.org/3/movie/now_playing?language=ko&page=1&region=KR");      //API 연결
        	var request = new RestRequest("GET");
        
        	request.AddHeader("accept", "application/json");          //json 형식
        	request.AddHeader("Authorization", "Bearer b48bf00c44b8af5c9e8fa047dc9b17be");     //TMDB API(개인KEY아님)
        	
        	var response = await client.ExecuteAsync(request);
        																						.
        																						.
        																						.
        ```
        
3. JSON 데이터를 형변환하고, 영화 목록을 추출해서 각 항목에 맞게 삽입.
        
        ```csharp
         private async void eazyView_Load(object sender, EventArgs e)
                {
        																						.
        																						.
        																						.
        						
        
                    if (response.IsSuccessful)
                    {
                        // JSON 데이터를 JObject로 파싱
                        var jsonData = JObject.Parse(response.Content);
        
                        // 영화 목록 추출
                        var movieList = new List<Movie>();
                        foreach (var movie in jsonData["results"])
                        {
                            var movieData = new Movie
                            {
                                Title = movie["title"].ToString(),
                                Overview = movie["overview"].ToString(),
                                ReleaseDate = movie["release_date"].ToString(),
                                PosterImageUrl = "https://image.tmdb.org/t/p/w500" + movie["poster_path"].ToString() // 포스터 이미지 URL
                            
                            movieList.Add(movieData);
                        }
        
                        DisplayMovieInfo();
                    }
                    else
                    {
                        MessageBox.Show($"API 호출 실패! 상태 코드: {response.StatusCode}, 내용: {response.Content}");
                    }
                    
                }
        
                
                
                
                public class Movie       //API 영화정보를 받아오기 위함
            {
                public string Id { get; set; }         //영화 고유 ID = DB [ ResInfo - ResID ]와 연결
                public string Title { get; set; }      //영화 제목 = DB [ ResInfo - Title ]와 연결
                public string Overview { get; set; }   //영화 소개 = DB 연결 안함
                public string ReleaseDate { get; set; } //영화 개봉일 = DB [ ResInfo - StartDate ]와 연결
                public string PosterImageUrl { get; set; } //영화 포스터 = DB [ ResInfo - Image ]와 연결
            }
        
            public class MovieList     //영화 리스트를 받아오기 위함
            {
                public List<Movie> movies { get; set; }
            }
        
                
        ```
        
4. JSON 원본 데이터를 excel로 불러와 필요정보 추출, SQL 명령문으로 직접 DB 입력
*빠른 작업을 위해 익숙한 excel tool 사용
        
        
        ![json 형식(원본 데이터)](Notion_Image/image%2010.png)
        
        json 형식(원본 데이터)
        
        ![추출 및 SQL문 입력 예](Notion_Image/image%2011.png)
        
        추출 및 SQL문 입력 예
        
    
    💡 향후 개선 방향
    
    인증키 승인 절차 및 API 호출 조건에 대해 추가 학습 예정
</details>    
- 트러블 슈팅 (2/2)
<details>    
    🚨 문제 배경
    
    로그인/회원가입 창 크기 오류. 쉬운화면과 일반화면에서 공통으로 사용하는 회원관리 창을 하나의 폼으로 구성했으나, 호출 시마다 이전 창의 크기를 덮어써 UI 깨짐 발생
    
    💡 해결방법
    
    초기화 단계에서 창 크기를 고정하고 각 페이지에서 호출시 크기를 덮어쓰는 방식을 사용해봤으나 최초 1회만 성공. 2회차 이후는 크기가 1회차에서 변경되지 않음.
    **조건에 따라 표시되도록 UI를 분리 설계하여 해결.**

다만, 실시간 영화 정보 연동을 위해 TMDB API를 사용하고자 했지만, 인증 문제와 WinForm 환경에서의 제약으로 인해 끝내 직접 데이터를 가공해 넣는 우회 방식을 선택할 수밖에 없었습니다. 또 하나의 폼에서 회원 기능을 통합하려던 구조도 UI 충돌 문제로 실패하면서, 설계 초기 단계에서의 **기술적 범위에 대한 과신**을 돌아보게 되었습니다.

폼 간 연동, 좌석 랜덤화 처리, 예외 처리 등 실제 서비스 수준의 구현을 경험할 수 있었던 점은 큰 수확이었지만, **전체 흐름에 비해 세부 완성도나 자동화 구현은 아쉬운 부분이 남는 프로젝트**였습니다. 그만큼 다음 프로젝트에서는 더 세밀한 설계와 기술 적용의 밸런스를 고려할 수 있을 것 같습니다.
</details>
