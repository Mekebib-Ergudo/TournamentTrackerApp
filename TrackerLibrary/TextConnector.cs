namespace TrackerLibrary;
public class TextConnector : IDataConnection
{
    public PrizeModel CreatePrize(PrizeModel prizeModel)
    {
        prizeModel.Id = 1;
        return prizeModel;
    }
}
