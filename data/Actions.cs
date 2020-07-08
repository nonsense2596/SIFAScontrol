using SIFAScontrol.data.ActionClasses;
using SIFAScontrol.Abstraction;
using static SIFAScontrol.Abstraction.KeyEventArgs;

namespace SIFAScontrol.data
{
    public class Actions
    {

        Action[] ial = new Action[14];

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
            // TODO thumb movements, might need many additional records here, as all directions are separate
            // TODO shit starting to get ugly, make it cleaner
            PreviousFormation = new Action(KeyCode.L,           "Previous Formation", "Select the Previous Formation Area", new GestureSurface(),   new TouchAction());
            NextFormation =     new Action(KeyCode.R,           "Next Formation", "Select the Next Formation Area",         new GestureSurface(),   new TouchAction());
            Pause =             new Action(KeyCode.Start,       "Pause", "Select the Pause Area",                           new GestureSurface(),   new TouchAction());
            LeftTouchUp =       new Action(KeyCode.LThumbUp,    "Left Touch", "Select the Left Touch Area",                 new GestureSurface(),   new MoveAction());
            LeftTouchRight =    new Action(KeyCode.LThumbRight, "Left Touch", "Select the Left Touch Area",                 LeftTouchUp.Area,       new MoveAction());
            LeftTouchDown =     new Action(KeyCode.LThumbDown,  "Left Touch", "Select the Left Touch Area",                 LeftTouchUp.Area,       new MoveAction());
            LeftTouchLeft =     new Action(KeyCode.LThumbLeft,  "Left Touch", "Select the Left Touch Area",                 LeftTouchUp.Area,       new MoveAction());
            RightTouchUp =      new Action(KeyCode.RThumbUp,    "Right Touch", "Select the Right Touch Area",               new GestureSurface(),   new MoveAction());
            RightTouchRight =   new Action(KeyCode.RThumbRight, "Right Touch", "Select the Right Touch Area",               RightTouchUp.Area,      new MoveAction());
            RightTouchDown =    new Action(KeyCode.RThumbDown,  "Right Touch", "Select the Right Touch Area",               RightTouchUp.Area,      new MoveAction());
            RightTouchLeft =    new Action(KeyCode.RThumbLeft,  "Right Touch", "Select the Right Touch Area",               RightTouchUp.Area,      new MoveAction());
            GroupSkill =        new Action(KeyCode.A,           "Group Skill", "Select the Group Skill Area",               new GestureSurface(),   new TouchAction());
            LeftHold =          new Action(KeyCode.LTrigger,    "Left Hold", "Left Hold Area PH",                           new GestureSurface(),   new HoldAction());
            RightHold =         new Action(KeyCode.RTrigger,    "Left Hold", "Left Hold Area PH",                           new GestureSurface(),   new HoldAction());
            ial[0] = PreviousFormation;
            ial[1] = NextFormation;
            ial[2] = Pause;
            ial[3] = LeftTouchUp;
            ial[4] = RightTouchUp;
            ial[5] = GroupSkill;
            ial[6] = LeftHold;
            ial[7] = RightHold;
            ial[8] = LeftTouchRight;
            ial[9] = LeftTouchDown;
            ial[10] = LeftTouchLeft;
            ial[11] = RightTouchRight;
            ial[12] = RightTouchDown;
            ial[13] = RightTouchLeft;
            //Console.WriteLine(ial[5]);
        }

        public Action PreviousFormation { get; set; }
        public Action NextFormation { get; set; }
        public Action Pause { get; set; }
        public Action GroupSkill { get; set; }
        public Action LeftHold { get; set; }
        public Action RightHold { get; set; }


        public Action LeftTouchUp { get; set; }
        public Action LeftTouchLeft { get; set; }
        public Action LeftTouchDown { get; set; }
        public Action LeftTouchRight { get; set; }

        public Action RightTouchUp { get; set; }
        public Action RightTouchLeft { get; set; }
        public Action RightTouchDown { get; set; }
        public Action RightTouchRight { get; set; }

    }
}
