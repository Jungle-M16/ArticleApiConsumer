using ArticleDatabaseConnector.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ArticleApiConsumer.ArticleData
{
    /*
        GET
        ​/api​/Articles​/GetAuthors
        XXGET
        XX​/api​/Articles
        GET
        ​/api​/Articles​/GetArticle​/{id}
        GET
        ​/api​/Articles​/GetArticlesByAuthor​/{id}
        GET
        ​/api​/Articles​/GetArticlesBySubjectType​/{subject}
     
     */

    public class RestArticleData : IArticleData
    {
        static readonly HttpClient client = new HttpClient();
        //Hardcode Url to match the port from the launch settings on the DB connector. Would use settings for this but bleh.  
        static readonly string url = "https://localhost:44329/api";
        async Task<Article> IArticleData.GetArticle(Guid id)
        {
            var result = client.GetAsync($"{url}/Articles/GetArticle/{id}").Result;
            var article = JsonConvert.DeserializeObject<Article>(await result.Content.ReadAsStringAsync());
            return article;
        }

        async Task<List<Article>> IArticleData.GetArticles()
        {
            var result = client.GetAsync($"{url}/Articles").Result;
            var articles = JsonConvert.DeserializeObject<List<Article>>(await result.Content.ReadAsStringAsync());
            return articles;
        }

        async Task<List<Article>> IArticleData.GetArticlesByAuthor(int id)
        {
            var result = client.GetAsync($"{url}/Articles/GetArticlesByAuthor/{id}").Result;
            var articles = JsonConvert.DeserializeObject<List<Article>>(await result.Content.ReadAsStringAsync());
            return articles;
        }

        async Task<List<Article>> IArticleData.GetArticlesBySubjectType(string subject)
        {
            var result = client.GetAsync($"{url}/Articles/GetArticlesBySubjectType/{subject}").Result;
            var articles = JsonConvert.DeserializeObject<List<Article>>(await result.Content.ReadAsStringAsync());
            return articles;
        }
        async Task<Article> IArticleData.GetLatestArticleBySubjectType(string subject)
        {
            var result = client.GetAsync($"{url}/Articles/GetLatestArticleBySubjectType/{subject}").Result;
            var article = JsonConvert.DeserializeObject<Article>(await result.Content.ReadAsStringAsync());
            return article;
        }

        async Task<List<Author>> IArticleData.GetAuthors()
        {
            var result = client.GetAsync($"{url}/Authors").Result;
            var authors = JsonConvert.DeserializeObject<List<Author>>(await result.Content.ReadAsStringAsync());
            return authors;
        }
    }
}
