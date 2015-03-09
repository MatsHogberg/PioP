using PioPortal.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PioPortal.Mappers
{
    internal class MeetingMapper
    {
        internal static Meeting Map(Entities.meeting @from)
        {
            return new Meeting
                {
                    Id = @from.meeting_Id,
                    RoomId = @from.room.room_Id,
                    RoomName = @from.room.caption,
                    Site = SiteMapper.Map(@from.room.site),
                    StartTime = @from.starttime,
                    TypeId = @from.meetingtype.meetingtype_Id,
                    TypeName = @from.meetingtype.caption
                };
        }

        internal static List<Meeting> Map(IEnumerable<Entities.meeting> @from)
        {
            return @from.Select(Map).ToList();
        }
    }
}
