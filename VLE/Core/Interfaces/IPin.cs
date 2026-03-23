using System.ComponentModel.DataAnnotations;


namespace VLE.Core.Interfaces
{
    public interface IPin
    {
        public string Name { get; } // the name of the pin

        public string Description { get; } // the description of what the pin needs or does

        public DataType DataType { get; } // the datatype of the pin

        public INode NodeParent { get; } // the parent of the pin which is a node

        public bool IsInput { get; } // if it is an input or output

        public object Value { get; set;  } // store and change
    }
}
