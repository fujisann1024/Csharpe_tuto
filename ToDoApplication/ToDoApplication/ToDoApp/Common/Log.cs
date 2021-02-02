using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoApplication.ToDoApp.Common
{
    public class Log
    {
        private string _fileName;  //ファイル名(絶対パスで指定)
        private Boolean _isAppend; //true:追記モード,false:上書きモード(Writeメソッドで使用する)
        private Encoding _encoding;//エンコーディング


        /// <summary>
        /// インスタンス化を行う
        /// </summary>
        public Log()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName">ファイル名(絶対パスで指定する)</param>
        /// <param name="isAppend">true:追記モード,false:上書きモード</param>
        /// <param name="encoding">エンコーディング</param>
        public Log(string fileName, Boolean isAppend, Encoding encoding)
        {
            _fileName = fileName;
            _isAppend = isAppend;
            _encoding = encoding;
        }


        public string FileName
        {
            set { _fileName = value; }
        }

        public Boolean IsAppend
        {
            set { _isAppend = value; }
        }

        public Encoding Encoding
        {
            set { _enccoding = value; }
        }
        /// <summary>
        /// ファイルに文字列を書き込む
        /// </summary>
        /// <param name="format">フォーマット</param>
        /// <param name="args">フォーマットに適用する値(任意指定)</param>
        public void Write(string format, params object[] args)
        {
            StreamWriter streamWriter = new StreamWriter(this._fileName, this._isAppend, this._encoding);

            try
            {
                streamWriter.Write(format, args);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                streamWriter.Close();
            }
        }

        public void WriteLine(string format, params object[] args)
        {
            StreamWriter streamWriter = new StreamWriter(this._fileName, this._isAppend, this._encoding);

            try
            {
                streamWriter.WriteLine(format, args);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                streamWriter.Close();
            }
        }

        public void FileOpen()
        {

            System.Diagnostics.Process prc = new System.Diagnostics.Process();

            prc.StartInfo.FileName = _fileName;
            prc.StartInfo.UseShellExecute = true;
            prc.Start();
        }

    }



    }

}