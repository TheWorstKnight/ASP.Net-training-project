using DataLayer.Abstract;

namespace DataLayer.Interaction
{
    public class DLEntry : IDLEntry
    {
        public IDataInteraction DataInteraction => new DataInteraction();
    }
}
