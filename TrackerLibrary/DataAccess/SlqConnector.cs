using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess;

public class SlqConnector : IDataConnection
{
    public PrizeModel CreatePrize(PrizeModel prizeModel)
    {
        prizeModel.Id = 1;
        return prizeModel;
    }
}
