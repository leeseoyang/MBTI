# 🧠 MBTI 성격유형 검사 앱 (WPF 기반)

이 프로젝트는 WPF(Windows Presentation Foundation)를 활용하여 개발된 **MBTI 성격유형 GUI 애플리케이션**입니다.  
각 MBTI 유형(총 16가지)에 따라 결과 화면이 다르게 구성되어 있으며, 직관적인 UI로 성격유형을 확인할 수 있습니다.

---

## 🎯 주요 기능

- ✅ 16가지 MBTI 유형별 결과 화면 (`ENFP.xaml`, `INTJ.xaml` 등)
- ✅ `MainWindow.xaml`에서 시작되는 GUI 기반 인터페이스
- ✅ XAML을 활용한 페이지 이동 및 라우팅
- ✅ 배경 이미지 및 한글 폰트(KOTRA HOPE.ttf) 적용
- ✅ `.NET 6.0` 기반으로 경량화된 배포 가능

---

## 🖥️ 실행 환경

| 항목 | 설명 |
|------|------|
| 운영체제 | Windows 10 이상 |
| .NET SDK | [.NET 6.0 SDK + Windows Desktop Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) |
| 개발도구 | Visual Studio Code 또는 Visual Studio 2022 |
| 언어 | C#, XAML |

---

## ▶️ 실행 방법 (VSCode 기준)

```bash
# 1. 저장소 클론
git clone https://github.com/leeseoyang/MBTI.git
cd MBTI

# 2. 런타임 설치 (없다면)
# https://dotnet.microsoft.com/en-us/download/dotnet/6.0

# 3. 실행
dotnet run --project mbti.csproj

📁 프로젝트 구조
MBTI/
├── App.xaml                  # 앱 진입점
├── MainWindow.xaml          # 메인 화면
├── [MBTI유형].xaml          # 16개 유형별 화면
├── Font/
│   └── KOTRA HOPE.ttf       # 한글 폰트
├── images/
│   └── main.jpg             # 배경 이미지
├── mbti.csproj              # 프로젝트 설정
└── Properties/

🛠 사용 기술 스택
WPF (.NET 6.0)

C# + XAML

Visual Studio / VSCode

Windows Desktop Runtime

GitHub 연동

🧑‍💻 개발자
GitHub: @leeseoyang

만든 목적: 교내 WPF 실습 + 개인 프로젝트 포트폴리오

⭐️ 이 프로젝트가 도움이 되셨다면 Star 눌러주세요!