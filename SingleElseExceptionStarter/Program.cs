using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingleElseExceptionStarter
{
    internal static class Program
    {
        private static IEnumerable<Movie> s_AllMovies = GetAllMovies();

        public static void Main(string[] args)
        {
            var requiredYear = 2019;
            //s_AllMovies.FirstElseException(m => m.Year == requiredYear, () =>
            //{
            //    return new MoreThanOneMovieMatchedException($"Expected to find at least 1 Movie for the Year: {requiredYear}, but no movies were found.");
            //});

            var requiredMovie = s_AllMovies.SingleElseException(m => m.Year == requiredYear, foundMovies =>
            {
                var message = new StringBuilder();

                if (!foundMovies.Any())
                {
                    message.AppendLine($"We were expecting exactly one movie for the Year: {requiredYear}, but no matching movies were found.");
                }
                else
                {
                    message.AppendLine($"We were expecting exactly one movie for the Year: {requiredYear}, but found the following movies instead");
                }                
                
                foreach (var movie in foundMovies)
                {
                    message.AppendLine($"Title: {movie.Title}\t Year: {movie.Year}\t Genre: {movie.Genre}");
                }

                var exception = new MoreThanOneMovieMatchedException(message.ToString());
                exception.Data.Add("Year", requiredYear);
                return exception;
            });

            Console.WriteLine($"{requiredMovie.Title}");
        }

        private static IEnumerable<Movie> GetAllMovies()
        {
            yield return new Movie("Star Wars Episode IV: A New Hope", imageUrl: "StarWarsEpisodeIV.jpg", "Sci-Fi", 1977);
            yield return new Movie("Star Wars Episode V: The Empire Strikes Back", "StarWarsEpisodeV.jpg", "Sci-Fi", 1980);
            yield return new Movie("Star Wars Episode VI: Return of the Jedi", "StarWarsEpisodeVI.jpg", "Sci-Fi", 1983);
            yield return new Movie("Star Wars: Episode I: The Phantom Menace", "StarWarsEpisodeI.jpg", "Sci-Fi", 1999);
            yield return new Movie("Star Wars Episode II: Attack of the Clones", "StarWarsEpisodeII.jpg", "Sci-Fi", 2002);
            yield return new Movie("Star Wars: Episode III: Revenge of the Sith", "StarWarsEpisodeIII.jpg", "Sci-Fi", 2005);
            yield return new Movie("Olympus Has Fallen", "Olympus_Has_Fallen_poster.jpg", "Action", 2013);
            yield return new Movie("G.I. Joe: Retaliation", "GIJoeRetaliation.jpg", "Action", 2013);
            yield return new Movie("Jack the Giant Slayer", "jackgiantslayer4.jpg", "Action", 2013);
            yield return new Movie("Drive", "FileDrive2011Poster.jpg", "Action", 2011);
            yield return new Movie("Sherlock Holmes", "FileSherlock_Holmes2Poster.jpg", "Action", 2009);
            yield return new Movie("The Girl with the Dragon Tatoo", "FileThe_Girl_with_the_Dragon_Tattoo_Poster.jpg", "Drama", 2011);
            yield return new Movie("Saving Private Ryan", "SavingPrivateRyan.jpg", "Drama", 1998);
            yield return new Movie("Schindlers List", "SchindlersList.jpg", "Drama", 1993);
            yield return new Movie("Good Will Hunting", "FileGood_Will_Hunting_theatrical_poster.jpg", "Drama", 1997);
            yield return new Movie("Citizen Kane", "Citizenkane.jpg", "Drama", 1941);
            yield return new Movie("Shawshank Redemption", "FileShawshankRedemption.jpg", "Drama", 1994);
            yield return new Movie("Forest Gump", "ForrestGump.jpg", "Drama", 1994);
            yield return new Movie("We Bought a Zoo", "FileWe_Bought_a_Zoo_Poster.jpg", "Drama", 2011);
            yield return new Movie("A Beautiful Mind", "FileAbeautifulmindposter.jpg", "Drama", 2001);
            yield return new Movie("Avatar", "Avatar.jpg", "Sci-Fi", 2009);
            yield return new Movie("Iron Man", "IronMan.jpg", "Sci-Fi", 2008);
            yield return new Movie("Terminator 2", "Terminator2.jpg", "Sci-Fi", 1991);
            yield return new Movie("The Dark Knight", "TheDarkKnight.jpg", "Sci-Fi", 2001);
            yield return new Movie("The Matrix", "TheMatrix.jpg", "Sci-Fi", 1999);
            yield return new Movie("Transformers", "Transformers.jpg", "Sci-Fi", 2007);
            yield return new Movie("Revenge Of The Fallen", "TransformersRevengeOfTheFallen.jpg", "Sci-Fi", 2009);
            yield return new Movie("The Dark of the Moon", "TransformersTheDarkoftheMoon.jpg", "Sci-Fi", 2011);
            yield return new Movie("X-Men First Class", "XMenFirstClass.jpg", "Sci-Fi", 2011);
            yield return new Movie("Snitch", "Snitch.jpg", "Thriller", 2013);
            yield return new Movie("Life Of Pi", "LifeOfPi.jpg", "Drama", 2012);
            yield return new Movie("The Call", "TheCall.jpg", "Thriller", 2013);
            yield return new Movie("Wake in Fright", "WakeInFright.jpg", "Thriller", 1971);
            yield return new Movie("Oblivion", "Oblivion.jpg", "Sci-Fi", 2013);
            yield return new Movie("American Sniper", "AmericanSniper.jpg", "Thriller", 2015);
            yield return new Movie("Run All Night", "RunAllNight.jpg", "Thriller", 2015);
            yield return new Movie("Mission: Impossible - Rogue Nation", "MissionImpossibleRogueNation.jpg", "Thriller", 2015);
            yield return new Movie("Spectre", "Spectre.jpg", "Thriller", 2015);
            yield return new Movie("Insurgent", "Insurgent.jpg", "Thriller", 2015);
            yield return new Movie("Kill Me Three Times", "KillMeThreeTimes.jpg", "Thriller", 2014);
            yield return new Movie("Batman v Superman: Dawn of Justice", "BatmanVSupermanDawnofJustice.jpg", "Action", 2016);
            yield return new Movie("Avengers: Age of Ultron", "AvengersAgeofUltron.jpg", "Action", 2015);
            yield return new Movie("Guardians of the Galaxy", "GuardiansoftheGalaxy.jpg", "Action", 2015);
            yield return new Movie("Kingsman: The Secret Service", "KingsmanTheSecretService.jpg", "Action", 2014);
            yield return new Movie("Seventh Son", "SeventhSon.jpg", "Action", 2014);
            yield return new Movie("Maze Runner: The Scorch Trials", "MazeRunnerTheScorchTrials.jpg", "Thriller", 2015);
            yield return new Movie("Avengers: Endgame", "AvengersEndgame.jpg", "Sci-Fi", 2019);
            yield return new Movie("The Intruder", "TheIntruder.jpg", "Drama", 2019);
            yield return new Movie("Bolden", "Bolden.jpg", "Drama", 2019);
            yield return new Movie("Clara", "Clara.jpg", "Sci-Fi", 2019);
            yield return new Movie("Captain Marvel", "CaptainMarvel.jpg", "Sci-Fi", 2019);
            yield return new Movie("The Hustle", "TheHustle.jpg", "Comedy", 2019);
            yield return new Movie("All Is True", "AllIsTrue.jpg", "Drama", 2019);
        }
    }

    internal static class EnumerableExtensions
    {
        public static T SingleElseException<T>(this IEnumerable<T> sequence, Func<T, bool> predicate, Func<IEnumerable<T>, Exception> exceptionFactory)
        {
            var matchedItems = sequence.Where(x => predicate(x));
            return matchedItems.Count() == 1 ? matchedItems.Single() : throw exceptionFactory(matchedItems);
        }

        public static T SingleElseException<T>(this IEnumerable<T> sequence, Func<IEnumerable<T>, Exception> exceptionFactory)
        {
            return sequence.Count() == 1 ? sequence.First() : throw exceptionFactory(sequence);
        }

        public static T FirstElseException<T>(this IEnumerable<T> sequence, Func<T, bool> predicate, Func<Exception> exceptionFactory)
        {
            var matchedItems = sequence.Where(x => predicate(x));
            return matchedItems.Any() ? matchedItems.First() : throw exceptionFactory();
        }
    }
}
