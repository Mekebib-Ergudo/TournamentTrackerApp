using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess;
public class TextConnector : IDataConnection
{
    public PrizeModel CreatePrize(PrizeModel prizeModel)
    {
        prizeModel.Id = 1;
        return prizeModel;
    }
}
