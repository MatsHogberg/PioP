using PioPortal.ViewModels;

namespace PioPortal.Mappers
{
    internal class ManagerMapper
    {
        public static Manager Map(Entities.person @from)
        {
            return @from != null
                       ? new Manager
                           {
                               Id = @from.person_id,
                               Name = string.Format("{0} {1}", @from.name_first, @from.name_last)
                           }
                       : null;
        }
    }
}
