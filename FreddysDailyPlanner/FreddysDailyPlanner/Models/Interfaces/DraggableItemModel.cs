using Plugin.CloudFirestore.Attributes;

namespace FreddysDailyPlanner.Models.Interfaces
{
    public class DraggableItemModel : BaseModel
    {
        [Ignored]
        public bool isBeingDragged { get; set; }
        [Ignored]
        public bool isBeingDraggedOver { get; set; }
    }
}
