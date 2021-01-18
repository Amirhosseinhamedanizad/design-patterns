using System;

namespace Console1
{
    public abstract class Checkup
    {
        public long CheckupId { get; set; }
        public abstract float CalcluatePaitientBloodLevel();
        public abstract float CalculatePaitientCloestrolLevel();
    }

    public class HivCheckup: Checkup
    {
        public string TestBloodLevel { get; set; }

        public override float CalcluatePaitientBloodLevel()
        {
            throw new NotImplementedException();
        }

        //unrelated method
        public override float CalculatePaitientCloestrolLevel()
        {
            throw new NotImplementedException();
        }
    }

    public class HepatitCheckup: Checkup
    {
        public string TestClostrolLevel { get; set; }

        //unrelated method
        public override float CalcluatePaitientBloodLevel()
        {
            throw new NotImplementedException();
        }

        public override float CalculatePaitientCloestrolLevel()
        {
            throw new NotImplementedException();
        }
    }

}
