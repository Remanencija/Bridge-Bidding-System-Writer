namespace Bridge_System_Writer
{
    public partial class MainWindow : Form
    {
        private Control.ControlCollection bidButtons;
        private BiddingLogic bidController;
        public MainWindow()
        {
            InitializeComponent();

            bidButtons = bidButtonsBox.Controls;
            bidController = new BiddingLogic(0, 0, false, bidButtons, buttonPass, buttonDouble, buttonRedouble);
        }

        private void bidClick(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            bidController.makeBid(senderButton.Text, biddingDisplay);
        }

        private void undoBidClick(object sender, EventArgs e)
        {

        }

        private void resetBidsClick(object sender, EventArgs e)
        {
            biddingDisplay.Rows.Clear();

            var dealer = dealerGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            int deal = dealer == "North" ? 0 : 1;

            var vulnerability = vulnGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            int vuln = 0;
            switch (vulnerability)
            {
                case "NS":
                    vuln = 1;
                    break;
                case "EW":
                    vuln = 2;
                    break;
                case "Both":
                    vuln = 3;
                    break;
                default:
                    vuln = 0;
                    break;
            }

            var zoneMattering = vulnGroupBox.Controls.OfType<CheckBox>().FirstOrDefault().Checked;

            bidController = new BiddingLogic(deal, vuln, zoneMattering, bidButtons, buttonPass, buttonDouble, buttonRedouble);
        }

        private void refocusCell(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            //this deselects the cell at any point
            e.Cell.Selected = false;
        }
    }
}