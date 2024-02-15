using KaskataDDD.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaskataDDD.Domain.Interface.IterfaceService
{
    internal interface IServiceNews
    {

        Task CreateNews(News news);
        Task UpgradeNews(News news);
        Task<List<News>> ListNews();

    }
}
