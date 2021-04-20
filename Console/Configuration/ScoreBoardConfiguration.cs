using Console.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Console.Configuration
{
    public class ScoreBoardConfiguration : IEntityTypeConfiguration<ScoreBoard>
    {
        public void Configure(EntityTypeBuilder<ScoreBoard> builder)
        {
            builder.ToTable("ScoreBoards");
            builder.Property(x => x.Title).IsRequired().HasMaxLength(50);

            builder
                .HasMany(x => x.Scores)
                .WithOne(x => x.ScoreBoard);
        }
    }
}
