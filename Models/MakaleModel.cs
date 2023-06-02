﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class MakaleModel
    {
        public int Id { get; set; }
        public string KullanıcıAd { get; set; }

        public string Baslik { get; set; }
        public string Resim { get; set; }
        public string Acıklama { get; set; }
        public DateTime YayinTarih { get; set; }

        public int Goruntulenme { get; set; }
        public bool Onay { get; set; }
        public string KategoriAd { get; set; }
        public virtual ICollection<Yorum> yorum { get; set; }
    }
}