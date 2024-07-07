using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMAS.BusinessLayer
{
    internal class Illness
    {
        private int IllnessId { get; set; }
        private string IllnessName { get; set; }

        public Illness(int illnessId, string illnessName)
        {
            illnessId = IllnessId;
            illnessName = IllnessName;
        }
    }
}
