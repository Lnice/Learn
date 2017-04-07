using System.Collections.Generic;
using Abp.EntityFramework;
using Lnice.Music;
using Lnice.Music.Interface;
using System.Linq;
using System;

namespace Lnice.EntityFramework.Repositories.Music
{
    public class SheetRepository : LniceRepositoryBase<SheetInfo>, ISheetRepository
    {
        public SheetRepository(IDbContextProvider<LniceDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public List<SheetInfo> GetTopOrderByPlay(DateTime lastTime, int top = 15)
        {
            var query = GetAll();
            query = query.Where(sheet => sheet.CreationTime > lastTime);

            return query.OrderByDescending(sheet => sheet.PlayCount)
                .Take(top)
                .ToList();
        }
    }
}
