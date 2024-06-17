using TrackerLibrary.DataAccess;

namespace TrackerLibrary;

public static class GlobalConfig
{
    public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
    public static void InitializeConnections(bool database, bool textFiles)
    {
        if (database == true)
        {
            // TODO create the sql connection
       SlqConnector sql = new SlqConnector();
            Connections.Add(sql);
        }
        if (textFiles == true)
        {
            // TODO Create file connection
            TextConnector textConnector = new TextConnector();
            Connections.Add (textConnector);
        }
    }
}
