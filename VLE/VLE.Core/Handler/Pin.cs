using System.ComponentModel.DataAnnotations;
using VLE.VLE.Core.Interfaces;

namespace VLE.VLE.Core.Handler
{
    // this class handles the individual pins
    public class Pin(string name, string description, DataType dataType, INode nodeParent, bool isInput) : IPin
    {
        public string Name { get; } = name;

        public string Description { get; } = description;

        public DataType DataType { get; } = dataType;

        public INode NodeParent { get; } = nodeParent;

        public bool IsInput { get; } = isInput;

        public object? Value { get; set; }
    }
}
