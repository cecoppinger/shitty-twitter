using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShittyTwitterApi.Models;

namespace ShittyTwitterApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShittyTweetsController : ControllerBase
    {
        private readonly ShittyTwitterContext _context;

        public ShittyTweetsController(ShittyTwitterContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ShittyTweet>> GetShittyTweets()
        {
            return _context.ShittyTweets.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<ShittyTweet> GetShittyTweet(int id)
        {
            var shittyTweet = _context.ShittyTweets.Find(id);

            if(shittyTweet == null)
            {
                return NotFound();
            }

            return shittyTweet;
        }

        [HttpPost]
        public ActionResult<ShittyTweet> PostShittyTweet(ShittyTweet tweet)
        {
            _context.ShittyTweets.Add(tweet);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetShittyTweet), new { id = tweet.ID }, tweet);
        }

        [HttpPut("{id}")]
        public IActionResult EditShittyTweet(int? id, ShittyTweet tweet)
        {
            if(id != tweet.ID)
            {
                return BadRequest();
            }

            _context.Entry(tweet).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteShittyTweet(int id)
        {
            var tweet = _context.ShittyTweets.Find(id);

            if(tweet == null)
            {
                return NotFound();
            }

            _context.ShittyTweets.Remove(tweet);
            _context.SaveChanges();

            return NoContent();
        }
    }
}