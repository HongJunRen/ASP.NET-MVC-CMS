﻿using Easy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Easy.MetaData;

namespace Easy.CMS.Common.Models
{
    [DataConfigure(typeof(CarouselEntityMetaData))]
    public class CarouselEntity : EditorEntity
    {
        public long ID { get; set; }


        public IEnumerable<CarouselItemEntity> CarouselItems { get; set; }

    }
    class CarouselEntityMetaData : DataViewMetaData<CarouselEntity>
    {
        protected override void DataConfigure()
        {
            DataTable("Carousel");
            DataConfig(m => m.ID).AsIncreasePrimaryKey();
            DataConfig(m => m.CarouselItems).Ignore();
        }

        protected override void ViewConfigure()
        {
            ViewConfig(m => m.ID).AsHidden();
            ViewConfig(m => m.CarouselItems).AsCollectionArea();
        }
    }

}