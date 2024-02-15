using KaskataDDD.Domain.Interface;
using KaskataDDD.Domain.Interface.Generics;
using KaskataDDD.Domain.Interface.IterfaceService;
using KaskataDDD.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaskataDDD.Domain.Services
{
    public class ServiceNews : IServiceNews
    {
        private readonly INews _INews;

        public ServiceNews(INews INews)
        {
            _INews = INews;
        }

        public async Task CreateNews(News news)
        {
            var validateTitle = news.ValidatPropertyString(news.Title, "Title");
            var validateDescription = news.ValidatPropertyString(news.Description, "Description");

            if (validateTitle && validateDescription)
            {
                news.CreatedDate = DateTime.Now;
                news.UpdatedDate = DateTime.Now;
                news.Status = true;
                await _INews.Create(news);

            }
            
        }

        public async Task UpgradeNews(News news)
        {
            throw new NotImplementedException();
        }

        public async Task<List<News>> ListNews()
        {
            throw new NotImplementedException();
        }
    }
}
