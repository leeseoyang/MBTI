using System.Windows;

namespace mbti
{
    /// <summary>
    /// Test1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Test1 : Window
    {
        public Test1()
        {
            InitializeComponent();
            txtQ.Text = "Q1";
            txtContent.Text = "        사람들의 감정을 고려하기 보다는 \n 공정한 결정을 내리는 것을 더 중요하게 생각한다.";
        }

        // Yes 버튼
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (txtQ.Text == "Q1")
            {
                Common.Tf = 1;

                txtQ.Text = "Q2";
                txtContent.Text = " 다른 사람들과 함께 있는 시간보다 \n 혼자 있는 시간이 더 빨리 지나간다";
            }
            else if (txtQ.Text == "Q2")
            {
                Common.Ie = 1;

                txtQ.Text = "Q3";
                txtContent.Text = "나는 가끔 전쟁,자연재해 등의 \n말도 안되는 상상을 하고는 한다.";
            }
            else if (txtQ.Text == "Q3")
            {
                Common.Ns = 1;

                txtQ.Text = "Q4";
                txtContent.Text = "일을 마친 후에도 해야할 일 목록을 계속\n               생각하는 편이다.";
            }
            else if (txtQ.Text == "Q4")
            {
                Common.Jp = 1;

                txtQ.Text = "Q5";
                txtContent.Text = "약속 시간에 늦은 상황에 대한 사과보다 \n              늦은 사유가 더 중요하다.";
            }
            else if (txtQ.Text == "Q5")
            {
                if (Common.Tf == 2)
                    Common.Tf = 3;
                else
                    Common.Tf = 1;

                txtQ.Text = "Q6";
                txtContent.Text = "새로운 사람을 만날 때 그 사람을 알아가는 과정이 \n             당신에게 일종의 프로젝트 같나요?";
            }
            else if (txtQ.Text == "Q6")
            {
                if (Common.Ie == 2)
                    Common.Ie = 3;
                else
                    Common.Ie = 1;

                txtQ.Text = "Q7";
                txtContent.Text = "아직 일어나지 않은 미래의 일에 대한 \n          걱정을 자주 하는 편이다.";
            }
            else if (txtQ.Text == "Q7")
            {
                if (Common.Ns == 2)
                    Common.Ns = 3;
                else
                    Common.Ns = 1;

                txtQ.Text = "Q8";
                txtContent.Text = "나는 모든 일에 대략적인 순서를 정해놓고\n 지켜지지 않을 경우 스트레스를 받는 편이다.";
            }
            else if (txtQ.Text == "Q8")
            {
                if (Common.Jp == 2)
                    Common.Jp = 3;
                else
                    Common.Jp = 1;

               
               if (Common.Ie == 3)
                {
                    txtQ.Text = "Q9-2";
                    txtContent.Text = "나는 모임에서 주로 이야기를 주도하는 편이다.";
                    
                }

                else if (Common.Ns == 3)
                {
                    txtQ.Text = "Q9-3";
                    txtContent.Text = "미래의 가능성과 잠재력에 대해 생각하는 것을\n 현재의 현실과 사실보다 더 중요하게 여기나요?";
                    
                }

                else if (Common.Jp == 3)
                {
                    txtQ.Text = "Q9-4";
                    txtContent.Text = "일을 마친 후에도 해야할 일 목록을 계속\n           생각하는 편이다.";
                    
                }

                else if (Common.Tf == 3)
                {
                    txtQ.Text = "Q9-1";
                    txtContent.Text = "나는 친구에게 예의상의 칭찬보다는 도움이 될 법한\n           비판이나 조언을 하는 편이다.";
                    
                }
                OpenMbtiPage(); 

            }
            else if (txtQ.Text == "Q9-2")
            {
                Common.Ie = 1;
                OpenMbtiPage();
            }
            else if (txtQ.Text == "Q9-1")
            {
                Common.Tf = 1;
                OpenMbtiPage();
            }
            else if (txtQ.Text == "Q9-3")
            {
                Common.Ns = 1;
                OpenMbtiPage();
            }
            else if (txtQ.Text == "Q9-4")
            {
                Common.Jp = 1;
                OpenMbtiPage();
            }

            
        }

