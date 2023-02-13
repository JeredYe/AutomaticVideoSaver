using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace AutomaticVideoSaver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String Pathfile = "D:/AutoDownPath.dat";
        private String OpenPath="", SavePath = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "视频自动收集器ByTangent Beta"+System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            if (Read(Pathfile)!="")
            {
                StreamReader sr = new StreamReader(Pathfile, Encoding.Default);
                OpenPath = sr.ReadLine();
                SavePath = sr.ReadLine();
                sr.Close();
                DetectList();
                //               MessageBox.Show("原目录已读取：\r\n视频目录：" + OpenPath + "\r\n存储目录：" + SavePath, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tOpen.Text = OpenPath;
                tSave.Text = SavePath;
                
            }
        }

        List<String> VideoPaths = new List<string>();
        List<String> VideoTitles = new List<string>();
        List<String> VideoDirectories = new List<string>();
        public List<string> GetVideoList(string sSourcePath)

        {

            List<String> list = new List<string>();

            //遍历文件夹

            DirectoryInfo theFolder = new DirectoryInfo(sSourcePath);

            FileInfo[] thefileInfo = theFolder.GetFiles("*.mp4", SearchOption.TopDirectoryOnly);

            foreach (FileInfo NextFile in thefileInfo)  //遍历文件

                list.Add(NextFile.FullName);


            //遍历子文件夹

            DirectoryInfo[] dirInfo = theFolder.GetDirectories();

            foreach (DirectoryInfo NextFolder in dirInfo)

            {

                //list.Add(NextFolder.ToString());

                FileInfo[] fileInfo = NextFolder.GetFiles("*.mp4", SearchOption.AllDirectories);

                foreach (FileInfo NextFile in fileInfo)  //遍历文件

                    list.Add(NextFile.FullName);
            }

            return list;
        }

        public List<string> GetVideoTitle(string sSourcePath)

        {

            List<String> list = new List<string>();

            //遍历文件夹

            DirectoryInfo theFolder = new DirectoryInfo(sSourcePath);

            FileInfo[] thefileInfo = theFolder.GetFiles("*.mp4", SearchOption.TopDirectoryOnly);

            foreach (FileInfo NextFile in thefileInfo)  //遍历文件

                list.Add(NextFile.Name);


            //遍历子文件夹

            DirectoryInfo[] dirInfo = theFolder.GetDirectories();

            foreach (DirectoryInfo NextFolder in dirInfo)

            {

                //list.Add(NextFolder.ToString());

                FileInfo[] fileInfo = NextFolder.GetFiles("*.mp4", SearchOption.AllDirectories);

                foreach (FileInfo NextFile in fileInfo)  //遍历文件

                    list.Add(NextFile.Name);
            }

            return list;
        }

        public List<string> GetVideoDirectory(string sSourcePath)

        {

            List<String> list = new List<string>();

            //遍历文件夹

            DirectoryInfo theFolder = new DirectoryInfo(sSourcePath);

            FileInfo[] thefileInfo = theFolder.GetFiles("*.mp4", SearchOption.TopDirectoryOnly);

            foreach (FileInfo NextFile in thefileInfo)  //遍历文件

            {
                list.Add(NextFile.DirectoryName);
                
            }
                

            //遍历子文件夹

            DirectoryInfo[] dirInfo = theFolder.GetDirectories();

            foreach (DirectoryInfo NextFolder in dirInfo)

            {

                //list.Add(NextFolder.ToString());

                FileInfo[] fileInfo = NextFolder.GetFiles("*.mp4", SearchOption.AllDirectories);

                foreach (FileInfo NextFile in fileInfo)  //遍历文件

                    list.Add(NextFile.DirectoryName);
            }

            return list;
        }
        public List<string> GetBilibiliTitle()
        {
            StreamReader sr = null;
            String TempPath = "";
            for (int i=0;i<VideoPaths.Count;i++)
            {
                TempPath = VideoDirectories[i].Substring(0,
                    VideoDirectories[i].Length
                    -"1\\".Length
                    );
 //               MessageBox.Show(TempPath);
                sr = new StreamReader(TempPath+"\\desktop.ini", Encoding.Default);
                sr.ReadLine();
                VideoTitles[i]=sr.ReadLine();
                VideoTitles[i] = VideoTitles[i].Replace("InfoTip=", "");
                VideoTitles[i] += ".mp4";
                sr.Close();

            }

            return VideoTitles;
        }

        void DetectList()
        {
            VideoPaths = GetVideoList(OpenPath);
            VideoDirectories = GetVideoDirectory(OpenPath);
            if(Preserve.Checked)
            {
               VideoTitles = GetVideoTitle(OpenPath);
            }
            else if(Bilibili.Checked)
            {
                VideoTitles = GetVideoTitle(OpenPath);
                VideoTitles = GetBilibiliTitle();
            }
            label1.Text = "检测到 "+VideoPaths.Count+" 个视频";
            if (VideoPaths.Count!=0)
            {
                progress.Maximum = VideoPaths.Count;
            }
        }

        public String Read(string path)
        {
            StreamReader sr = new StreamReader(path, Encoding.Default);
            String line;
            line= sr.ReadToEnd();
            sr.Close();
            return line;
            
        }

        private void WritePath()
        {
            FileStream fs = new FileStream(Pathfile, FileMode.OpenOrCreate);
            byte[] byteArray = System.Text.Encoding.Default.GetBytes(OpenPath+"\r\n");
            fs.Write(byteArray, 0, byteArray.Length);
            byteArray = System.Text.Encoding.Default.GetBytes(SavePath);
            fs.Write(byteArray, 0, byteArray.Length);
            fs.Flush();
            fs.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            if (openFile.SelectedPath != "")
            {
                OpenPath = openFile.SelectedPath;
                saveFile.ShowDialog();
                if(saveFile.SelectedPath!="")
                {
                    SavePath = saveFile.SelectedPath;
                }
                WritePath();
                DetectList();
                tOpen.Text = OpenPath;
                tSave.Text = SavePath;
                MessageBox.Show("目录已设置！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DetectList();
            }
            
        }

        /*private static bool CopyDirectory(string SourcePath, string DestinationPath, bool overwriteexisting)
        {
            bool ret = false;
            try
            {
                SourcePath = SourcePath.EndsWith(@"\") ? SourcePath : SourcePath + @"\";
                DestinationPath = DestinationPath.EndsWith(@"\") ? DestinationPath : DestinationPath + @"\";

                if (Directory.Exists(SourcePath))
                {
                    if (Directory.Exists(DestinationPath) == false)
                        Directory.CreateDirectory(DestinationPath);

                    foreach (string fls in Directory.GetFiles(SourcePath))
                    {
                        FileInfo flinfo = new FileInfo(fls);
                        flinfo.CopyTo(DestinationPath + flinfo.Name, overwriteexisting);
                    }
                    foreach (string drs in Directory.GetDirectories(SourcePath))
                    {
                        DirectoryInfo drinfo = new DirectoryInfo(drs);
                        if (CopyDirectory(drs, DestinationPath + drinfo.Name, overwriteexisting) == false)
                            ret = false;
                    }
                }
                ret = true;
            }
            catch (Exception ex)
            {
                ret = false;
            }
            return ret;
        }
        */
        private void CopyFile()
        {
            for (int i=0;i<VideoPaths.Count;i++)
            {
 //               MessageBox.Show(SavePath + "\\" + VideoTitles[i]);
                File.Copy(VideoPaths[i], SavePath+"\\"+VideoTitles[i],true);
                progress.Value = i + 1;
                if(delete.Checked)File.Delete(VideoPaths[i]);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (OpenPath == "")
            {
                MessageBox.Show("请先选择目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                button2.Enabled = false;
                CopyFile();
                DetectList();
                button2.Enabled = true;
                MessageBox.Show("完毕！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progress.Value = 0;
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DetectList();
        }

        private void progress_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OpenPath = tOpen.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tSave_TextChanged(object sender, EventArgs e)
        {
            SavePath = tSave.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenPath = tOpen.Text;
            SavePath = tSave.Text;
            WritePath();
            DetectList();

        }

        private void saveFile_HelpRequest(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
