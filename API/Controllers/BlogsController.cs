using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;

using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Configuration;

namespace API.Controllers
{
 
    public class BlogsController : BaseApiController
    {


        private readonly StoreContext _context;

        public BlogsController(StoreContext context)
        {
            _context = context;



        }

        [HttpGet]

        public async Task<ActionResult<List<Blog>>> GetBlogs()
        {
            return await _context.Blogs.ToListAsync();

        }

        [HttpGet("{id}")] // 
        public async Task<ActionResult<Blog>> GetBlog(int id)
        {
            var blog = await _context.Blogs.FindAsync(id);

            if (blog == null) return NotFound();
            return blog;
        }
    }
}