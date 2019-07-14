using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using Baidu.Aip.Speech;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;



namespace peoplePicture
{
    public partial class voicedeal : Form
    {
        public voicedeal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            //fdlg.InitialDirectory = @"c:/";   //@是取消转义字符的意思
            //fdlg.Filter = "All files（*.*）|*.*|All files(*.*)|*.* ";
            ///*
            // * FilterIndex 属性用于选择了何种文件类型,缺省设置为0,系统取Filter属性设置第一项
            // * ,相当于FilterIndex 属性设置为1.如果你编了3个文件类型，当FilterIndex ＝2时是指第2个.
            // */
            fdlg.FilterIndex = 2;
            ///*
            // *如果值为false，那么下一次选择文件的初始目录是上一次你选择的那个目录，
            // *不固定；如果值为true，每次打开这个对话框初始目录不随你的选择而改变，是固定的  
            // */
            //fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                //textBox1.Text = System.IO.Path.GetFileNameWithoutExtension(fdlg.FileName);
                filePath.Text = System.IO.Path.GetFullPath(fdlg.FileName);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //this.Speech_Synthesis.Text = "11111";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //videoType.SelectedIndex = 0;
        }

        // 语音合成按钮
        private void button2_Click(object sender, EventArgs e)
        {
            string value = this.videoType.Text;
            String filePath = this.filePath.Text;
            // 设置APPID/AK/SK
            String APP_ID = "16608219";
            String API_KEY = "rjeInGuw5u1Y7hrY9he7rUw3";
            String SECRET_KEY = "4RPxz8yC63i3puZNVC93ZqFCtiw5n16G";
            var client = new Asr(APP_ID, API_KEY, SECRET_KEY);
            client.Timeout = 60000;  // 修改超时时间
            client.Timeout = 120000; // 若语音较长，建议设置更大的超时时间. ms
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            byte[] buffur = new byte[fs.Length];
            try
            {
                fs.Read(buffur, 0, (int)fs.Length);

            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
            }
            finally
            {
                if (fs != null)
                {
                    //关闭资源  
                    fs.Close();
                }
            }
            var result = client.Recognize(buffur, value, 16000);
            voiceResult.Text = result["result"][0].ToString();
            Console.Write(result);
        }

        // 开始合成按钮（语音合成功能）
        private void synthesisButton_Click(object sender, EventArgs e)
        {
            String APP_ID = "16608219";
            String API_KEY = "rjeInGuw5u1Y7hrY9he7rUw3";
            String SECRET_KEY = "4RPxz8yC63i3puZNVC93ZqFCtiw5n16G";
            // 获取输入框的值
            String value = this.Speech_Synthesis.Text;
            // 将 value 转成语音文件存放到本地
            var client = new Baidu.Aip.Speech.Tts(API_KEY, SECRET_KEY);
            // 可选参数
            var option = new Dictionary<string, object>()
            {
                {"spd", 3}, // 语速
                {"vol", 7}, // 音量
                {"per", 4}  // 发音人，4：情感度丫丫童声
            };
            var result = client.Synthesis(value, option);
            try
            {
                if (result.ErrorCode == 0)
                { // 或 result.Success
                    File.WriteAllBytes(@"C:\Users\sunwei\Desktop\1.mp3", result.Data);
                }

            }
            catch (Exception ex) { Console.Write(ex.StackTrace); }
            Play();
        }

        [DllImport("winmm.dll")]
        public static extern uint mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, IntPtr hWndCallback);
        public void Play()
        {
            mciSendString(@"open C:\Users\sunwei\Desktop\1.mp3 alias temp_alias",
                null, 0, IntPtr.Zero);
            uint a = mciSendString("play temp_alias", null, 0, IntPtr.Zero);
            StringBuilder strReturn = new StringBuilder(64);
            do
            {
                mciSendString("status temp_alias mode", strReturn, 64, IntPtr.Zero);
            } while (!Convert.ToString(strReturn).Contains("stopped"));
            mciSendString("close temp_alias", null, 0, IntPtr.Zero);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void voiceResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
