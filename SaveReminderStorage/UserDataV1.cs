using System;
using System.Collections.Generic;

namespace SaveReminderStorage
{
    [Serializable()]
    public class UserDataV1
    {
        public List<ProgramContainer> Programs = new List<ProgramContainer>();
        public int DataVersion = 1;
    }
}