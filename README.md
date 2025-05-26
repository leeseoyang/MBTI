<p align="center">
  <img src="images/banner.jpg" alt="MBTI Banner" width="800"/>
</p>

# 🧠 MBTI 성격유형 검사 앱 (WPF 기반)

![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=c-sharp&logoColor=white)
![WPF](https://img.shields.io/badge/WPF-68217A?style=flat&logo=windows&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=flat&logo=dotnet&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?style=flat&logo=visualstudio&logoColor=white)

이 프로젝트는 WPF(Windows Presentation Foundation)를 활용하여 개발된 **MBTI 성격유형 GUI 애플리케이션**입니다.  
16가지 MBTI 유형별 결과 화면을 제공하며, 직관적인 사용자 경험을 위한 인터페이스를 갖추고 있습니다.

---

## 📸 실행 화면

<p align="center">
  <img src="images/demo.jpg" alt="앱 실행 화면" width="600"/>
</p>

---

## 🎯 주요 기능

- 16가지 MBTI 유형별 결과 창 제공 (ENFP, INTJ 등)
- MainWindow → 각 유형별 XAML로 라우팅
- WPF + XAML 기반 GUI
- 한글 폰트(KOTRA HOPE) 적용
- 이미지 리소스 포함, 직관적인 UI 구성

---

## 🖥️ 실행 환경

| 항목 | 설명 |
|------|------|
| 운영체제 | Windows 10 이상 |
| 프레임워크 | [.NET 6.0 + Windows Desktop Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) |
| 개발툴 | Visual Studio / VS Code |
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
````

---

## 📁 프로젝트 구조

```
MBTI/
├── App.xaml                  # 앱 진입점
├── MainWindow.xaml          # 메인 화면
├── [MBTI유형].xaml          # 16개 유형별 화면
├── Font/
│   └── KOTRA HOPE.ttf       # 한글 폰트
├── images/
│   └── banner.jpg           # 배너 이미지
│   └── demo.jpg             # 실행 화면
├── mbti.csproj              # 프로젝트 설정
└── Properties/
```

---

## 🛠 사용 기술 스택

* WPF (.NET 6.0)
* C# + XAML
* Visual Studio / VSCode
* Windows Desktop Runtime
* GitHub 연동

---

## 🧑‍💻 개발자

* GitHub: [@leeseoyang](https://github.com/leeseoyang)
* 만든 목적: 교내 WPF 실습 + 개인 프로젝트 포트폴리오

---

## 📜 라이선스

이 프로젝트는 [MIT License](https://opensource.org/licenses/MIT)를 따릅니다.
자유롭게 사용, 수정, 배포하되 반드시 출처를 남겨주세요.

---

## 💬 기여 및 문의

이 프로젝트에 대한 의견, 제안, 버그 제보는 언제든지 환영합니다!
아래 방법으로 문의하거나 GitHub Issue / Pull Request로 참여해주세요.

📧 이메일: [23615038@konyang.ac.kr](mailto:23615038@konyang.ac.kr)
🐙 GitHub: [@leeseoyang](https://github.com/leeseoyang)

---

## 📦 다운로드

* 👉 [최신 실행파일 받기 (Releases)](https://github.com/leeseoyang/MBTI/releases)
* 또는 직접 클론 후 빌드해서 사용해주세요.

---

> ⭐️ 이 프로젝트가 도움이 되셨다면 상단 오른쪽 `⭐ Star`를 눌러주시면 큰 힘이 됩니다!

