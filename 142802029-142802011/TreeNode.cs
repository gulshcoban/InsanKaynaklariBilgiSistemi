using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _142802029_142802011
{
    public class TreeNode
    {
        public Kisi veri;
        public TreeNode sol;
        public TreeNode sag;
        public TreeNode()
        {
        }

        public TreeNode(Kisi k)
        {
            this.veri = k;
            sol = null;
            sag = null;
        }
    }
}
