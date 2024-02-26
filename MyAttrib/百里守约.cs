using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAttrib
{
    [Hero]
    class 百里守约
    {
        [Skill]
        public void 魔法攻击()
        {
            MessageBox.Show("百里守约-魔法攻击", "提示");
        }
        [Skill]

        public void 物理攻击()
        {
            MessageBox.Show("百里守约-物理攻击", "提示");
        }
    }
}
