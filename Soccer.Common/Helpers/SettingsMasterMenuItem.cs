using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer.Common.Helpers
{

    public class SettingsMasterMenuItem
    {
        public SettingsMasterMenuItem()
        {
            TargetType = typeof(SettingsMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}