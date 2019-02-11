using BusinessLayer.Abstract;
using DataLayer.Interaction;

namespace BusinessLayer.Interaction
{
    public class BLEntry : IBLEntry
    {
        public IBusinessInteraction BusinessInteraction => new BusinessInteraction(new DLEntry());
    }
}
