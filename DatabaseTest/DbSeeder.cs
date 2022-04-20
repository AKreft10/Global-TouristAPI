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
        private readonly DatabaseContext _context;

        public DbSeeder(DatabaseContext context)
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
                    Name = "Louvre Museum",
                    Description = "The Louvre, or the Louvre Museum, is the world's most-visited museum, and a historic landmark in Paris, France. It is the home of some of the best-known works of art, including the Mona Lisa and the Venus de Milo.",
                    Address = new Address
                    {
                        Country = "France",
                        City = "Paris",
                        Street = "Rue de Rivoli",
                        PostalCode = "75001",
                        Latitude = 48.86065695904424,
                        Longitude = 2.3376225404954907
                    },
                    Photos = new List<PlacePhoto>
                    {
                        new PlacePhoto()
                        {
                            Photo = new Photo()
                            {
                                PhotoUrl = "https://cdn-imgix.headout.com/mircobrands-content/image/4e9ebbf7ff686d29a41f4af39e8386ea-louvre%20museum.jpg?auto=compress%2Cformat&h=573&q=75&fit=crop&ar=16%3A9&fm=pjpg",
                                Author = "Arthur Mason"
                            }
                        },
                        new PlacePhoto()
                        {
                            Photo = new Photo()
                            {
                                PhotoUrl = "https://cdn.britannica.com/02/121002-050-92DB902F/Louvre-Museum-pyramid-Paris-Pei-IM.jpg",
                                Author = "Caleb Evans"
                            }
                        }
                    },
                    Reviews = new List<PlaceReview>
                    {
                        new PlaceReview()
                        {
                            Review = new Review()
                            {
                                Author = "Saad Achwa",
                                CreationDate = DateTime.Now,
                                Rating = 5,
                                ReviewContent = "One of the best places and 100% must visit  place during the season, though you have to be careful of social distancing because Covid19 is high peak once again, may Hid protect all humanity and out loved ones."
                            }
                        },
                        new PlaceReview()
                        {
                            Review = new Review()
                            {
                                Author = "Katherine Mojica",
                                CreationDate = DateTime.Now,
                                Rating = 5,
                                ReviewContent = "One of my favorite places in France. It's breathtaking, the history and every room has so much to tell. You'll need one whole day to really see most of it, because the museum is really big. You must plan to be there for minimum 4 hours."
                            }
                        }
                    }
                },

                new Place
                {
                    Name = "Cathredale Notre Dame",
                    Description = "Notre-Dame stands in the heart of Paris on the Île-de-la-Cite next to the Latin Quarter. An island in the Seine River, the Île-de-la-Cite is the historical and geographical center of Paris.",
                    Address = new Address
                    {
                        Country = "France",
                        City = "Paris",
                        Street = "6 Parvis Notre-Dame - Pl. Jean-Paul II",
                        PostalCode = "75004",
                        Latitude = 48.85307760149739,
                        Longitude = 2.3499128270054315
                    },
                    Photos = new List<PlacePhoto>
                    {
                        new PlacePhoto()
                        {
                            Photo = new Photo()
                            {
                                PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b4/Cath%C3%A9drale_Notre-Dame_de_Paris%2C_20_March_2014.jpg/1619px-Cath%C3%A9drale_Notre-Dame_de_Paris%2C_20_March_2014.jpg",
                                Author = "Alfie Gray"
                            }
                        },
                        new PlacePhoto()
                        {
                            Photo = new Photo()
                            {
                                PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/8/8c/Notredame_Paris.JPG",
                                Author = "Lucas Byrne"
                            }
                        }
                    },
                    Reviews = new List<PlaceReview>
                    {
                        new PlaceReview()
                        {
                            Review = new Review()
                            {
                                Author = "MariuS",
                                CreationDate = DateTime.Now,
                                Rating = 5,
                                ReviewContent = "Breathtaking architecture as always. I have visited the cathedral before the fire and currently after it. It is really sad to get to see how the fire impacted it you cannot go inside anymore and all you can see is the outside of it now."
                            }
                        },
                        new PlaceReview()
                        {
                            Review = new Review()
                            {
                                Author = "Team Ultimate Exposure William & Bug",
                                CreationDate = DateTime.Now,
                                Rating = 5,
                                ReviewContent = "So we just got here on Christmas Eve and this was one of the must sees for us. Well unfortunately it was closed for work. So we were not able to go inside but it was still one of the most amazing cathedrals we’ve seen."
                            }
                        }
                    }
                },
                new Place
                {
                    Name = "Louvre Museum",
                    Description = "The Louvre, or the Louvre Museum, is the world's most-visited museum, and a historic landmark in Paris, France. It is the home of some of the best-known works of art, including the Mona Lisa and the Venus de Milo.",
                    Address = new Address
                    {
                        Country = "France",
                        City = "Paris",
                        Street = "Rue de Rivoli",
                        PostalCode = "75001",
                        Latitude = 48.86065695904424,
                        Longitude = 2.3376225404954907
                    },
                    Photos = new List<PlacePhoto>
                    {
                        new PlacePhoto()
                        {
                            Photo = new Photo()
                            {
                                PhotoUrl = "https://cdn-imgix.headout.com/mircobrands-content/image/4e9ebbf7ff686d29a41f4af39e8386ea-louvre%20museum.jpg?auto=compress%2Cformat&h=573&q=75&fit=crop&ar=16%3A9&fm=pjpg",
                                Author = "Arthur Mason"
                            }
                        },
                        new PlacePhoto()
                        {
                            Photo = new Photo()
                            {
                                PhotoUrl = "https://cdn.britannica.com/02/121002-050-92DB902F/Louvre-Museum-pyramid-Paris-Pei-IM.jpg",
                                Author = "Caleb Evans"
                            }
                        }
                    },
                    Reviews = new List<PlaceReview>
                    {
                        new PlaceReview()
                        {
                            Review = new Review()
                            {
                                Author = "Saad Achwa",
                                CreationDate = DateTime.Now,
                                Rating = 5,
                                ReviewContent = "One of the best places and 100% must visit  place during the season, though you have to be careful of social distancing because Covid19 is high peak once again, may Hid protect all humanity and out loved ones."
                            }
                        },
                        new PlaceReview()
                        {
                            Review = new Review()
                            {
                                Author = "Katherine Mojica",
                                CreationDate = DateTime.Now,
                                Rating = 5,
                                ReviewContent = "One of my favorite places in France. It's breathtaking, the history and every room has so much to tell. You'll need one whole day to really see most of it, because the museum is really big. You must plan to be there for minimum 4 hours."
                            }
                        }
                    }
                },

                new Place
                {
                    Name = "Avenue des Champs-Élysées",
                    Description = "The most monumental boulevard in Paris used to be a desolate field of marshland until the 17th century, when it was landscaped by André Le Nôtre. A century later, the Parisian city planner Baron Haussmann designed the boulevard's elegant buildings.",
                    Address = new Address
                    {
                        Country = "France",
                        City = "Paris",
                        Street = "Av. des Champs-Élysées",
                        PostalCode = "75008",
                        Latitude = 48.87299017019517,
                        Longitude = 2.2978579626413413
                    },
                    Photos = new List<PlacePhoto>
                    {
                        new PlacePhoto()
                        {
                            Photo = new Photo()
                            {
                                PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/6/6d/Avenue_des_Champs-%C3%89lys%C3%A9es_July_24%2C_2009_N1.jpg",
                                Author = "Jadon Morse"
                            }
                        },
                        new PlacePhoto()
                        {
                            Photo = new Photo()
                            {
                                PhotoUrl = "https://en.parisinfo.com/var/otcp/sites/images/node_43/node_51/node_230/vue-a%C3%A9rienne-des-champs-elys%C3%A9es-%7C-630x405-%7C-%C2%A9-istock/19680692-1-fre-FR/Vue-a%C3%A9rienne-des-Champs-Elys%C3%A9es-%7C-630x405-%7C-%C2%A9-iStock.jpg",
                                Author = "Ryan Steele"
                            }
                        }
                    },
                    Reviews = new List<PlaceReview>
                    {
                        new PlaceReview()
                        {
                            Review = new Review()
                            {
                                Author = "Maneesh Gupta",
                                CreationDate = DateTime.Now,
                                Rating = 4,
                                ReviewContent = "Best mix of modern shops and historic surroundings , Arc De Triomphe on one side adds to the visit . Many stores to enjoy , great tourist vibe. Its a XXL version of NYs 5th Ave. With LV and Dior having their own huge buildings"
                            }
                        },
                        new PlaceReview()
                        {
                            Review = new Review()
                            {
                                Author = "If you like window shopping this is for you. It is great for strolling around and you can enter some of the other stores (not designer ones) and get a coffee along the way.",
                                CreationDate = DateTime.Now,
                                Rating = 5,
                                ReviewContent = "Nayeli Vazquez"
                            }
                        }
                    }
                },

                new Place
                {
                    Name = "Musée d'Orsay",
                    Description = "The Musée d'Orsay displays a splendid collection of 19th- and 20th-century art (created from 1848 to 1914) in the converted Gare d'Orsay. This Belle Epoque railway station was built for the Universal Exhibition of 1900.",
                    Address = new Address
                    {
                        Country = "France",
                        City = "Paris",
                        Street = "1 Rue de la Légion d'Honneur",
                        PostalCode = "75007",
                        Latitude = 48.86012725421223,
                        Longitude = 2.326539940476351
                    },
                    Photos = new List<PlacePhoto>
                    {
                        new PlacePhoto()
                        {
                            Photo = new Photo()
                            {
                                PhotoUrl = "https://aws-tiqets-cdn.imgix.net/images/content/2e18da2affe84093a455ee0349673772.jpg?auto=format&fit=crop&h=800&ixlib=python-3.2.1&q=70&w=800&s=b105719dfdb35b13e6b63e280f9c0577",
                                Author = "Kayden Cole"
                            }
                        },
                        new PlacePhoto()
                        {
                            Photo = new Photo()
                            {
                                PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Pary%C5%BC_orsay.JPG/220px-Pary%C5%BC_orsay.JPG",
                                Author = "Ashton Berry"
                            }
                        }
                    },
                    Reviews = new List<PlaceReview>
                    {
                        new PlaceReview()
                        {
                            Review = new Review()
                            {
                                Author = "Ghassan Yammine",
                                CreationDate = DateTime.Now,
                                Rating = 5,
                                ReviewContent = "One of my favorite museums in Paris for the temporary and regular exhibitions. The diversity of the collections is simply impressive."
                            }
                        },
                        new PlaceReview()
                        {
                            Review = new Review()
                            {
                                Author = "Aron Steg",
                                CreationDate = DateTime.Now,
                                Rating = 5,
                                ReviewContent = "What an amazing museum. The architecture of the railroad station is a stunning setting for a “modern art” gallery."
                            }
                        }
                    }
                },

                new Place
                {
                    Name = "The Brandenburg Gate",
                    Description = "Berlin's most famous historic landmark is undoubtedly the Brandenburg Gate (Brandenburger Tor). Once a symbol of a divided nation, it now stands as a symbol of unity and peace.",
                    Address = new Address
                    {
                        Country = "Germany",
                        City = "Berlin",
                        Street = "Pariser Platz",
                        PostalCode = "10117",
                        Latitude = 52.51644759488455,
                        Longitude = 13.377693369475782
                    },
                    Photos = new List<PlacePhoto>
                    {
                        new PlacePhoto()
                        {
                            Photo = new Photo()
                            {
                                PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a6/Brandenburger_Tor_abends.jpg/1200px-Brandenburger_Tor_abends.jpg",
                                Author = "Nathan Jenkins"
                            }
                        },
                        new PlacePhoto()
                        {
                            Photo = new Photo()
                            {
                                PhotoUrl = "https://cdn.britannica.com/39/6839-050-27891400/Brandenburg-Gate-Berlin.jpg",
                                Author = "Riley Hopkins"
                            }
                        }
                    },
                    Reviews = new List<PlaceReview>
                    {
                        new PlaceReview()
                        {
                            Review = new Review()
                            {
                                Author = "Niko Maric",
                                CreationDate = DateTime.Now,
                                Rating = 5,
                                ReviewContent = "Iconic gate to photograph. Come for pictures and enjoy the specular art. It's not too far and a nice walk from other nearby attractions. There were also people blowing bubbles in the air to help you make your photos look beautiful."
                            }
                        },
                        new PlaceReview()
                        {
                            Review = new Review()
                            {
                                Author = "Mujtaba Mehdi",
                                CreationDate = DateTime.Now,
                                Rating = 5,
                                ReviewContent = "I had an amazing time here, beautiful views and serene vicinity. If you are a photographer then you are going to have a time of your life."
                            }
                        }
                    }
                },

                new Place
                {
                    Name = "The Rebuilt Reichstag",
                    Description = "The Reichstag (Reichstagsgebäude) was originally completed in 1894 where the Neo-Renaissance palace served as the home of the German Empire's Imperial Diet until it burned in 1933.",
                    Address = new Address
                    {
                        Country = "Germany",
                        City = "Berlin",
                        Street = "Platz der Republik 1",
                        PostalCode = "11011",
                        Latitude = 52.51872790050797,
                        Longitude = 13.376197927116714
                    },
                    Photos = new List<PlacePhoto>
                    {
                        new PlacePhoto()
                        {
                            Photo = new Photo()
                            {
                                PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/14/Berlin_reichstag_CP.jpg/1200px-Berlin_reichstag_CP.jpg",
                                Author = "Cody Mills"
                            }
                        },
                        new PlacePhoto()
                        {
                            Photo = new Photo()
                            {
                                PhotoUrl = "https://www.berlin.de/binaries/asset/image_assets/6486153/source/1646302570/624x468/",
                                Author = "Neil Payne"
                            }
                        }
                    },
                    Reviews = new List<PlaceReview>
                    {
                        new PlaceReview()
                        {
                            Review = new Review()
                            {
                                Author = "Tabalo",
                                CreationDate = DateTime.Now,
                                Rating = 4,
                                ReviewContent = "The excursion itself is audioguided tour in the dome while you'll watch the neighboring attractions and hear about them and about some historic facts. It's free of charge but advance registration in a small building near the entrance is required."
                            }
                        },
                        new PlaceReview()
                        {
                            Review = new Review()
                            {
                                Author = "Kate S",
                                CreationDate = DateTime.Now,
                                Rating = 5,
                                ReviewContent = "I knew we had to book to visit the Dome, but was not aware that we were meant to have booked 3 days in advance. Even still, we took our chances on our first day in Berlin, hoping we might be lucky, as this was something I really wanted to see."
                            }
                        }
                    }
                },

                new Place
                {
                    Name = "Museum Island",
                    Description = "Sandwiched between the River Spree and the Kupfergraben in a 400-meter-long canal, Spree Island — better known as Museum Island (Museumsinsel) — is one of the city's most important UNESCO World Heritage Sites.",
                    Address = new Address
                    {
                        Country = "Germany",
                        City = "Berlin",
                        Street = "",
                        PostalCode = "",
                        Latitude = 52.51706638284033,
                        Longitude = 13.401926397084221
                    },
                    Photos = new List<PlacePhoto>
                    {
                        new PlacePhoto()
                        {
                            Photo = new Photo()
                            {
                                PhotoUrl = "https://c8.alamy.com/comp/PRTC8J/bode-museum-museum-island-berlin-germany-PRTC8J.jpg",
                                Author = "Toby Galloway"
                            }
                        },
                        new PlacePhoto()
                        {
                            Photo = new Photo()
                            {
                                PhotoUrl = "https://ak.jogurucdn.com/media/image/p25/place-2014-10-09-15-0b89f72169fe467441ff97b525a71e29.jpg",
                                Author = "Arian Morales"
                            }
                        }
                    },
                    Reviews = new List<PlaceReview>
                    {
                        new PlaceReview()
                        {
                            Review = new Review()
                            {
                                Author = "Praveen Mehrotra",
                                CreationDate = DateTime.Now,
                                Rating = 5,
                                ReviewContent = "If you have little time in Berlin then, after Brandenburg gate you must head to Museum Island. It houses five museums and also the famous Berlin Cathedral."
                            }
                        },
                        new PlaceReview()
                        {
                            Review = new Review()
                            {
                                Author = "Rahaf Walid",
                                CreationDate = DateTime.Now,
                                Rating = 4,
                                ReviewContent = "Amazing place to chill and meet history art and much more. It was cold so i guess in summer it would be better. A must go to in Berlin"
                            }
                        }
                    }
                },

                new Place
                {
                    Name = "The Berlin Wall Memorial",
                    Description = "The Berlin Wall originated in 1961 when East Germany sealed off that half of the city to prevent citizens from fleeing to West Germany. By the time it was torn down in 1989, the four-meter-high wall extended 155 kilometers, dissected 55 streets, and possessed 293 observation towers and 57 bunkers.",
                    Address = new Address
                    {
                        Country = "Germany",
                        City = "Berlin",
                        Street = "Bernauer Str. 111",
                        PostalCode = "13355",
                        Latitude = 52.535094619209374,
                        Longitude = 13.390184080948963
                    },
                    Photos = new List<PlacePhoto>
                    {
                        new PlacePhoto()
                        {
                            Photo = new Photo()
                            {
                                PhotoUrl = "https://www.stiftung-berliner-mauer.de/sites/default/files/styles/xl/public/media/standorte/gbm/allgemein/1_SBM_Gedenksta%CC%88tteBerlinerMauer_Bild_04.jpg?itok=6Humivp8",
                                Author = "Aiden Patel"
                            }
                        },
                        new PlacePhoto()
                        {
                            Photo = new Photo()
                            {
                                PhotoUrl = "https://static.dw.com/image/18040671_101.jpg",
                                Author = "Billy Holmes"
                            }
                        }
                    },
                    Reviews = new List<PlaceReview>
                    {
                        new PlaceReview()
                        {
                            Review = new Review()
                            {
                                Author = "Neil Darler",
                                CreationDate = DateTime.Now,
                                Rating = 5,
                                ReviewContent = "An interesting place to walk around. Remnants of the wall, there are areas marked out where old pavements were, the lights used to illuminate the wall to."
                            }
                        },
                        new PlaceReview()
                        {
                            Review = new Review()
                            {
                                Author = "Minerve",
                                CreationDate = DateTime.Now,
                                Rating = 5,
                                ReviewContent = "Impressive to understand how this wall has been set up and how the people lived around it. Besides the memorial the whole street is filled with memories and it's great to have it to remind our selves of the history and never forget"
                            }
                        }
                    }
                },

                new Place
                {
                    Name = "German Historical Museum",
                    Description = "The German Historical Museum, known by the acronym DHM, is a museum in Berlin, Germany devoted to German history.",
                    Address = new Address
                    {
                        Country = "Germany",
                        City = "Berlin",
                        Street = "Unter den Linden 2",
                        PostalCode = "10117",
                        Latitude = 52.51816820132206,
                        Longitude = 13.396638762046642
                    },
                    Photos = new List<PlacePhoto>
                    {
                        new PlacePhoto()
                        {
                            Photo = new Photo()
                            {
                                PhotoUrl = "https://www.dhm.de/assets/_processed_/8/c/csm_uber_uns_01_8f0806ff17.png",
                                Author = "Lucas Cooke"
                            }
                        },
                        new PlacePhoto()
                        {
                            Photo = new Photo()
                            {
                                PhotoUrl = "https://cndarcdn.scdn3.secure.raxcdn.com/m/0/dhm-1920x800.jpg",
                                Author = "George Lane"
                            }
                        }
                    },
                    Reviews = new List<PlaceReview>
                    {
                        new PlaceReview()
                        {
                            Review = new Review()
                            {
                                Author = "leonard stone",
                                CreationDate = DateTime.Now,
                                Rating = 5,
                                ReviewContent = "Great exhibition on commissioned art in Third Reich and after exploring continuance of purpose. Awesome building."
                            }
                        },
                        new PlaceReview()
                        {
                            Review = new Review()
                            {
                                Author = "Bob",
                                CreationDate = DateTime.Now,
                                Rating = 4,
                                ReviewContent = "Nice expensive of arts and politics. Also good to have student price of 4€, free wifi and toilets."
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
                        Name = "HotelF1 Paris Saint Ouen Marché Aux Puces Rénové",
                        Description = "Featuring free WiFi throughout the property, HotelF1 Paris Saint Ouen Marché Aux Puces Rénové offers rooms with a flat-screen TV. The hotel is just a few steps from the flea market and a 10-minute walk from Garibaldi Metro Station.",
                        Address = new Address
                        {
                            Country = "France",
                            City = "Paris",
                            Street = "29 Rue du Dr Babinski",
                            PostalCode = "75018",
                            Latitude = 48.90128119070159,
                            Longitude = 2.332618913491718
                        },
                        Photos = new List<AccommodationPhoto>
                        {
                            new AccommodationPhoto()
                            {
                                Photo = new Photo()
                                {
                                    PhotoUrl = "https://cf.bstatic.com/xdata/images/hotel/max300/281501207.jpg?k=c462428fadcf95fc7e767c97b31cf1d1af782896d083fa18e245772d65fb270a&o=&hp=1",
                                    Author = "Alex Robinson"
                                }
                            },
                            new AccommodationPhoto()
                            {
                                Photo = new Photo()
                                {
                                    PhotoUrl = "https://www.ahstatic.com/photos/2539_rotdm_00_p_1024x768.jpg",
                                    Author = "Freddie Reynolds"
                                }
                            }
                        },
                        Reviews = new List<AccommodationReview>
                        {
                            new AccommodationReview()
                            {
                                Review = new Review()
                                {
                                    Author = "M S",
                                    CreationDate = DateTime.Now,
                                    Rating = 5,
                                    ReviewContent = "While there are a lot of negative reviews, I can’t say some bad things about the hotel. Given the price, it meets all expectations. "
                                }
                            },
                            new AccommodationReview()
                            {
                                Review = new Review()
                                {
                                    Author = "Diana Fisgativa",
                                    CreationDate = DateTime.Now,
                                    Rating = 2,
                                    ReviewContent = "Terrible customer service by phone/email. This is not a review of the hotel, since I had to cancel my booking. I paid in advance for the free cancellation. My plans changed and I cancelled more than two weeks ago."
                                }
                            }
                        }
                    },

                    new Accommodation
                    {
                        Name = "Ibis Paris Tour Eiffel Cambronne 15ème",
                        Description = "Located in Paris near the Eiffel Tower, ibis Paris Tour Eiffel Cambronne 15th, now known as Place Gustave, is near Metro 6. Enhance your getaway with our Eiffel Tower view rooms.",
                        Address = new Address
                        {
                            Country = "France",
                            City = "Paris",
                            Street = "2 Rue Cambronne",
                            PostalCode = "75015",
                            Latitude = 48.847145774804595,
                            Longitude = 2.3013501981467592
                        },
                        Photos = new List<AccommodationPhoto>
                        {
                            new AccommodationPhoto()
                            {
                                Photo = new Photo()
                                {
                                    PhotoUrl = "https://www.ahstatic.com/photos/1400_ho_00_p_1024x768.jpg",
                                    Author = "Valerie Cross"
                                }
                            },
                            new AccommodationPhoto()
                            {
                                Photo = new Photo()
                                {
                                    PhotoUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/21/5e/95/e3/exterior-view.jpg?w=900&h=600&s=1",
                                    Author = "Lee Weber"
                                }
                            }
                        },
                        Reviews = new List<AccommodationReview>
                        {
                            new AccommodationReview()
                            {
                                Review = new Review()
                                {
                                    Author = "Aadil Khan",
                                    CreationDate = DateTime.Now,
                                    Rating = 4,
                                    ReviewContent = "Location is the best thing about the hotel. Close to tram line, cafes and bakeries. About a half hour walk to Eiffel Tower. Staff are helpful and friendly."
                                }
                            },
                            new AccommodationReview()
                            {
                                Review = new Review()
                                {
                                    Author = "Michelle Anderson",
                                    CreationDate = DateTime.Now,
                                    Rating = 5,
                                    ReviewContent = "Very welcoming, friendly, helpful staff including front desk, bar and housekeeping. We had two rooms and both were clean and adequately stocked. "
                                }
                            }
                        }
                    },

                    new Accommodation
                    {
                        Name = "hotelF1 Paris Porte de Châtillon",
                        Description = "ituated in the 14th district in Paris, 4 km from the Luxembourg Gardens, hotelF1 Paris Porte de Châtillon boasts free WiFi throughout the property. Rooms are equipped with a flat-screen TV.",
                        Address = new Address
                        {
                            Country = "France",
                            City = "Paris",
                            Street = "23 Av. de la Prte de Châtillon",
                            PostalCode = "75014",
                            Latitude = 48.82312805455297,
                            Longitude = 2.3159336656289846
                        },
                        Photos = new List<AccommodationPhoto>
                        {
                            new AccommodationPhoto()
                            {
                                Photo = new Photo()
                                {
                                    PhotoUrl = "https://imgcy.trivago.com/c_limit,d_dummy.jpeg,f_auto,h_1300,q_auto,w_2000/itemimages/79/69/796966_v9.jpeg",
                                    Author = "Andrea Snyder"
                                }
                            },
                            new AccommodationPhoto()
                            {
                                Photo = new Photo()
                                {
                                    PhotoUrl = "https://www.ahstatic.com/photos/5010_ros2c_00_p_1024x768.jpg",
                                    Author = "Viola Potter"
                                }
                            }
                        },
                        Reviews = new List<AccommodationReview>
                        {
                            new AccommodationReview()
                            {
                                Review = new Review()
                                {
                                    Author = "Sahan Liyanaarachchi",
                                    CreationDate = DateTime.Now,
                                    Rating = 4,
                                    ReviewContent = "The rooms are quite clean and well kept. In one floor, there are three separate toilets and washrooms, separately for both men and women."
                                }
                            },
                            new AccommodationReview()
                            {
                                Review = new Review()
                                {
                                    Author = "Abigail Mensah",
                                    CreationDate = DateTime.Now,
                                    Rating = 1,
                                    ReviewContent = "Photos on website is very deceptive and misleading. The place is more like a dormitory. Beds are very uncomfortable, rock hard and small like jail mat."
                                }
                            }
                        }
                    },
                    new Accommodation
                    {
                        Name = "Pullman Paris Tour Eiffel",
                        Description = "The 4-star hotel Pullman Paris Tour Eiffel is set at the foot of the Eiffel Tower and the Trocadero. ",
                        Address = new Address
                        {
                            Country = "France",
                            City = "Paris",
                            Street = "18 Avenue De Suffren",
                            PostalCode = "75015",
                            Latitude = 48.8558217502294,
                            Longitude = 2.292933471161432
                        },
                        Photos = new List<AccommodationPhoto>
                        {
                            new AccommodationPhoto()
                            {
                                Photo = new Photo()
                                {
                                    PhotoUrl = "https://cf.bstatic.com/xdata/images/hotel/max500/312032260.jpg?k=a663aa1e0b2c256d40789579cfd4fa5e31e97ec637573d91254168af4a838f00&o=&hp=1",
                                    Author = "Dixie Hernandez"
                                }
                            },
                            new AccommodationPhoto()
                            {
                                Photo = new Photo()
                                {
                                    PhotoUrl = "https://www.ahstatic.com/photos/7229_ho_00_p_1024x768.jpg",
                                    Author = "Aaron Phillips"
                                }
                            }
                        },
                        Reviews = new List<AccommodationReview>
                        {
                            new AccommodationReview()
                            {
                                Review = new Review()
                                {
                                    Author = "Matt Gargett",
                                    CreationDate = DateTime.Now,
                                    Rating = 4,
                                    ReviewContent = "This is a great place if you want an Eiffel Tower view from your room. We stayed one night and could sit on the balcony and see the tower perfectly. It was really neat at night with the lights flashing."
                                }
                            },
                            new AccommodationReview()
                            {
                                Review = new Review()
                                {
                                    Author = "age",
                                    CreationDate = DateTime.Now,
                                    Rating = 5,
                                    ReviewContent = "Amazing view, we got a room on the 6th floor and the man said it was the best floor because you weren't too high or low from the view of the Eiffel tower."
                                }
                            }
                        }
                    },

                    new Accommodation
                    {
                        Name = "Park Inn by Radisson Berlin Alexanderplatz",
                        Description = "This 4-star-superior hotel offers 3 restaurants, a spa and air-conditioned rooms with flat-screen TVs. It is Berlin's tallest hotel and is located directly on Alexanderplatz Square.",
                        Address = new Address
                        {
                            Country = "Germany",
                            City = "Berlin",
                            Street = "108 Rue Saint-Lazare",
                            PostalCode = "10178",
                            Latitude = 52.52328491222606,
                            Longitude = 13.412776327136804
                        },
                        Photos = new List<AccommodationPhoto>
                        {
                            new AccommodationPhoto()
                            {
                                Photo = new Photo()
                                {
                                    PhotoUrl = "https://cf.bstatic.com/xdata/images/hotel/max500/47871301.jpg?k=8f76eebf5d3a36a984cbfdbe34f1e32424964cc86ccb836eace3e63552ea8f10&o=&hp=1",
                                    Author = "Velma Cohen"
                                }
                            },
                            new AccommodationPhoto()
                            {
                                Photo = new Photo()
                                {
                                    PhotoUrl = "https://www.kayak.pl/rimg/himg/ca/fc/ab/ice-114793-64072549_3XL-694587.jpg?width=720&height=576&crop=true",
                                    Author = "Juanita Holt"
                                }
                            }
                        },
                        Reviews = new List<AccommodationReview>
                        {
                            new AccommodationReview()
                            {
                                Review = new Review()
                                {
                                    Author = "Lakhwinder Anota",
                                    CreationDate = DateTime.Now,
                                    Rating = 3,
                                    ReviewContent = "Not what you'd expect from a 4 star hotel. We've stayed in a 4 star before and this hotel didn't measure up. …"
                                }
                            },
                            new AccommodationReview()
                            {
                                Review = new Review()
                                {
                                    Author = "Aoife Buckley",
                                    CreationDate = DateTime.Now,
                                    Rating = 3,
                                    ReviewContent = "Very compact room. Make sure you're very comfortable with whoever you're staying with because they will hear absolutely everything in the toilet. The shower Is literally in the bedroom with a shower curtain divide."
                                }
                            }
                        }
                    },

                    new Accommodation
                    {
                        Name = "Schulz Hotel Berlin Wall at the East Side Gallery",
                        Description = "This hotel is located directly next the East Side Gallery in the cool Friedrichshain district of Berlin. I really liked the staff, they were friendly.",
                        Address = new Address
                        {
                            Country = "Germany",
                            City = "Berlin",
                            Street = "Stralauer Pl. 36",
                            PostalCode = "10243",
                            Latitude = 52.508791144921005,
                            Longitude = 13.433851798280246
                        },
                        Photos = new List<AccommodationPhoto>
                        {
                            new AccommodationPhoto()
                            {
                                Photo = new Photo()
                                {
                                    PhotoUrl = "https://www.momondo.pl/rimg/kimg/18/7c/91bd8852-5dc97fdd-1.jpg?width=1366&height=768&crop=true",
                                    Author = "Ray Carroll"
                                }
                            },
                            new AccommodationPhoto()
                            {
                                Photo = new Photo()
                                {
                                    PhotoUrl = "https://www.momondo.pl/rimg/himg/ca/17/9c/hotelsdotcom-877710592-f2fd3e8b_w-192988.jpg?width=720&height=576&crop=true",
                                    Author = "Clinton Hughes"
                                }
                            }
                        },
                        Reviews = new List<AccommodationReview>
                        {
                            new AccommodationReview()
                            {
                                Review = new Review()
                                {
                                    Author = "Anthonio Reaction",
                                    CreationDate = DateTime.Now,
                                    Rating = 5,
                                    ReviewContent = "Last December we went to Berlin and had the pleasure to stay at this hotel. The hotel is centrally located in Berlin. Across the hotel you can find the station for the bus, train and tram."
                                }
                            },
                            new AccommodationReview()
                            {
                                Review = new Review()
                                {
                                    Author = "Danny",
                                    CreationDate = DateTime.Now,
                                    Rating = 4,
                                    ReviewContent = "Fine hotel that offers small but good rooms.Soundproofing was on point. The double glass does it work pretty well. Breakfast was a bit small but enough to start your day."
                                }
                            }
                        }
                    },

                    new Accommodation
                    {
                        Name = "Scandic Berlin Potsdamer Platz",
                        Description = "This eco-friendly modern hotel is located beside the Potsdamer Platz entertainment district in the centre of Berlin. The Scandic Hotel offers rooms with free WiFi and a flat-screen TV.",
                        Address = new Address
                        {
                            Country = "Germany",
                            City = "Berlin",
                            Street = "Gabriele-Tergit-Promenade 19",
                            PostalCode = "10963",
                            Latitude = 52.504862348687425,
                            Longitude = 13.3750370982801
                        },
                        Photos = new List<AccommodationPhoto>
                        {
                            new AccommodationPhoto()
                            {
                                Photo = new Photo()
                                {
                                    PhotoUrl = "https://www.scandichotels.com/imageVault/publishedmedia/0aaxgaasjabdlq3s6n3f/Scandic-Berlin-Potsdamer-Platz-room-Standard-KR-ac.jpg",
                                    Author = "Annie Howell"
                                }
                            },
                            new AccommodationPhoto()
                            {
                                Photo = new Photo()
                                {
                                    PhotoUrl = "https://cdn.dreamtours.pl/img/hotels/giata/227931/niemcy-berlin-scandic-berlin-potsdamer-platz-130.jpg",
                                    Author = "Gina Greene"
                                }
                            }
                        },
                        Reviews = new List<AccommodationReview>
                        {
                            new AccommodationReview()
                            {
                                Review = new Review()
                                {
                                    Author = "yvan lang",
                                    CreationDate = DateTime.Now,
                                    Rating = 4,
                                    ReviewContent = "Interesting hotel in berlin. A lot about sustainability. The bedroom was functional, very clean looking but not really special. The bathroom was great, in particular the shower with the different positions."
                                }
                            },
                            new AccommodationReview()
                            {
                                Review = new Review()
                                {
                                    Author = "Bill Hill",
                                    CreationDate = DateTime.Now,
                                    Rating = 5,
                                    ReviewContent = "This was a very enjoyable hotel to stay at. The staff were very helpful before and during the stay. With COVID restrictions/rules changing often, they were helpful with ensuring we could meet the requirements with testing."
                                }
                            }
                        }
                    },

                    new Accommodation
                    {
                        Name = "Motel One Berlin-Alexanderplatz",
                        Description = "Situated conveniently in Berlin, Motel One Berlin-Alexanderplatz offers air-conditioned rooms, a bar and free WiFi. Location. Central heating.",
                        Address = new Address
                        {
                            Country = "Germany",
                            City = "Berlin",
                            Street = "Grunerstraße 11",
                            PostalCode = "10179",
                            Latitude = 52.519788959547434,
                            Longitude = 13.412458450500088
                        },
                        Photos = new List<AccommodationPhoto>
                        {
                            new AccommodationPhoto()
                            {
                                Photo = new Photo()
                                {
                                    PhotoUrl = "https://www.motel-one.com/fileadmin/dam/Hotels/Berlin/Berlin-Alexanderplatz/Aussenbereich/hotel_berlin_alexanderplatz_motel_one_18.jpg",
                                    Author = "Kim Burgess"
                                }
                            },
                            new AccommodationPhoto()
                            {
                                Photo = new Photo()
                                {
                                    PhotoUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1a/b1/33/54/photo0jpg.jpg?w=900&h=600&s=1",
                                    Author = "Owen Jones"
                                }
                            }
                        },
                        Reviews = new List<AccommodationReview>
                        {
                            new AccommodationReview()
                            {
                                Review = new Review()
                                {
                                    Author = "Ming Lee",
                                    CreationDate = DateTime.Now,
                                    Rating = 2,
                                    ReviewContent = "First of all, staff was all lovely! They were all very polite and helpful. They seem to be happy working there too."
                                }
                            },
                            new AccommodationReview()
                            {
                                Review = new Review()
                                {
                                    Author = "Efrat Mass",
                                    CreationDate = DateTime.Now,
                                    Rating = 5,
                                    ReviewContent = "Really good location, overall.. As central and close to trains as you can get. Personally, on our next trip I will probably book the Hackashe Market location; a bit off center."
                                }
                            }
                        }
                    },

                    new Accommodation
                    {
                        Name = "MEININGER Hotel Berlin Hauptbahnhof",
                        Description = "This hotel is located in the heart of Berlin, between Berlin Central Station and the Reichstag Parliament. The MEININGER offers soundproofed rooms with modern design and a flat-screen TV.",
                        Address = new Address
                        {
                            Country = "Germany",
                            City = "Berlin",
                            Street = "Ella-Trebe-Straße 9",
                            PostalCode = "10557",
                            Latitude = 52.52430363142705,
                            Longitude = 13.367760898280784
                        },
                        Photos = new List<AccommodationPhoto>
                        {
                            new AccommodationPhoto()
                            {
                                Photo = new Photo()
                                {
                                    PhotoUrl = "https://content.r9cdn.net/rimg/himg/cf/1e/2f/arbisoftimages-308264-1101-meininger-hotel-berlin-central-station-schlafsaal-f4610e5-image.jpg?width=500&height=350&xhint=624&yhint=400&crop=true",
                                    Author = "David Curry"
                                }
                            },
                            new AccommodationPhoto()
                            {
                                Photo = new Photo()
                                {
                                    PhotoUrl = "https://foto.hrsstatic.com/fotos/0/3/1090/700/80/000000/http%3A%2F%2Fvideo.hrs.com%2F429%2F432429%2F391bed1133df5c9f10e34f441236b4ef30c6ed53%2Fpictures%2Fslide_1.jpg/HRS%20Video/0,0/6//slide_1.jpg",
                                    Author = "Marlon Palmer"
                                }
                            }
                        },
                        Reviews = new List<AccommodationReview>
                        {
                            new AccommodationReview()
                            {
                                Review = new Review()
                                {
                                    Author = "Nicholas Chronopoulos",
                                    CreationDate = DateTime.Now,
                                    Rating = 4,
                                    ReviewContent = "Location is great especially if you have to catch an early morning train. The staff was friendly and helpful. The room was rather small for the price they charge and they must consider upgrading the mattress."
                                }
                            },
                            new AccommodationReview()
                            {
                                Review = new Review()
                                {
                                    Author = "Jafis.clips",
                                    CreationDate = DateTime.Now,
                                    Rating = 2,
                                    ReviewContent = "Rooms are not clean at all, only did the beds and the rest was stained - UNACCEPTABLE. The noise at night was another reason why i am rating this so low."
                                }
                            }
                        }
                    }
                };
            return accomodations;
        }
    }
}
