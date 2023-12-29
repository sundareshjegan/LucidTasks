namespace StudentDetails
{
    public class Student
    {
        private const int totalMark = 400;
        private const int failRange = 50;

        private int computerMark;

        //these properties are used within this class
        public float Percentage { get; private set; }
        public int TotalScored { get; private set; }
        public float CutOff { get; private set; }
        public bool IsFail { get; private set; }

        //get and set for each propoerties
        public int ID { get; set; }
        public string Name { get; set; }
        public int MathsMark { get; set; }
        public int PhysicsMark { get; set; }
        public int ChemistryMark { get; set; }     
        public int Rank { get; set; }     
        
        public int ComputerMark
        {
            get => computerMark;
            set
            {
                computerMark = value;
                totalCalculate();
                percentageCalculate();
                cutoffCalculate();
                checkFail();
            }
        }
        

        //functions for calculations
        private void totalCalculate()
        {
            TotalScored = MathsMark + PhysicsMark + ChemistryMark + ComputerMark;
        }
        private void percentageCalculate()
        {
            Percentage = (float)TotalScored / totalMark * 100;
        }
        private void cutoffCalculate()
        {
            CutOff = (MathsMark) + (float)((PhysicsMark + ChemistryMark) / 2);
        }
        private void checkFail()
        {
            if(MathsMark < failRange || PhysicsMark < failRange || ChemistryMark < failRange || ComputerMark < failRange)
            {
                IsFail = true;
            }
            else
            {
                IsFail = false;
            }
        }
    }
}
