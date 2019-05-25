using System.Collections.Generic;
using Google.Protobuf.Collections;
using WULib.Core.Net;
using WUProtos.Inventory;

namespace WULib.Core.Wizards
{
    /// <summary>
    ///     A wrapper class for <see cref="Inventory" />.
    /// </summary>
    public class Inventory
    {
        private readonly Session _session;

        //internal long LastInventoryTimestampMs;

        public Inventory(Session session)
        {
            _session = session;
        }

        /// <summary>
        ///     Gets the last received <see cref="RepeatedField{T}" /> from UniteGo.<br />
        ///     Only use this if you know what you are doing.
        /// </summary>
        public RepeatedField<AtlasInventoryItem> InventoryItems { get; } = new RepeatedField<AtlasInventoryItem>();

        internal void RemoveInventoryItems(IEnumerable<AtlasInventoryItem> items)
        {
            foreach (var item in items)
            {
                InventoryItems.Remove(item);
            }
        }

        internal void UpdateInventoryItems(AtlasInventoryItem delta)
        {
            if (delta != null)
                InventoryItems.Add(delta);
        }
    }
}