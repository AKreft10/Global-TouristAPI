using DatabaseTest.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest
{
    public class DbSeeder
    {
        private readonly PlaceDbContext _context;

        public DbSeeder(PlaceDbContext context)
        {
            _context = context;
        }

        public void SeedData()
        {
            if (_context.Database.CanConnect())
            {
                if (!_context.Places.Any())
                {
                    var places = GetPlaces();
                    _context.Places.AddRange(places);
                    _context.SaveChanges();
                }
                if(!_context.Accommodations.Any())
                {
                    var accommodations = GetAccommodations();
                    _context.Accommodations.AddRange(accommodations);
                    _context.SaveChanges();
                }
            }
        }

        private IEnumerable<Place> GetPlaces()
        {
            var places = new List<Place>()
            {
                new Place
                {
                    Name = "Eiffel Tower",
                    Description = "The Eiffel Tower is a wrought-iron lattice tower on the Champ de Mars in Paris, France. It is named after the engineer Gustave Eiffel, whose company designed and built the tower.",
                    Address = new Address
                    {
                        Country = "France",
                        City = "Paris",
                        Street = "Champ de Mars, 5 Av. Anatole France",
                        PostalCode = "75007",
                        Latitude = 48.85892449718005,
                        Longitude = 2.2945056633550434
                    },
                    Photos = new List<PlacePhoto>
                    {
                        new PlacePhoto()
                        {
                            Photo = new Photo()
                            {
                                PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/51/Eiffel_Tower_%2872_names%29.jpg/2282px-Eiffel_Tower_%2872_names%29.jpg",
                                Author = "Mark"
                            }
                        },
                        new PlacePhoto()
                        {
                            Photo = new Photo()
                            {
                                PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/e/e8/Eiffel_trocadero_i.jpg",
                                Author = "Adam"
                            }
                        }
                    },
                    Reviews = new List<PlaceReview>
                    {
                        new PlaceReview()
                        {
                            Review = new Review()
                            {
                                Author = "Zoe",
                                CreationDate = DateTime.Now,
                                Rating = 4,
                                ReviewContent = "Excellent!"
                            }
                        },
                        new PlaceReview()
                        {
                            Review = new Review()
                            {
                                Author = "Floyd",
                                CreationDate = DateTime.Now,
                                Rating = 3,
                                ReviewContent = "Medicore service"
                            }
                        }
                    }
                }
            };


            return places;
        }

        private IEnumerable<Accommodation> GetAccommodations()
        {
            var accomodations = new List<Accommodation>()
            {
                 new Accommodation
                {
                    Name = "Joie Paris Tower Eiffel",
                    Description = "Located in the centre of Paris, within 200 metres of Eiffel Tower and 1.5 km of Rodin Museum, Joie Paris Tower Eiffel/ Quais de Seine is an accommodation offering city views.",
                    Address = new Address
                    {
                        Country = "France",
                        City = "Paris",
                        Street = "Quai de la Seine",
                        PostalCode = "75019",
                        Latitude = 48.886293466452244,
                        Longitude = 2.3736418241056016
                    },
                    Photos = new List<AccommodationPhoto>
                    {
                        new AccommodationPhoto()
                        {
                            Photo = new Photo()
                            {
                                PhotoUrl = "https://cf.bstatic.com/xdata/images/hotel/max500/42851828.jpg?k=68d2810935f035896f76603a491f4d984e30a9058705116395d5d153cb883a4e&o=&hp=1",
                                Author = "Joseph"
                            }
                        },
                        new AccommodationPhoto()
                        {
                            Photo = new Photo()
                            {
                                PhotoUrl = "https://pix10.agoda.net/hotelImages/862/862239/862239_15082614190035099665.jpg?ca=5&ce=1&s=1024x768",
                                Author = "Lucas"
                            }
                        }
                    },
                    Reviews = new List<AccommodationReview>
                    {
                        new AccommodationReview()
                        {
                            Review = new Review()
                            {
                                Author = "Mark",
                                CreationDate = DateTime.Now,
                                Rating = 4,
                                ReviewContent = "Wonderful"
                            }
                        },
                        new AccommodationReview()
                        {
                            Review = new Review()
                            {
                                Author = "Greg",
                                CreationDate = DateTime.Now,
                                Rating = 3,
                                ReviewContent = "Amazing!"
                            }
                        }
                    }
                }
            };
            return accomodations;
        }
    }
}
