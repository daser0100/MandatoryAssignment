using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IT.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Context(
                serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
            {
                if (!context.About.Any())
                {
                    context.About.AddRange(
                         new About
                         {
                             Section = "When Harry Met Sally"
                         },

                         new About
                         {
                             Section = "He fell madly in love."
                         },

                         new About
                         {
                             Section = "And he killed her..."
                         },

                         new About
                         {
                             Section = "The End!"
                         }
                    );
                    context.SaveChanges();
                }
                if (!context.Gallery.Any())
                {
                    context.Gallery.AddRange(
                         new Gallery
                         {
                             Title = "Image1",
                             Url = "https://www.top13.net/wp-content/uploads/2015/10/perfectly-timed-cat-photos-funny-cover.jpg",
                             Description = "Hello Human don't mind me..."
                         },
                         new Gallery
                         {
                             Title = "Image2",
                             Url = "https://s1-ssl.dmcdn.net/Sp5Gv/1280x720-l9x.jpg",
                             Description = "Plz don't kill me"
                         },
                         new Gallery
                         {
                             Title = "Image3",
                             Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTG4slsoTvnkU87_s3Sd-CZlM5RyqO6H9eeC_Z12TL5GjN4I-avSA",
                             Description = ""
                         },
                         new Gallery
                         {
                             Title = "Image4",
                             Url = "https://vignette.wikia.nocookie.net/animal-jam-clans-1/images/e/ef/Top-30-Funny-Cat-Memes-Hilarious.jpg/revision/latest?cb=20161204193902",
                             Description = ""
                         },
                         new Gallery
                         {
                             Title = "Image5",
                             Url = "https://i.chzbgr.com/full/9013919744/h58F020A6/",
                             Description = ""
                         },
                         new Gallery
                         {
                             Title = "Image6",
                             Url = "https://www.clipweekend.com/image/funny-cats-203-05.jpg",
                             Description = "I'm like water... Deal with it!"
                         },
                         new Gallery
                         {
                             Title = "Image7",
                             Url = "http://ontariopets.ca/wp-content/uploads/2016/02/funnypet.jpg",
                             Description = "OMG O.o HELP!!!"
                         },
                         new Gallery
                         {
                             Title = "Image8",
                             Url = "https://boygeniusreport.files.wordpress.com/2016/05/scared-surprised-cat-face.jpg",
                             Description = "OMG... you still looking at the gallery?"
                         }
                    );
                    context.SaveChanges();
                }

            }
        }
    }
}
