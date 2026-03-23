using System.ComponentModel.DataAnnotations;
using VLE.Core.enums;
using VLE.Core.Handler;
using VLE.Core.Interfaces;

namespace VLE.Nodes.Math
{
    internal class Addition : INode
    {
        public string Name => "Addition";

        public string Description => "Adding values togheter and returns the result";

        public DataType DataType => DataType.Currency;

        public Types Type => Types.Math;

        public List<IPin> Inputs { get; }

        public List<IPin> Outputs { get; }

        public Addition()
        {
            Inputs = new List<IPin>
            {
                new Pin("value a", "the first value to add", DataType.Currency, this, true),
                new Pin("value b", "the second value to add", DataType.Currency, this, true)
            };

            Outputs = new List<IPin>
            {
                new Pin("summary", "the summary of value a and b", DataType.Currency, this, false)
            };
        }

        public void Execute()
        {
            int summary = 0;

            foreach (var input in Inputs)
            {
                summary += (int)input.Value;
            }

            Outputs.First().Value = summary;
        }
    }
}
