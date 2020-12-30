using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace JRA_VAN_PROTO.Handler
{
    /// <summary>
    /// 
    /// </summary>
    public class FileWriteHander : RecordHandler
    {
        private string _path;
        public string Path
        {
            get
            {
                if (this._path == null)
                {
                    this._path = this.Parameter;
                }
                return this._path;
            }
            set
            {
                this._path = value;
            }
        }

        private StreamWriter writer;

        public override RecordHandler Open()
        {
            base.Open();
            this.writer = new StreamWriter(Path, true);
            return this;
        }

        public override void Read(string recordSpec, string record)
        {
            string[] separated = record.Split("\r\n");
            string line = Format(recordSpec, $"{separated[0]}");
            if (line != null)
            {
                Debug.WriteLine($"{line}");
                Write(line);
            }
        }

        public virtual void Write(string line)
        {
            this.writer.Write($"{line}\r\n");
        }

        public virtual string Format(string recordSpec, string record)
        {
            return record;
        }

        public override void Dispose()
        {
            if (this.writer != null)
            {
                this.writer.Close();
            }
            base.Dispose();
        }
    }

}
