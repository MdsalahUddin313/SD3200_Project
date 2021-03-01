using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SDProject03.Data;
using SDProject03.Models;

namespace SDProject03.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogPostsModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BlogPostsModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("/blog/index")]
        // GET: Admin/BlogPostsModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.BlogsPost.ToListAsync());
        }

        // GET: Admin/BlogPostsModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogPostsModel = await _context.BlogsPost
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (blogPostsModel == null)
            {
                return NotFound();
            }

            return View(blogPostsModel);
        }


        [Route ("/BlogPostsModels/Create")]
        // GET: Admin/BlogPostsModels/Create
        public IActionResult Create()
        {
            return View();
        }


        [Route("/BlogPostsModels/Create")]
        // POST: Admin/BlogPostsModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PostId,PostsName,BlogTitle,BlogDescription,BlogsRating,AuthorsName,PostedTime,ImageName")] BlogPostsModel blogPostsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(blogPostsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(blogPostsModel);
        }

        // GET: Admin/BlogPostsModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogPostsModel = await _context.BlogsPost.FindAsync(id);
            if (blogPostsModel == null)
            {
                return NotFound();
            }
            return View(blogPostsModel);
        }

        // POST: Admin/BlogPostsModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PostId,PostsName,BlogTitle,BlogDescription,BlogsRating,AuthorsName,PostedTime,ImageName")] BlogPostsModel blogPostsModel)
        {
            if (id != blogPostsModel.PostId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blogPostsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogPostsModelExists(blogPostsModel.PostId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(blogPostsModel);
        }

        // GET: Admin/BlogPostsModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogPostsModel = await _context.BlogsPost
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (blogPostsModel == null)
            {
                return NotFound();
            }

            return View(blogPostsModel);
        }

        // POST: Admin/BlogPostsModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blogPostsModel = await _context.BlogsPost.FindAsync(id);
            _context.BlogsPost.Remove(blogPostsModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogPostsModelExists(int id)
        {
            return _context.BlogsPost.Any(e => e.PostId == id);
        }
    }
}
