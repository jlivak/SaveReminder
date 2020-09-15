using System;

namespace SaveReminderStorage
{
    [Serializable()]
    public class ProgramContainer
    {
        public string ExecutableName { get; set; }
        public int Interval { get; set; }

        public ProgramContainer(string path, int interval)
        {
            ExecutableName = path;
            Interval = interval;
        }

        public override string ToString()
        {
            return ExecutableName + " - Every " + Interval + " Minutes";
        }
    }
}