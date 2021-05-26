using Conduit.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conduit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Article> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Article
            {
                Slug = "test-article",
                Title = "Test Article",
                Description = "Description",
                Body = "Body",
                TagList = new List<string>() { "a-tag" },
                CreatedAt = DateTime.Now.AddDays(-10),
                UpdatedAt = DateTime.Now.AddDays(-1),
                Favorited = false,
                FavoritesCount = 100,
                Author = new Author()
                {
                    Username = "jimbob",
                    Bio = "I like turtles.",
                    Image = "https://cats.depersio.net/square",
                    Following = true
                }
            })
            .ToArray();
        }
    }
}
