using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatchMindLibrary;//라이브러리 추가
using System.Net.Sockets;//IPAddress변수때문에 넣음
using System.Net;//IPAddress변수때문에 넣음

namespace CatchMindProject
{
    public partial class Server_Form : Form
    {
        const int PORT=2002;//포트값
        IPAddress ipAddr;//아이피 주소값 저장

        Client_Info[] arrClient=new Client_Info[10];//클라이언트정보 배열
        int count_client;//현재 클라이언트 수
        int count_game;//진행된 게임 수
        bool correct = false;//정답 여부 
        string answer;//정답


        public Server_Form()
        {
            InitializeComponent();
        }

        void receive_client()//클라이언트 접속 받아들임
        {

        }

        void startGame()//게임 시작
        {

        }

        void receiveData()//데이터 수신
        {

        }

        void sendToAll()//모든클라이언트에게 전송
        {

        }


        void getAnswer()//플레이어들이 보낸 답 수신
        {

        }

        

    }
}
