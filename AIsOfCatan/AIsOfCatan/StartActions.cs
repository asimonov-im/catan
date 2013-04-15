﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIsOfCatan
{
    public class StartActions
    {
        private Player player;
        private GameController controller;
        private bool houseBuilt = false;
        private bool roadBuilt = false;
        private int[] settlementPosition;
        public StartActions(Player player, GameController controller)
        {
            this.player = player;
            this.controller = controller;
        }

        /// <summary>
        /// Internal method used for handing out resources
        /// </summary>
        public int[] GetSettlementPosition()
        {
            return settlementPosition.ToArray();
        }

        /// <summary>
        /// IMPORTANT! May only be called once!
        /// Must be called before BuildRoad
        /// </summary>
        /// <param name="firstTile"></param>
        /// <param name="secondTile"></param>
        /// <param name="thirdTile"></param>
        /// <returns></returns>
        public bool BuildSettlement(int firstTile, int secondTile, int thirdTile)
        {
            if (houseBuilt) throw new IllegalActionException("Only one house may be built in a turn during the startup");
            settlementPosition = new int[] { firstTile, secondTile, thirdTile };

            //TODO: Implement this
            throw new NotImplementedException();
        }

        /// <summary>
        /// IMPORTANT! May only be called once!
        /// Must be called after BuildHouse
        /// </summary>
        /// <param name="firstTile"></param>
        /// <param name="secondTile"></param>
        /// <returns></returns>
        public bool BuildRoad(int firstTile, int secondTile)
        {
            if (roadBuilt) throw new IllegalActionException("Only one road may be built in a turn during the startup");
            if (!houseBuilt) throw new IllegalActionException("The house must be placed before the road");
            if (!(settlementPosition.Contains(firstTile) && settlementPosition.Contains(secondTile)))
                throw new IllegalBuildPositionException("The road must be placed next to the house");

            //TODO: Implement this
            throw new NotImplementedException();
        }
    }
}
