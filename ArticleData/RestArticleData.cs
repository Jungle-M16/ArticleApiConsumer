using ArticleDatabaseConnector.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ArticleApiConsumer.ArticleData
{
    public class RestArticleData : IArticleData
    {
        static readonly HttpClient client = new HttpClient();
        static readonly string url = "https://localhost:44329/api/Articles";
        Article IArticleData.GetArticle(Guid id)
        {
            throw new NotImplementedException();
        }

        async Task<List<Article>> IArticleData.GetArticles()
        {
            var result = client.GetAsync(url).Result;
            var articles = JsonConvert.DeserializeObject<List<Article>>(await result.Content.ReadAsStringAsync());
            return articles;
        }

        List<Article> IArticleData.GetArticlesByAuthor(int id)
        {
            throw new NotImplementedException();
        }

        List<Article> IArticleData.GetArticlesBySubjectType(string subject)
        {
            throw new NotImplementedException();
        }

        List<Author> IArticleData.GetAuthors()
        {
            throw new NotImplementedException();
        }
    }
}
