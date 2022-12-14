using Híroldal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Híroldal.Controllers
{
    [ApiController]
    public class Api : ControllerBase
    {
        [HttpGet]
        [Route("api/all")]
        public IActionResult GetAll()
        {
            ArticleContext context = new();
            var cikkek = from a in context.Articles
                         join c in context.Columns on a.ColumnId equals c.ColumnId
                         select new
                         {
                             id = a.ArticleId,
                             title = a.Title,
                             column = c.Name
                         };
            return Ok(cikkek);
        }
        [HttpGet]
        [Route("api/article/{id}")]
        public IActionResult GetArticle(int id)
        {
            ArticleContext context = new();
            var cikkek = from a in context.Articles
                         join c in context.Columns on a.ColumnId equals c.ColumnId
                         where a.ArticleId == id
                         select new
                         {
                             id = a.ArticleId,
                             title = a.Title,
                             column = c.Name,
                             text = a.Text
                         };
            return Ok(cikkek.FirstOrDefault());
        }
    }
}
