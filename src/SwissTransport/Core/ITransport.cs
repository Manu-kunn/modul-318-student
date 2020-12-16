namespace SwissTransport.Core
{
    using System.Threading.Tasks;
    using System;
    using SwissTransport.Models;

    public interface ITransport
    {
        Stations GetStations(string query);

        StationBoardRoot GetStationBoard(string station, string id, DateTime datum, int limit);

        Connections GetConnections(string fromStation, string toStation, DateTime datum, DateTime time, int limit);
  }
}