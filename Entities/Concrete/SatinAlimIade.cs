﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SatinAlimIade:IEntity
    {
        public int SatinAlimIadeId { get; set; }
        public int ToptanciId { get; set; }
        public DateTime Tarih { get; set; }
    }
}
