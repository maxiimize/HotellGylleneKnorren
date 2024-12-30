using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotellGylleneKnorren.Modelling
{
    internal class Room
    {
        public int RoomId { get; set; }
        public string RoomType { get; set; }
        public int MaxExtraBeds { get; set; }
        public bool IsAvailable { get; set; }
    }
}
