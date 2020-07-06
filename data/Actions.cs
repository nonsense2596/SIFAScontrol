namespace SIFAScontrol.data
{
    public class Actions
    {

        Action[] ial = new Action[8];

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
            // TODO if implementing custom bindings for all, additional loop elements in the areaselectform class
            PreviousFormation = new Action(Abstraction.KeyEventArgs.KeyCode.L,"Previous Formation", "Select the Previous Formation Area", new GestureSurface());
            NextFormation =     new Action(Abstraction.KeyEventArgs.KeyCode.R, "Next Formation", "Select the Next Formation Area", new GestureSurface());
            Pause =             new Action(Abstraction.KeyEventArgs.KeyCode.Start, "Pause", "Select the Pause Area", new GestureSurface());
            LeftTouch =         new Action(Abstraction.KeyEventArgs.KeyCode.DPadLeft, "Left Touch", "Select the Left Touch Area", new GestureSurface());
            RightTouch =        new Action(Abstraction.KeyEventArgs.KeyCode.DPadRight, "Right Touch", "Select the Right Touch Area", new GestureSurface());
            GroupSkill =        new Action(Abstraction.KeyEventArgs.KeyCode.A, "Group Skill", "Select the Group Skill Area", new GestureSurface());
            LeftHold =          new Action(Abstraction.KeyEventArgs.KeyCode.LTrigger, "Left Hold", "Left Hold Area PH", new GestureSurface());
            RightHold =         new Action(Abstraction.KeyEventArgs.KeyCode.LTrigger, "Left Hold", "Left Hold Area PH", new GestureSurface());
            ial[0] = PreviousFormation;
            ial[1] = NextFormation;
            ial[2] = Pause;
            ial[3] = LeftTouch;
            ial[4] = RightTouch;
            ial[5] = GroupSkill;
            ial[6] = LeftHold;
            ial[7] = RightHold;
            //Console.WriteLine(ial[5]);
        }

        public Action PreviousFormation { get; set; }
        public Action NextFormation { get; set; }
        public Action Pause { get; set; }
        public Action LeftTouch { get; set; }
        public Action RightTouch { get; set; }
        public Action GroupSkill { get; set; }
        public Action LeftHold { get; set; }
        public Action RightHold { get; set; }


    }
}
