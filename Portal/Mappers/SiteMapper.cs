using PioPortal.ViewModels;

namespace PioPortal.Mappers
{
    internal class SiteMapper
    {
        internal static Site Map(Entities.site @from)
        {
            return new Site
                {
                    Id = @from.site_Id,
                    Name = @from.caption
                };
        }
    }
}