        private void OpenMbtiPage()
        {
            if (Common.Ie == 1 && Common.Ns == 1 && Common.Tf == 2 && Common.Jp == 1)
            {
                ENFJ eNFJ = new ENFJ();
                eNFJ.Show();
            }
            else if (Common.Ie == 1 && Common.Ns == 1 && Common.Tf == 2 && Common.Jp == 2)
            {
                ENFP eNFP = new ENFP();
                eNFP.Show();
            }
            else if (Common.Ie == 1 && Common.Ns == 1 && Common.Tf == 1 && Common.Jp == 1)
            {
                ENTJ eNTJ = new ENTJ();
                eNTJ.Show();
            }
            else if (Common.Ie == 1 && Common.Ns == 1 && Common.Tf == 1 && Common.Jp == 2)
            {
                ENTP eNTP = new ENTP();
                eNTP.Show();
            }
            else if (Common.Ie == 1 && Common.Ns == 2 && Common.Tf == 2 && Common.Jp == 1)
            {
                ESFJ eSFJ = new ESFJ();
                eSFJ.Show();
            }
            else if (Common.Ie == 1 && Common.Ns == 2 && Common.Tf == 2 && Common.Jp == 2)
            {
                ESFP eSFP = new ESFP();
                eSFP.Show();
            }
            else if (Common.Ie == 1 && Common.Ns == 2 && Common.Tf == 1 && Common.Jp == 1)
            {
                ESTJ eSTJ = new ESTJ();
                eSTJ.Show();
            }
            else if (Common.Ie == 1 && Common.Ns == 2 && Common.Tf == 1 && Common.Jp == 2)
            {
                ESTP eSTP = new ESTP();
                eSTP.Show();
            }
            else if (Common.Ie == 2 && Common.Ns == 1 && Common.Tf == 2 && Common.Jp == 1)
            {
                INFJ iNFJ = new INFJ();
                iNFJ.Show();
            }
            else if (Common.Ie == 2 && Common.Ns == 1 && Common.Tf == 2 && Common.Jp == 2)
            {
                INFP iNFP = new INFP();
                iNFP.Show();
            }
            else if (Common.Ie == 2 && Common.Ns == 1 && Common.Tf == 1 && Common.Jp == 1)
            {
                INTJ iNTJ = new INTJ();
                iNTJ.Show();
            }
            else if (Common.Ie == 2 && Common.Ns == 1 && Common.Tf == 1 && Common.Jp == 2)
            {
                INTP iNTP = new INTP();
                iNTP.Show();
            }
            else if (Common.Ie == 2 && Common.Ns == 2 && Common.Tf == 2 && Common.Jp == 1)
            {
                ISFJ iSFJ = new ISFJ();
                iSFJ.Show();
            }
            else if (Common.Ie == 2 && Common.Ns == 2 && Common.Tf == 2 && Common.Jp == 2)
            {
                ISFP iSFP = new ISFP();
                iSFP.Show();
            }
            else if (Common.Ie == 2 && Common.Ns == 2 && Common.Tf == 1 && Common.Jp == 1)
            {
                ISTJ iSTJ = new ISTJ();
                iSTJ.Show();
            }
            else if (Common.Ie == 2 && Common.Ns == 2 && Common.Tf == 1 && Common.Jp == 2)
            {
                ISTP iSTP = new ISTP();
                iSTP.Show();
            }
        }
        
        // No 버튼
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (txtQ.Text == "Q1")
            {
                Common.Tf = 2;

                txtQ.Text = "Q2";
                txtContent.Text = "     다른 사람들과 함께 있는 시간보다\n    혼자 있는 시간이 더 빨리 지나간다";
            }
            else if (txtQ.Text == "Q2")
            {
                Common.Ie = 2;

                txtQ.Text = "Q3";
                txtContent.Text = "나는 가끔 전쟁,자연재해 등의 \n말도 안되는 상상을 하고는 한다.";
            }
            else if (txtQ.Text == "Q3")
            {
                Common.Ns = 2;

                txtQ.Text = "Q4";
                txtContent.Text = "일을 마친 후에도 해야할 일 목록을 계속\n               생각하는 편이다.";
            }
            else if (txtQ.Text == "Q4")
            {
                Common.Jp = 2;

                txtQ.Text = "Q5";
                txtContent.Text = "약속 시간에 늦은 상황에 대한 사과보다\n              늦은 사유가 더 중요하다.";
            }
            else if (txtQ.Text == "Q5")
            {
                if (Common.Tf == 1)
                    Common.Tf = 3;
                else
                    Common.Tf = 2;

                txtQ.Text = "Q6";
                txtContent.Text = "새로운 사람을 만날 때 그 사람을 알아가는 과정이 \n             당신에게 일종의 프로젝트 같나요?";
            }
            else if (txtQ.Text == "Q6")
            {
                if (Common.Ie == 1)
                    Common.Ie = 3;
                else
                    Common.Ie = 2;

                txtQ.Text = "Q7";
                txtContent.Text = "아직 일어나지 않은 미래의 일에 대한 \n                걱정을 자주 하는 편이다.";
            }
            else if (txtQ.Text == "Q7")
            {
                if (Common.Ns == 1)
                    Common.Ns = 3;
                else
                    Common.Ns = 2;

                txtQ.Text = "Q8";
                txtContent.Text = " 나는 모든 일에 대략적인 순서를 정해놓고\n 지켜지지 않을 경우 스트레스를 받는 편이다.";
            }
            else if (txtQ.Text == "Q8")
            {
                if (Common.Jp == 1)
                    Common.Jp = 3;
                else
                    Common.Jp = 2;

                if (Common.Ie == 3)
                {
                    txtQ.Text = "Q9-2";
                    txtContent.Text = "나는 모임에서 주로 이야기를 주도하는 편이다.";
                }
                else if (Common.Ns == 3)
                {
                    txtQ.Text = "Q9-3";
                    txtContent.Text = "미래의 가능성과 잠재력에 대해 생각하는 것을\n   현재의 현실과 사실보다 더 중요하게 여기나요?";

                }
                else if (Common.Jp == 3)
                {
                    txtQ.Text = "Q9-4";
                    txtContent.Text = "일을 마친 후에도 해야할 일 목록을 계속\n           생각하는 편이다.";

                }
                else if (Common.Tf == 3)
                {
                    txtQ.Text = "Q9-1";
                    txtContent.Text = "나는 친구에게 예의상의 칭찬보다는 도움이 될 법한\n           비판이나 조언을 하는 편이다.";

                }
                OpenMbtiPage();

            }
            else if (txtQ.Text == "Q9-2")
            {
                Common.Ie = 2;
                OpenMbtiPage();
            }
            else if (txtQ.Text == "Q9-1")
            {
                Common.Tf = 2;
                OpenMbtiPage();
            }
            else if (txtQ.Text == "Q9-3")
            {
                Common.Ns = 2;
                OpenMbtiPage();
            }
            else if (txtQ.Text == "Q9-4")
            {
                Common.Jp = 2;
                OpenMbtiPage();
            }          
        }
    }
}
