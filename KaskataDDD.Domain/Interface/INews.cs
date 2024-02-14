using KaskataDDD.Domain.Interface.Generics;
using KaskataDDD.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KaskataDDD.Domain.Interface
{
    internal interface INews : IGenerics<News>
    {
        Task<List<News>> ListNews(Expression<Func<News, Boolean>> expressionNews);
    }
}
