//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Services
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Services()
        {
            this.ServiceClient = new HashSet<ServiceClient>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string MainImage { get; set; }
        public int Duration { get; set; }
        public int Cost { get; set; }
        public double Discount { get; set; }

        public double DiscountProcent
        {
            get
            {
                return Discount * 100;
            }
        }

        public string CostDuration
        {
            get
            {
                if (Duration > 60) Duration /= 60;
                return Cost + " за " + Duration + " минут";
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceClient> ServiceClient { get; set; }
    }
}
