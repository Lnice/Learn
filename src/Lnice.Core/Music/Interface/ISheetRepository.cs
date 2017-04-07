using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace Lnice.Music.Interface
{
    public interface ISheetRepository : IRepository<SheetInfo>
    {
        List<SheetInfo> GetTopOrderByPlay(DateTime lastTime, int top = 15);
    }
}
