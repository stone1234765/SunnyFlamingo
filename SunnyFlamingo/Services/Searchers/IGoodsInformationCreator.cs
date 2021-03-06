﻿using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using SunnyFlamingo.ValueObjects.GoodsInformationSearcherFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IGoodsInformationCreator
    {
        Task<GoodsInformation<string>> CreateGoodsInformation(GoodsSelector goodsSelector, IGoodsInformationSearcherFactory goodsInformationSearcherFactory);
    }
}
