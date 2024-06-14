using TrackerLibrary;

namespace TrackerUI;

public partial class CreatePrizeForm : Form
{
    public CreatePrizeForm()
    {
        InitializeComponent();
    }
    private void CreatePrizebutton_Click(object sender, EventArgs e)
    {
        if (ValidateForm())
        {
            PrizeModel prizeModel = new PrizeModel
            {
                PlaceName = PlaceNametextBox.Text,
                PlaceNumber = int.Parse(PlaceNumberTextBox.Text),
                PrizePercentage = double.Parse(PrizePercentagetextBox.Text),
                PrizeAmount = decimal.Parse(PlaceAmounttextBox.Text)
            };
            foreach (IDataConnection db in GlobalConfig.Connections)
            {
                db.CreatePrize(prizeModel);
            }
            PlaceAmounttextBox.Text = "0";
            PlaceNametextBox.Text = "";
            PlaceNumberTextBox.Text = "";
            PrizePercentagetextBox.Text = "0";
        }
        else
        {
            MessageBox.Show("Please Fill The Form Before Submited it!!");
        }
    }
    private bool ValidateForm()
    {
        bool output = true;
        int placeNumber = 0;
        bool validPlaceNumber = int.TryParse(PlaceNumberTextBox.Text, out placeNumber);
        if (validPlaceNumber == false)
            output = false;
        if (placeNumber < 1) 
            output = false;
        if (PlaceNametextBox.Text.Length == 0)
            output = false;
        decimal prizeAmount = 0;
        int prizePercentage = 0;
        bool validPriceAmount = decimal.TryParse(PlaceAmounttextBox.Text, out prizeAmount);
        bool validPrizePercentage = int.TryParse(PrizePercentagetextBox.Text, out prizePercentage);

        if(validPriceAmount == false || validPrizePercentage == false)
            output = false;
        if (prizeAmount <= 0 && prizePercentage <= 0)
            output = false;
        if(prizePercentage < 0 || prizePercentage > 100)
            output = false;

        return output;
    }
}
