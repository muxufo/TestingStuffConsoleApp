using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCodeConsoleApp
{
    public class ModelSMAT
    {
        public StatsSubscription Subscription { get; set; }
        public StatsUser StatsUser { get; set; }
    }

    public class StatsUser
    {
        public SubscriptionMode SubscriptionMode { get; set; }
        public Sexe Sexe { get; set; }
        public Age Age { get; set; }
        public AverageAge AverageAge { get; set; }
        public Other Other { get; set; }
    }

    public class StatsSubscription
    {
        public SubscriptionMode SubscriptionMode { get; set; }
        public Sexe Sexe { get; set; }
        public Age Age { get; set; }
        public AverageAge AverageAge { get; set; }
        public Other Other { get; set; }
    }

    public class SubscriptionMode
    {
        public List<Info> Infos { get; set; }
    }

    
    public class Sexe
    {
        public List<Info> Infos { get; set; }
    }

    public class Age
    {
        public List<AgeInfo> Ages { get; set; } 
        public Info Total { get; set; }
    }

    public class Other
    {
        public List<Info> Infos { get; set; }
    }

    public class Info
    {
        public string Alias { get; set; }
        public int Number { get; set; }
        public double Percentage { get; set; }
    }

    public class AgeInfo
    {
        public string Alias { get; set; }
        public int Woman { get; set; }
        public int Man { get; set; }
        public int Number { get; set; }
        public double Percentage { get; set; }
    }

    public class AverageAge
    {
        public List<AverageAgeInfo> AverageAgeInfos { get; set; }
    }

    public class AverageAgeInfo
    {
        public string Alias { get; set; }
        public double Average { get; set; }
    }




}
