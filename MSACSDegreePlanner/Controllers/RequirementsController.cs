﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MSACSDegreePlanner.Data;
using MSACSDegreePlanner.Models;

namespace MSACSDegreePlanner.Controllers
{
    public class RequirementsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RequirementsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Requirements
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Requirements.Include(r => r.degree);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Requirements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requirement = await _context.Requirements
                .Include(r => r.degree)
                .FirstOrDefaultAsync(m => m.RequirementId == id);
            if (requirement == null)
            {
                return NotFound();
            }

            return View(requirement);
        }

        // GET: Requirements/Create
        public IActionResult Create()
        {
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeId");
            return View();
        }

        // POST: Requirements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RequirementId,RequirementAbbrev,RequirementName,DegreeId")] Requirement requirement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(requirement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeId", requirement.DegreeId);
            return View(requirement);
        }

        // GET: Requirements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requirement = await _context.Requirements.FindAsync(id);
            if (requirement == null)
            {
                return NotFound();
            }
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeId", requirement.DegreeId);
            return View(requirement);
        }

        // POST: Requirements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RequirementId,RequirementAbbrev,RequirementName,DegreeId")] Requirement requirement)
        {
            if (id != requirement.RequirementId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(requirement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequirementExists(requirement.RequirementId))
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
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeId", requirement.DegreeId);
            return View(requirement);
        }

        // GET: Requirements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requirement = await _context.Requirements
                .Include(r => r.degree)
                .FirstOrDefaultAsync(m => m.RequirementId == id);
            if (requirement == null)
            {
                return NotFound();
            }

            return View(requirement);
        }

        // POST: Requirements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var requirement = await _context.Requirements.FindAsync(id);
            _context.Requirements.Remove(requirement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequirementExists(int id)
        {
            return _context.Requirements.Any(e => e.RequirementId == id);
        }
    }
}
