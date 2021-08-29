using ArticleDatabaseConnector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleApiConsumer.ArticleData
{
    public interface IArticleData
    {
        List<Article> GetArticlesByAuthor(int id);
        List<Article> GetArticlesBySubjectType(string subject);
        List<Article> GetArticles();
        Article GetArticle(Guid id);
        List<Author> GetAuthors();
        //Article AddArticle(Article article);

        //void DeleteArticle(Article article);

    }
}
