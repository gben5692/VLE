using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VLE.VLE.Core.enums;
using VLE.VLE.Core.Handler;
using VLE.VLE.Core.Interfaces;

namespace VLE.VLE.Nodes.Math
{
    internal class Subtraction : INode
    {

        public string Name => "Subtraction";

        public string Description => "Subtracts values and returns the result";

        public DataType DataType => DataType.Currency;

        public Types Type => Types.Math;

        public List<IPin> Inputs { get; }

        public List<IPin> Outputs { get; }

        public Subtraction()
        {
            Inputs =
            [
                new Pin("value a", "the first value to subtract", DataType.Currency, this, true),
                new Pin("value b", "the second value to subtract", DataType.Currency, this, true)
            ];

            Outputs =
            [
                new Pin("summary", "the summary of value a - value b", DataType.Currency, this, false)
            ];
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
