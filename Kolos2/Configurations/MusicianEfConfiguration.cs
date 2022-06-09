using System;

public class MusicianEfConfiguration : IEntityTypeConfiguration<Musician>
{
	public void Configure(EntityTypeBuilder<Musician> builder)
    {
        builder.HasKey(x => x.IdMusician).HasName("Musician_pk");

        builder.Property(x => x.IdMusician).UseIdentityColumn();
        builder.Property(x => x.FirstName).HasMaxLength(100).IsRequired();
        builder.Property(x => x.LastName).HasMaxLength(100).IsRequired();
        builder.Property(x => x.Nickname).HasMaxLength(100).IsRequired();

        var musicians = new List<Musician>
        {
            new Musician{IdMusician =1,FirstName="John",LastName="Travolta",Nickname="Johnny"},
            new Musician{IdMusician =2,FirstName="Freddie",LastName="Mercury",Nickname="Queen"}
        }
    }
}
