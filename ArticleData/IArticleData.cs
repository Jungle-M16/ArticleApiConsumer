using ArticleDatabaseConnector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleApiConsumer.ArticleData
{
    public interface IArticleData
    {
        Task<List<Article>> GetArticlesByAuthor(int id);
        Task<List<Article>> GetArticlesBySubjectType(string subject);
        Task<List<Article>> GetArticles();
        Task<Article> GetArticle(Guid id);
        Task<List<Author>> GetAuthors();
        Task<Article> GetLatestArticleBySubjectType(string subject);
        //Article AddArticle(Article article);

        //void DeleteArticle(Article article);

    }
}
