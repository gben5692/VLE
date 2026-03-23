using VLE.Core.Interfaces;

namespace VLE.Core.Handler
{
    public class Wire
    {
        public IPin? StartPoint { get; set; }
        public List<IPin>? EndPoints { get; set; }


        public Wire(IPin startPoint, List<IPin> endPoints) 
        {
            if (startPoint == null)  // if the enpoint and startpoint is null then you cant draw the wire
            {
                throw new ArgumentNullException(nameof(startPoint));
            }
            else if (endPoints == null)
            {
                throw new ArgumentNullException(nameof(endPoints));
            }
            else
            {
                if (endPoints.Any(endPoint => endPoint.DataType != startPoint.DataType)) // check if the startpoint and endpoint is not the same type 
                {
                    throw new InvalidOperationException("Startpoint and Endpoint is not the same type");
                }

                StartPoint = startPoint;
                EndPoints = endPoints;
            }
        }
    }
}
