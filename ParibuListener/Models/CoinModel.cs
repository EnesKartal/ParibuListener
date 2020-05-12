using System.Collections.Generic;

namespace ParibuListener.Models
{
    public class CoinModel
    {
        public string Name { get; set; }
        public double lowestAsk { get; set; }
        public double highestBid { get; set; }
        public double low24hr { get; set; }
        public double high24hr { get; set; }
        public double avg24hr { get; set; }
        public double volume { get; set; }
        public double last { get; set; }
        public double change { get; set; }
        public double percentChange { get; set; }
        public IList<double> chartData { get; set; }
    }
}
