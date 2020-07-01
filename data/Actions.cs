using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SIFAScontrol.data
{
    public class Actions
    {

        Action[] ial = new Action[6];

        public Action this[int i]
        {
            get { return ial[i]; }
            set { ial[i] = value; }
        }
        public int ialSize()
        {
            return ial.Length;
        }

        public Actions() {
            PreviousFormation = new Action("Previous Formation", "Select the Previous Formation Area");
            NextFormation = new Action("Next Formation", "Select the Next Formation Area");
            Pause = new Action("Pause", "Select the Pause Area");
            LeftTouch = new Action("Left Touch", "Select the Left Touch Area");
            RightTouch = new Action("Right Touc", "Select the Right Touch Area");
            GroupSkill = new Action("Group Skill", "Select the Group Skill Area");
            ial[0] = PreviousFormation;
            ial[1] = NextFormation;
            ial[2] = Pause;
            ial[3] = LeftTouch;
            ial[4] = RightTouch;
            ial[5] = GroupSkill;
            Console.WriteLine(ial[5]);
        }

        public Action PreviousFormation { get; set; }
        public Action NextFormation { get; set; }
        public Action Pause { get; set; }
        public Action LeftTouch { get; set; }
        public Action RightTouch { get; set; }
        public Action GroupSkill { get; set; }


    }
}
