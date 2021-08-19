using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace uygulama.Entity
{
    public class DataContext:DbContext
    {
        public DataContext(): base("data")
        {
            
        }



        public DbSet<IhaleBilgileri> ıhaleBilgileris { get; set; }
        public DbSet<KategoriBilgileri> kategoriBilgileris { get; set; }
       

        public DbSet<TeklifBilgileri> teklifBilgileris { get; set; }
        public DbSet<KabulEdilenTeklifBilgi> kabulEdilenTeklifBilgis { get; set; }
        



    }
}