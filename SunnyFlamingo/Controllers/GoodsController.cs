﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Data;
using SunnyFlamingo.Entities;
using SunnyFlamingo.Models;
using SunnyFlamingo.Services;
using SunnyFlamingo.Services.Searchers;
using SunnyFlamingo.ValueObjects;

namespace SunnyFlamingo.Controllers
{
    [Route("api/goods")]
    [ApiController]
    public class GoodsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IAllGoodsSearcher _searcherGoods;
        public GoodsController(
            ApplicationDbContext context,
            IAllGoodsSearcher searcherGoods)
        {
            _context = context;
            _searcherGoods = searcherGoods;
        }
        [HttpGet]
        [Route("")]
        public async Task<GoodsInformation<string>> GetGoodsInformation(
            string producer = null,
            string country = null,
            string material = null,
            string color = null,
            decimal? priceFrom = null,
            decimal? priceTo = null,
            int from = 0,
            int to = 20,
            bool getQuestions = true
            )
        {
            return await _searcherGoods.SearchGoods(producer, country, material, color, priceFrom, priceTo, from, to, getQuestions);
        }
        [HttpGet]
        [Route("computerTechnologies")]
        public async Task<GoodsInformation<string>> GetComputerTechnologiesInformation(
            string producer = null,
            string country = null,
            string material = null,
            string color = null,
            decimal? priceFrom = null,
            decimal? priceTo = null,
            int from = 0,
            int to = 20,
            bool getQuestions = true
            )
        {
            return await _searcherGoods.SearchComputerTechnologies(producer, country, material, color, priceFrom, priceTo, from, to, getQuestions);
        }
        [HttpGet]
        [Route("laptops")]
        public async Task<GoodsInformation<string>> GetLaptopsInformation(
            string producer = null,
            string country = null,
            string material = null,
            string color = null,
            string amountOfRAM = null,
            string CPUFrequency = null,
            string length = null,
            string height = null,
            string width = null,
            string haveFloppyDrives = null,
            string SSDMemory = null,
            string hardDiskMemory = null,
            string CPUSocketType = null,
            string computerDriveType = null,
            string numberOfCores = null,
            string floppyDrivesCount = null,
            string display = null,
            decimal? priceFrom = null,
            decimal? priceTo = null,
            int from = 0,
            int to = 20,
            bool getQuestions = true
            )
        {
            return await _searcherGoods.SearchLaptops(
            producer,
            country,
            material,
            color,
            amountOfRAM,
            CPUFrequency,
            length,
            height,
            width,
            haveFloppyDrives,
            SSDMemory,
            hardDiskMemory,
            CPUSocketType,
            computerDriveType,
            numberOfCores,
            floppyDrivesCount,
            display,
            priceFrom,
            priceTo,
            from,
            to,
            getQuestions);
        }
        [HttpGet]
        [Route("computers")]
        public async Task<GoodsInformation<string>> GetComputersInformation(
            string producer = null,
            string country = null,
            string material = null,
            string color = null,
            string amountOfRAM = null,
            string CPUFrequency = null,
            string length = null,
            string height = null,
            string width = null,
            string haveFloppyDrives = null,
            string SSDMemory = null,
            string hardDiskMemory = null,
            string CPUSocketType = null,
            string computerDriveType = null,
            string numberOfCores = null,
            string floppyDrivesCount = null,
            decimal? priceFrom = null,
            decimal? priceTo = null,
            int from = 0,
            int to = 20,
            bool getQuestions = true
            )
        {
            return await _searcherGoods.SearchComputers(
            producer,
            country,
            material,
            color,
            amountOfRAM,
            CPUFrequency,
            length,
            height,
            width,
            haveFloppyDrives,
            SSDMemory,
            hardDiskMemory,
            CPUSocketType,
            computerDriveType,
            numberOfCores,
            floppyDrivesCount,
            priceFrom,
            priceTo,
            from,
            to,
            getQuestions);
        }
        [HttpGet]
        [Route("flashDrives")]
        public async Task<GoodsInformation<string>> GetFlashDrivesInformation(
            string producer = null,
            string country = null,
            string material = null,
            string color = null,
            string capacity = null,
            string USBSpecificationType = null,
            decimal? priceFrom = null,
            decimal? priceTo = null,
            int from = 0,
            int to = 20,
            bool getQuestions = true
            )
        {
            return await _searcherGoods.SearchFlashDrives(
            producer,
            country,
            material,
            color,
            capacity,
            USBSpecificationType,
            priceFrom,
            priceTo,
            from,
            to,
            getQuestions);
        }
        [HttpGet]
        [Route("computerParts")]
        public async Task<GoodsInformation<string>> GetComputerPartsInformation(
            string producer = null,
            string country = null,
            string material = null,
            string color = null,
            decimal? priceFrom = null,
            decimal? priceTo = null,
            int from = 0,
            int to = 20,
            bool getQuestions = true
            )
        {
            return await _searcherGoods.SearchComputerAccessories(producer, country, material, color, priceFrom, priceTo, from, to, getQuestions);
        }
        [HttpGet]
        [Route("computerAccessories")]
        public async Task<GoodsInformation<string>> GetComputerAccessoriesInformation(
            string producer = null,
            string country = null,
            string material = null,
            string color = null,
            decimal? priceFrom = null,
            decimal? priceTo = null,
            int from = 0,
            int to = 20,
            bool getQuestions = true
            )
        {
            return await _searcherGoods.SearchComputerParts(producer, country, material, color, priceFrom, priceTo, from, to, getQuestions);
        }
    }
}