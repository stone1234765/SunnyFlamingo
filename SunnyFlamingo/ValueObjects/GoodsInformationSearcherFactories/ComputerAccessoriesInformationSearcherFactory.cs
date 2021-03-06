﻿using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using SunnyFlamingo.Services.Cache;
using SunnyFlamingo.Services.Searchers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.ValueObjects.GoodsInformationSearcherFactories
{
    public class ComputerAccessoriesInformationSearcherFactory : IGoodsInformationSearcherFactory
    {
        private readonly IGoodsInformationSearcher _goodsInformationSearcher;
        private readonly IGoodCellsSearcher _goodCellsSearcher;
        private readonly ICacheKeyCreator _keyCreator;
        private readonly ComputerAccessoriesSelector _computerAccessoriesSelector;
        public ComputerAccessoriesInformationSearcherFactory(IGoodsInformationSearcher goodsInformationSearcher,
            IGoodCellsSearcher goodCellsSearcher,
            ICacheKeyCreator keyCreator,
            ComputerAccessoriesSelector computerAccessoriesSelector)
        {
            _goodsInformationSearcher = goodsInformationSearcher;
            _goodCellsSearcher = goodCellsSearcher;
            _keyCreator = keyCreator;
            _computerAccessoriesSelector = computerAccessoriesSelector;
        }
        public async Task<GoodsInformation<string>> SearchGoodsInformation()
        {
            return await _goodsInformationSearcher.SearchComputerAccessoriesInformation(_computerAccessoriesSelector);
        }
        public async Task<List<GoodCellModel>> SearchGoodCells()
        {
            return await _goodCellsSearcher.SearchComputerAccessoriesGoodCells(_computerAccessoriesSelector);
        }
        public string GetKey()
        {
            return _keyCreator.CreateGoodsInformationKey(typeof(ComputerAccessory));
        }
    }
}
