using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShittyTwitterApi.Models;

namespace ShittyTwitterApi.Data
{
    public class DbInitializer
    {
        public static void Initialize(ShittyTwitterContext context)
        {
            context.Database.EnsureCreated();
            if (context.ShittyTweets.Count() == 0)
            {
                context.ShittyTweets.Add(new ShittyTweet
                {
                    Message = "This is a shitty tweet",
                    Author = "Anonymous"
                });
                context.ShittyTweets.Add(new ShittyTweet
                {
                    Message = "This is another shitty tweet",
                    Author = "Me"
                });

                context.SaveChanges();
            }
        }
    }
}
