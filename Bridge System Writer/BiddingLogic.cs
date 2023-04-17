using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Bridge_System_Writer
{
    internal class BiddingLogic
    {
        //public string currentFilePath;
        private int currentBidder; //0N 1E 2S 3W
        private int biddingRounds;
        private int zones;         //0None 1NS 2EW 3Both
        private bool zonesMatter;  //False - zones don't matter - write to all nodes
        private List<Bids> bids;
        private Control.ControlCollection buttons;

        public BiddingLogic(int currBidder,int zone, bool zoneMatter, Control.ControlCollection bidButtons)
        {
            biddingRounds = 0;
            currentBidder = currBidder;
            zones = zone;
            zonesMatter = zoneMatter;
            buttons = bidButtons;
        }

        public void makeBid(string bid, DataGridView bidGrid)
        {
            bidGrid.Rows[biddingRounds].Cells[currentBidder].Value = bid;

            if (currentBidder == 3)
            {
                currentBidder = 0;
                biddingRounds++;
                bidGrid.NotifyCurrentCellDirty(true);
                bidGrid.Rows.Insert(bidGrid.Rows.Count - 1);
            }
            else
            {
                currentBidder++;
            }

            disableButtons(bid);
        }

        public void disableButtons(string currentBid)
        {
            Button[] actualButtons = new Button[35];

            int counter = 0;

            foreach (Button bidButton in buttons)
            {
                actualButtons[counter] = bidButton;
                counter++;
            }

            int whereToStop = 0;

            foreach (Button b in actualButtons)
            {
                if (b.Text == currentBid)
                {
                    whereToStop = b.TabIndex;
                }
            }

            foreach(Button b in actualButtons)
            {
                if (b.TabIndex <= whereToStop)
                {
                    b.Enabled = false;
                }
            }
        }

    }
}
