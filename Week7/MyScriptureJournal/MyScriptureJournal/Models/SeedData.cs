using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;

namespace MyScriptureJournal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                if (context == null || context.Scripture == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                if (context.Scripture.Any())
                {
                    return;
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "Psalm",
                        Verse = "23:1",
                        DateAdded = DateTime.Parse("2025-02-01"),
                        Notes = "A beautiful reminder of God's guidance and provision."
                    },

                    new Scripture
                    {
                        Book = "Isaiah",
                        Verse = "40:31",
                        DateAdded = DateTime.Parse("2025-02-14"),
                        Notes = "A promise of renewed strength for those who wait on the Lord."
                    },

                    new Scripture
                    {
                        Book = "Romans",
                        Verse = "8:28",
                        DateAdded = DateTime.Parse("2025-02-11"),
                        Notes = "A comforting assurance that God works all things for good."
                    },

                    new Scripture
                    {
                        Book = "Joshua",
                        Verse = "1:9",
                        DateAdded = DateTime.Parse("2025-02-07"),
                        Notes = "A call to be strong and courageous, for God is with us."
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
