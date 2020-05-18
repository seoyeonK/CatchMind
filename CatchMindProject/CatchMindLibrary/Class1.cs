using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;//Client_Info.hclient 용
using System.Net.Sockets;//Client_Info.hclient 용
using System.IO;//Packet용
using System.Runtime.Serialization.Formatters.Binary;//Packet용


namespace CatchMindLibrary
{
    public enum PacketType //패킷타입 구별. receive함수에서 int로 변환해서 사용
    {
        채팅=0,
        그림,
        나가기,
        들어오기
    }

    public class Client_Info
    {
        public string nickname;//사용자 이름
        public string pwd;//사용자 비밀번호
        public int img_num;//사용자 프로필 이미지 번호
        public bool drawable;//그리기 권한 여부
        public int score;//맞춘 개수 점수
        public TcpClient client;//client 누군지 구분
    }
    
    [Serializable]
    public class Packet//패킷 정의(강의예제 그대로함)
    {
        public int Length;
        public int Type;

        public Packet()
        {
            this.Length = 0;
            this.Type = 0;
        }

        public static byte[] Serialize(Object o)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, o);
            return ms.ToArray();
        }

        public static Object Desserialize(byte[] bt)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            foreach (byte b in bt)
            {
                ms.WriteByte(b);
            }

            ms.Position = 0;
            BinaryFormatter bf = new BinaryFormatter();
            Object obj = bf.Deserialize(ms);
            ms.Close();
            return obj;
        }
    }

    [Serializable]
    public class Chat_data : Packet//채팅 데이터 패킷
        {
        public string nickname;
        public string data;
    }

    [Serializable]
    public class Draw_data : Packet//그림 데이터 패킷
    {


    }

    [Serializable]
    public class Exit_data : Packet//게임 떠날 때 보낼 데이터 패킷
    {


    }

    [Serializable]
    public class Join_Data : Packet//게임 참가할 때 보낼 데이터 패킷
    {


    }

}
