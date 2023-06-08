using M2W5Assessment.Data;

using (var context = new ConcertContext())
{
    SeedData.SeedConcertsAndPerformers(context);
}