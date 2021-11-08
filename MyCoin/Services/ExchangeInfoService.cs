﻿using MyCoin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyCoin.Services
{
    public class ExchangeInfoService : IBinanceReq<BinanceReqExchangeBody>
    {
        public string BaseUrl { get; } = "https://api.binance.com/api/v3/exchangeInfo";
        string IBinanceReq<BinanceReqExchangeBody>.BaseUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public BinanceReqExchangeBody Result(string param = null)
        {
            HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage result = client.GetAsync(new Uri(BaseUrl)).Result;
                if (result.StatusCode != HttpStatusCode.OK)
                    throw new Exception($"İstek başarısız: {result.StatusCode}");

                BinanceReqExchangeBody body =
                    JsonConvert.DeserializeObject<BinanceReqExchangeBody>(result.Content.ReadAsStringAsync().Result);
                return body;
            }
            catch
            {
                throw;
            }
        }

    }
}

