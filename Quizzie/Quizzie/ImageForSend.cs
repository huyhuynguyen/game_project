using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzie
{
    [Serializable]
    class ImageForSend
    {
        public string quesid;
        public string difficult;
        public string answer;
        public string ansid;
        public Image img1;
        public Image img2;
    }

    
}
