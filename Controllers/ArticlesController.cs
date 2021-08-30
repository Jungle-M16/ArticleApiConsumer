using ArticleApiConsumer.ArticleData;
using ArticleDatabaseConnector.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ArticleApiConsumer.Controllers
{


    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private IArticleData _articleData;
        public ArticlesController(IArticleData articleData)
        {
            _articleData = articleData;
        }

        // GET: api/<ArticlesController>
        [HttpGet]
        [Route("api/[controller]/GetArticles")]
        public IActionResult GetArticles()
        {
            return Ok(_articleData.GetArticles());
        }
        [HttpGet]
        [Route("api/[controller]/GetAuthors")]
        public IActionResult GetAuthors()
        {
            return Ok(_articleData.GetAuthors());
        }
        [HttpGet]
        [Route("api/[controller]/GetArticle/{id}")]
        public IActionResult GetArticle(Guid id)
        {
            var article = _articleData.GetArticle(id);
            if (article != null)
            {
                return Ok(article);
            }
            return NotFound($"The Article with Id: {id} was not found");
        }
        [HttpGet]
        [Route("api/[controller]/GetArticlesByAuthor/{id}")]
        public IActionResult GetArticlesByAuthorId(int id)
        {
            var articles = _articleData.GetArticlesByAuthor(id);

            if (articles != null)
            {
                return Ok(articles);
            }
            return NotFound($"The Author with Id: {id} was not found");
        }
        [HttpGet]
        [Route("api/[controller]/GetArticlesBySubjectType/{subject}")]
        public IActionResult GetArticlesBySubjctType(string subject)
        {
            var articles = _articleData.GetArticlesBySubjectType(subject);

            if (articles != null)
            {
                return Ok(articles);
            }
            return NotFound($"The Article with subject: {subject} was not found");
        }
        [HttpGet]
        [Route("api/[controller]/GetLatestArticleBySubjectType/{subject}")]
        public IActionResult GetLatestArticleBySubjctType(string subject)
        {
            var article = _articleData.GetLatestArticleBySubjectType(subject);

            if (article != null)
            {
                return Ok(article);
            }
            return NotFound($"The Article with subject: {subject} was not found");
        }

    }
}
