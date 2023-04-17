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
        //private List<Bids> bids;


        private Button[] buttons;
        private Button passBut;
        private int passCount;
        private Button doubleBut;
        private bool lastBidDouble;
        private Button redoubleBut;
        private bool lastBidRedouble;

        public BiddingLogic(int currBidder,int zone, bool zoneMatter, Control.ControlCollection bidButtons, Button passButton, Button doubleButton, Button redoubleButton)
        {
            biddingRounds = 0;
            currentBidder = currBidder;
            zones = zone;
            zonesMatter = zoneMatter;
            passBut = passButton;
            passCount = 0;
            doubleBut = doubleButton;
            lastBidDouble = false;
            redoubleBut = redoubleButton;
            lastBidRedouble = false;

            buttons = new Button[35];

            foreach (Button but in bidButtons)
            {
                buttons[but.TabIndex] = but;
            }
        }

        public void makeBid(string bid, DataGridView bidGrid)
        {
            if (bid == "Pass" && passCount == 2)
            {
                return;
            }

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
            switch (currentBid)
            {
                case "Pass":
                    passCount++;
                    switch (passCount)
                    {
                        case 1:
                            doubleBut.Enabled = false;
                            redoubleBut.Enabled = false;
                            break;
                        case 2:
                            if (lastBidDouble)
                            {
                                doubleBut.Enabled = false;
                                redoubleBut.Enabled = true;
                            }
                            else if (lastBidRedouble)
                            {
                                doubleBut.Enabled = false;
                                redoubleBut.Enabled = false;
                            }
                            else
                            {
                                doubleBut.Enabled = true;
                                redoubleBut.Enabled = false;
                            }
                            break;
                        default:
                            break;
                    }
                    break;

                case "X":
                    lastBidDouble = true;
                    lastBidRedouble = false;
                    passCount = 0;
                    doubleBut.Enabled = false;
                    redoubleBut.Enabled = true;
                    break;

                case "XX":
                    lastBidDouble = false;
                    lastBidRedouble = true;
                    passCount = 0;
                    doubleBut.Enabled = false;
                    redoubleBut.Enabled = false;
                    break;

                default:
                    lastBidDouble = false;
                    lastBidRedouble = false;
                    passCount = 0;
                    doubleBut.Enabled = true;
                    redoubleBut.Enabled = false;

                    foreach (Button b in buttons)
                    {
                        b.Enabled = false;
                        if (b.Text == currentBid)
                        {
                            break;
                        }
                    }
                    break;
            }
        }
    }
}
