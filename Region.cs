using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Region
    {
        private string Name;
        private int GroupAmt = 0;
        private List<List<int>> Groups = new List<List<int>>();

        public Region(int[] codes, string name)
        {
            Name = name;

            //Receive & Sort Codes
            Array.Sort(codes);

            int i = 0;
            int prevCode = 0;
            
            List<int> curGroup = new List<int>();

            //Add the code to a group 
            foreach (int code in codes)
            {
                //If consecutive add code to current group, else create new group
                if (code == prevCode + 1 || prevCode == 0)
                {
                    curGroup.Add(code);
                }
                else
                {
                    Groups.Add(curGroup);
                    curGroup = new List<int>();
                    curGroup.Add(code);
                    
                }
                prevCode = code;
                i++;
            }
            //Add the final group
            Groups.Add(curGroup);

            GroupAmt = Groups.Count;
        }

        public int[] getAll()
        {
            //Flatten Nested Lists
            //I assumed you would want arrays as return types
            return Groups.SelectMany(a => a).ToArray();
        }

        public int[] getGroup(int groupNo)
        {
            return Groups[groupNo].ToArray();
        }

        public string getName()
        {
            return Name;
        }

        public int getGroupAmt()
        {
            return GroupAmt;
        }

    }
}
