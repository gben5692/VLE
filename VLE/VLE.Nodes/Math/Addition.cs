using System.ComponentModel.DataAnnotations;
using VLE.VLE.Core.enums;
using VLE.VLE.Core.Interfaces;

namespace VLE.VLE.Nodes.Math
{
    internal class Addition : INode
    {
        public string Name => "Addition";

        public string Description => "Adding to values togheter and returns the result a + b = c";

        public DataType DataType => DataType.Currency;

        public Types Type => Types.Math;

        public List<IPin> Inputs => [];

        public List<IPin> Outputs => [];
    }
}
