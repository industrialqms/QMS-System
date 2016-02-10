﻿using QMS.Models;
using QMS.Web.Infrastructure.Mappings;

namespace QMS.Web.Models.Areas
{
    public class AreaShortModel : IMapFrom<Area>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
