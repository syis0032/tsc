using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSC.Class
{
    public class LogLine
    {
        public string text;
        public bool response;
        public int level = 0;
        public DateTime time;

        public LogLine(string _text, bool _response, int _level)
        {
            time = DateTime.Now;
            text = Time() + " : " + _text;
            response = _response;
            level = _level;
        }
        public string Time()
        {
            return "[" + time.Hour.ToString("00") + ":" + time.Minute.ToString("00") + ":" + time.Second.ToString("00") + "." + time.Millisecond.ToString("000") + "]";
        } 
    }
}
