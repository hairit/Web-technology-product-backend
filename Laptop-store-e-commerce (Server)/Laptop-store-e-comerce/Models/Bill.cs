﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Laptop_store_e_comerce.Models
{
    public partial class Bill
    {
        public Bill()
        {
            BillDetails = new HashSet<BillDetail>();
        }
        public string Id { get; set; }
        public string IdUser { get; set; }
        public int Tongtien { get; set; }
        public DateTime Ngaydat { get; set; }
        public string Diachinhan { get; set; }
        public string Phuongthucthanhtoan { get; set; }
        public string Tinhtrang { get; set; }

        public virtual User IdUserNavigation { get; set; }
        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
}
