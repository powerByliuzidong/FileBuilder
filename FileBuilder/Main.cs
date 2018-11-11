using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FileBuilder
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BuilderButton_Click(object sender, EventArgs e)
        {
           
            string host = hostTextBox.Text;
            string port = portTextBox.Text;
            string db = dbNameTextBox.Text;
            string user = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            string sql = sqlTextBox.Text;
            string charset = charsetTextBox.Text;
            string separatorType = separatorTypeComboBox.Text;
            string separator = separatorTextBox.Text;
            if (host.Length == 0)
            {
                MessageBox.Show("数据库地址未填写");
            }
            if(db.Length == 0)
            {
                MessageBox.Show("数据库名称未填写");
            }
            if (user.Length == 0)
            {
                MessageBox.Show("用户名未填写");
            }
            if(password.Length == 0)
            {
                MessageBox.Show("数据库密码未填写");
            }
            if(sql.Length == 0)
            {
                MessageBox.Show("sql未填写");
            }
            if (charset.Length == 0)
            {
                MessageBox.Show("文件编码未指定");
            }
            if (separator.Length == 0)
            {
                MessageBox.Show("字段分隔符未填写");
            }
            if (separatorType.Length == 0)
            {
                MessageBox.Show("字段分隔符类型未填写");
            }
            IDbConnection connection = GetConnect(host, int.Parse(port), db, user, password);
            connection.Open();
            IDbCommand command = new MySqlCommand(sql, (MySqlConnection)connection);
            IDataReader dataReader = command.ExecuteReader();
            int fieldCount = dataReader.FieldCount;
            List<object[]> data = new List<object[]>();
            while (dataReader.Read())
            {
                var column = new object[dataReader.FieldCount];
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    column.SetValue(dataReader.GetValue(i), i);
                }
                data.Add(column);
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName.Length == 0)
            {
                return;
            }
            if (separatorType == "ASCII")
            {
                char separatorChar;
                if (IsNumber(separator))
                {
                    separatorChar = Convert.ToChar(Convert.ToInt16(separator));
                }
                else
                {
                    MessageBox.Show("在ASCII模式下，请填写十进制数字");
                    return;
                }
                MakeFile(data, saveFileDialog.FileName, separatorChar, charset);
            }
            else
            {
                MakeFile(data, saveFileDialog.FileName, separator.ToCharArray(), charset);
            }
            MessageBox.Show("文件生成成功");
            
        }

        private bool IsNumber(string str)
        {
            try
            {
                int num = Convert.ToInt16(str);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void MakeFile(List<object[]> data, string filePath , object separator, string charset)
        {
            StringBuilder builder = new StringBuilder();

            data.ForEach(item => 
            {
                item.ToList().ForEach(obj =>
                {
                    builder.Append(obj);
                    builder.Append(separator);
                });
                builder.AppendLine();
            });
            byte[] content = Encoding.GetEncoding(charset).GetBytes(builder.ToString());
            FileStream fileStream = new FileStream(filePath, FileMode.CreateNew);
            fileStream.Write(content, 0, content.Length);
            fileStream.Close();
            fileInfoTextBox.Text = GeneratorAttrinfo(Encoding.GetEncoding(charset).GetString(content));
        }

        private string GeneratorAttrinfo(string fileContent)
        {
            string md5 = CreateMD5Hash(fileContent);
            StringBuilder builder = new StringBuilder();
            builder.Append("------------------------MD5-----------------------");
            builder.AppendLine();
            builder.Append(md5);
            builder.AppendLine();
            builder.Append("--------------------------------------------------");
            builder.AppendLine();
            return builder.ToString();
        }

        private string CreateMD5Hash(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }

        //private void makeFile(List<object[]> data, string fileName, char separator, string separatorType, string charset)
        //{
        //    Console.WriteLine(data.Count());
        //    data.ForEach(item => Console.WriteLine(item.Length));
        //}

        private IDbConnection GetConnect(string host, int port, string db, string username, string password)
        {
            DbClient client = new DbClient(host, port, username, password, db);
            return client.GetConnection();
        }

        private void CodePageLink_click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                codePageLink.LinkVisited = true;
                System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/windows/desktop/intl/code-page-identifiers");
            }
            catch
            {
                MessageBox.Show("启动浏览器失败，请复制链接到浏览器打开。https://docs.microsoft.com/en-us/windows/desktop/intl/code-page-identifiers");
            }
        }

    }

    public class DbClient
    {
        private readonly IDbConnection connection;
        private string host;
        private int port;
        private string userName;
        private string password;
        private string dbName;


        public DbClient(string host, string userName, string password, string dbName)
        {
            this.host = host;
            this.port = 3306;
            this.userName = userName;
            this.password = password;
            this.dbName = dbName;
        }

        public DbClient(string host, int port, string userName, string password, string dbName)
        {
            this.host = host;
            this.port = port;
            this.userName = userName;
            this.password = password;
            this.dbName = dbName;
        }

        public IDbConnection GetConnection()
        {
            if (connection == null)
            {
                MySqlConnectionStringBuilder stringBuilder = new MySqlConnectionStringBuilder();
                stringBuilder.Server = host;
                stringBuilder.Port = (uint)port;
                stringBuilder.Database = dbName;
                stringBuilder.UserID = userName;
                stringBuilder.Password = password;
                return new MySqlConnection(stringBuilder.ToString());
            }
            else
            {
                return connection;
            }
          
        }

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string DbName { get => dbName; set => dbName = value; }
        public string Host { get => host; set => host = value; }
        public int Port { get => port; set => port = value; }
    }

}
