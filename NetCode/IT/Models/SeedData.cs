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
                             Section = "•  Smoking is not allowed in the kitchen."
                         },

                         new About
                         {
                             Section = "•  He/she who has the weekly kitchen duty (currently written on the colorful paper on the door) has to:"
                         },

                         new About
                         {
                             Section = "  ◦  Take cardboard and glass from the hallway to the recycling containers at the parking lot."
                         },

                         new About
                         {
                             Section = "  ◦  Wash the (dish) towels. (Put the amount on the shopping list)"
                         },

                         new About
                         {
                             Section = "  ◦  Clean the microwave oven"
                         },

                         new About
                         {
                             Section = "  ◦  Descale the kettle."
                         },

                         new About
                         {
                             Section = "•  When using the kitchen:"
                         },

                         new About
                         {
                             Section = "  ◦  Never use metal tools on the pans since it ruins their surface."
                         },

                         new About
                         {
                             Section = "  ◦  Do not apply cold water to warm pans since it bends them."
                         },

                         new About
                         {
                             Section = "•  After using the kitchen:"
                         },

                         new About
                         {
                             Section = "  ◦  Clean the stove and the sink."
                         },

                         new About
                         {
                             Section = "  ◦  Wipe of the tables."
                         },

                         new About
                         {
                             Section = "  ◦  Clean whatever service you have used."
                         },

                         new About
                         {
                             Section = "  ◦  Empty the bins if they are full or close to and dump them in the waste shaft."
                         },

                         new About
                         {
                             Section = "•  Accountings:"
                         },

                         new About
                         {
                             Section = "  ◦  Please pay what you owe the Kitchen box."
                         },

                         new About
                         {
                             Section = "  ◦  Bank transfers are preferred as the accountant can see your payment on his bank account, and this practically eliminates mistakes."
                         },

                         new About
                         {
                             Section = "  ◦  Payments in cash are possible, but is usually only accepted for foreign students, who have a large fee on bank transfers."
                         },

                         new About
                         {
                             Section = "  ◦  Instead of transferring money, you can also buy groceries etc."
                         },

                         new About
                         {
                             Section = "  ◦  A good advice is to setup an automatic monthly bank transfer, in that way you avoid getting i minus."
                         },

                         new About
                         {
                             Section = "  ◦  You can always contact the accountant if you have questions, complaints or wish to have profits repaid. "
                         },

                         new About
                         {
                             Section = "•  Shopping for the kitchen:"
                         },

                         new About
                         {
                             Section = "  ◦  Remember to bring the receipt from the store."
                         },

                         new About
                         {
                             Section = "  ◦  Either get a separate receipt for the kitchen stuff or somehow mark the stuff on the receipt."
                         },

                         new About
                         {
                             Section = "  ◦  Write your name on the receipt and put it in the envelope on the bulletin board."
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
