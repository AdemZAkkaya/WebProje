using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DergiProjesi.Models
{
    public class JournalInitializer : DropCreateDatabaseIfModelChanges<JournalContext>
    {
        protected override void Seed(JournalContext context)
        {
            List<Category> categories = new List<Category>()
            {
                new Category() { CategoryName = "Bilim"},
                new Category() { CategoryName = "Oyun"},
                new Category() { CategoryName = "Doğa"},
                new Category() { CategoryName = "Teknoloji"},
                new Category() { CategoryName = "Politika"}
            };

            foreach (var item in categories)
            {
                context.Categories.Add(item);
            }

            context.SaveChanges();

            List<Journal> journals = new List<Journal>()
            {
                new Journal() { Name = "Popular Science", Description = "Popular Science, bilim ve teknoloji konularına odaklanan, ABD merkezli bir popüler bilim dergisidir. İlk olarak 1872'de yayınlanan dergi, bilimsel keşifler, icatlar, yeni teknolojiler, uzay keşfi, sağlık, çevre ve daha birçok konuda makaleler, röportajlar ve görseller içerir. Popular Science, ayrıca Yılın En İyi İcatları gibi özel sayıları da yayınlamaktadır. Dergi, geniş bir okuyucu kitlesi tarafından takip edilmektedir ve bilim ve teknoloji konularına ilgi duyanlar için popüler bir kaynaktır.", ImageURL = "1.jpg", Onay = true, Anasayfa=true, CategoryId = 1},
                new Journal() { Name = "Game Informer", Description = "Game Informer, Amerika Birleşik Devletleri'nde yayınlanan ve video oyunlarına odaklanan bir dergidir. Dergi, ilk olarak 1991 yılında yayınlanmaya başlamıştır ve bugün birçok farklı platformda, hem dijital hem de basılı olarak okunabilir. Game Informer, video oyunları hakkında haberler, incelemeler, röportajlar, ipuçları ve stratejiler sunar. Ayrıca, oyun endüstrisi hakkında makaleler ve analizler de yayınlanır.", ImageURL = "2.jpg", Onay = true, Anasayfa=true, CategoryId = 2 },
                new Journal() { Name = "National Geographic", Description = "National Geographic, 1888 yılında kurulan ve dünya genelinde tanınmış bir popüler bilim dergisidir. Dergi, insanlar, hayvanlar, doğa, tarih, keşifler, kültür ve daha birçok konuda makaleler, fotoğraflar ve belgeseller sunar. National Geographic, dünyanın farklı bölgelerine seyahat eden yazarlar, fotoğrafçılar ve araştırmacılar tarafından hazırlanan orijinal içerikler yayınlamaktadır.", ImageURL = "3.jpg", Onay = true, Anasayfa=true, CategoryId = 3 },
                new Journal() { Name = "Wired", Description = "Wired, 1993 yılında kurulan ve teknoloji, bilim, tasarım ve iş dünyası konularına odaklanan bir aylık dergidir. Dergi, ileri teknolojik ürünler, dijital yenilikler, internet, yapay zeka, robotik ve daha birçok konuda öncü araştırmalar, makaleler ve analizler sunar. Wired, dünya genelinde teknoloji ve yenilik meraklılarının takip ettiği bir kaynak olarak kabul edilir.", ImageURL = "4.jpg", Onay = true, Anasayfa=true, CategoryId = 4 },
                new Journal() { Name = "Time", Description = "Time dergisi, ABD merkezli bir haftalık dergidir ve dünya genelinde siyasi, ekonomik, sosyal ve kültürel konulara ilişkin haberler, makaleler ve yorumlar içerir. Ayrıca, Yılın Kişisi ve Yılın En İyi İcatları gibi özel sayıları da vardır.", Onay = true, Anasayfa=true, ImageURL = "5.jpg", CategoryId = 5 }
            };

            foreach (var item in journals)
            {
                context.Journals.Add(item);
            }

            context.SaveChanges();
            
        }
    }
}