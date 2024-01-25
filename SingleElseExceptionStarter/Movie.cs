﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleElseExceptionStarter
{
    public sealed class Movie
    {
        public string Title { get; }
        public string ImageUrl { get; }
        public string Genre { get; }
        public int Year { get; }

        public Movie(string title, string imageUrl, string genre, int year)
        {
            Title = title;
            ImageUrl = imageUrl;
            Genre = genre;
            Year = year;
        }
    }
}
