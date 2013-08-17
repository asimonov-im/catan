﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIsOfCatan
{
    public enum TradeStatus {Declined, Countered};

    public class Trade : ITrade
    {
        // For a Wildcard put several Resource in the same inner list.
        public List<List<Resource>> Give { get; private set; }
        public List<List<Resource>> Take { get; private set; }
        public TradeStatus Status { get; private set; }

        public Trade(List<List<Resource>> give, List<List<Resource>> take){
            this.Give = give;
            this.Take = take;
            Status = TradeStatus.Declined;
        }

        public static Trade Decline()
        {
            Trade t = new Trade(null,null);
            t.Status = TradeStatus.Declined;
            return t;
        }

        public Trade Reverse()
        {
            return new Trade(DeepClone(Take),DeepClone(Give)) {Status = Status};
        }

        private static List<List<Resource>> DeepClone(List<List<Resource>> list)
        {
            var result = new List<List<Resource>>(list.Count);
            result.AddRange(list.Select(l => new List<Resource>(l)));
            return result;
        }
    }
}
