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

    }
}
