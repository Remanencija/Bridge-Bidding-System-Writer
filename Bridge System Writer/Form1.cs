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
    }
}