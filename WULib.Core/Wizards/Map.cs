using Google.Protobuf.Collections;
using WULib.Core.Net;

namespace WULib.Core.Wizards
{
    /// <summary>
    ///     A wrapper class for <see cref="RepeatedField{T}" />.
    /// </summary>
    public class Map
    {

        /// <summary>
        ///     The authenticated <see cref="Session" />.
        /// </summary>
        private readonly Session _session;

        // The last received map cells.
        //private RepeatedField<MapCell> _cells;

        // The last received incense Unite.
        //private MapWizards _incenseWizards;

        internal Map(Session session)
        {
            _session = session;
            //_cells = new RepeatedField<MapCell>();
        }

        /// <summary>
        ///     Gets the last received Incense Unite from UniteGo.<br />
        ///     Only use this if you Incense is active.
        /// </summary>
        /// 
        /*
        public MapWizards IncenseWizards
        {
            get { return _incenseWizards; }
            internal set
            {
                _incenseWizards = value;
            }
        }

        /// <summary>
        ///     Gets the last received <see cref="RepeatedField{MapCell}" /> from UniteGo.<br />
        ///     Only use this if you know what you are doing.
        /// </summary>
        public RepeatedField<MapCell> Cells
        {
            get { return _cells; }
            internal set
            {
                _cells = value;
                _session.OnMapUpdate();
            }
        }

        public List<FortData> GetFortsSortedByDistance(Func<FortData, bool> filter = null)
        {
            var forts = Cells.SelectMany(f => f.Forts);

            if (filter != null)
                forts = forts.Where(filter);

            var sorted = forts.ToList();
            sorted.Sort((f1, f2) =>
            {
                var f1Coordinate = new GeoCoordinate(f1.Latitude, f1.Longitude);
                var f2Coordinate = new GeoCoordinate(f2.Latitude, f2.Longitude);

                var distance1 = f1Coordinate.GetDistanceTo(_session.Player.Coordinate);
                var distance2 = f2Coordinate.GetDistanceTo(_session.Player.Coordinate);

                return distance1.CompareTo(distance2);
            });

            return sorted;
        }
        */
    }
}