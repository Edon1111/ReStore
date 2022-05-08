using System.Collections.Generic;
using System.Linq;
using API.Entities;

namespace API.Data
{
    public static class DbBlogInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Blogs.Any()) return;

            var blogs = new List<Blog>
            {
                new Blog
                {
                    BlogName = "Si te behemi shofer te mire",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    DataArtikullit="12 Mars 2022",
                    PictureUrl = "/images/blogs/blog_1.jpg",
                  
                },

                  new Blog
                {
                    BlogName = "Si te behemi shofer te mire",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    DataArtikullit="12 Mars 2022",
                    PictureUrl = "/images/blogs/blog_1.jpg",

                },
                    new Blog
                {
                    BlogName = "Si te behemi shofer te mire",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    DataArtikullit="12 Mars 2022",
                    PictureUrl = "/images/blogs/blog_1.jpg",

                },
                      new Blog
                {
                    BlogName = "Si te behemi shofer te mire",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    DataArtikullit="12 Mars 2022",
                    PictureUrl = "/images/blogs/blog_1.jpg",

                },
                        new Blog
                {
                    BlogName = "Si te behemi shofer te mire",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    DataArtikullit="12 Mars 2022",
                    PictureUrl = "/images/blogs/blog_1.jpg",

                },
                          new Blog
                {
                    BlogName = "Si te behemi shofer te mire",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    DataArtikullit="12 Mars 2022",
                    PictureUrl = "/images/blogs/blog_1.jpg",

                },
                            new Blog
                {
                    BlogName = "Si te behemi shofer te mire",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    DataArtikullit="12 Mars 2022",
                    PictureUrl = "/images/blogs/blog_1.jpg",

                },
                              new Blog
                {
                    BlogName = "Si te behemi shofer te mire",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    DataArtikullit="12 Mars 2022",
                    PictureUrl = "/images/blogs/blog_1.jpg",

                },
                                new Blog
                {
                    BlogName = "Si te behemi shofer te mire",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    DataArtikullit="12 Mars 2022",
                    PictureUrl = "/images/blogs/blog_1.jpg",

                },
                                  new Blog
                {
                    BlogName = "Si te behemi shofer te mire",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    DataArtikullit="12 Mars 2022",
                    PictureUrl = "/images/blogs/blog_1.jpg",

                },

            };

            foreach (var blog in blogs)
            {
                context.Blogs.Add(blog);
            }

            context.SaveChanges();
        }
    }
}