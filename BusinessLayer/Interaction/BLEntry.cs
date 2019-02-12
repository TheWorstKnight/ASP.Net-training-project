using BusinessLayer.Abstract;
using DataLayer.Abstract;

namespace BusinessLayer.Interaction
{
    public class BLEntry : IBLEntry
    {
        private IDLEntry _bLEntry;
        public BLEntry(IDLEntry bLEntry)
        {
            _bLEntry = bLEntry;
        }

        public IBusinessInteraction BusinessInteraction => new BusinessInteraction(_bLEntry);
    }
}
