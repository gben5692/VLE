using System.ComponentModel.DataAnnotations;
using VLE.Core.enums;

namespace VLE.Core.Interfaces
{
    public interface INode
    {
        public string Name { get; } // the name of the node

        public string Description { get; } // the description of the Node

        public DataType DataType { get; } // data type of the node Int float etc

        public Types Type { get; } // if it is math or whatever

        public List<IPin> Inputs { get; } // list of inputs
         
        public List<IPin> Outputs { get; } // list of outputs

        public void Execute(); // this will be called when the node is getting executed
    }
}
