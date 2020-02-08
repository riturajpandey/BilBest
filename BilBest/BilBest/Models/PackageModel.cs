using System;
using System.Collections.Generic;
using System.Text;

namespace BilBest.Models
{
    public class PackageModel
    {
        public int Id { get; set; }
        public string PkgImage { get; set; }
        public string Title { get; set; }
        public string Amount { get; set; }
        public string AmountText { get; set; }
        public bool IsLectus { get; set; }
        public bool IsPrions { get; set; }
        public bool IsConsec { get; set; }

        public static List<PackageModel> GetPackages()
        {
            return new List<PackageModel>
        {
          new PackageModel ()
          {
             Id=1,
             PkgImage="halfcirclebluekimg.png",
             Title="Bireysel",
             Amount = "120 ₺",
             AmountText="1 yıllık kullanım",
             IsConsec=false,
             IsLectus=false,
             IsPrions=false, 
          },
          new PackageModel ()
          {
             Id=2,
             PkgImage="halfcirclepinkimg.png",
             Title="Aile",
             Amount = "450 ₺",
             AmountText="1 yıllık kullanım",
             IsConsec=false,
             IsLectus=false,
             IsPrions=false,
          },
        };
        } 
    }
    public class IndicatorModel
    {
        public bool IsCurrent { get; set; }
        public bool IsNotCurrent { get; set; }
        public string Id { get; set; }
    }
}
