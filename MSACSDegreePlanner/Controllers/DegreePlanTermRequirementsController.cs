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
    public class DegreePlanTermRequirementsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DegreePlanTermRequirementsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DegreePlanTermRequirements
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DegreePlanTermRequirements.Include(d => d.Requirement).Include(d => d.StudentTerm);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: DegreePlanTermRequirements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreePlanTermRequirement = await _context.DegreePlanTermRequirements
                .Include(d => d.Requirement)
                .Include(d => d.StudentTerm)
                .FirstOrDefaultAsync(m => m.DegreePlanTermRequirementId == id);
            if (degreePlanTermRequirement == null)
            {
                return NotFound();
            }

            return View(degreePlanTermRequirement);
        }

        // GET: DegreePlanTermRequirements/Create
        public IActionResult Create()
        {
            ViewData["RequirementId"] = new SelectList(_context.Requirements, "RequirementId", "RequirementId");
            ViewData["StudentTermId"] = new SelectList(_context.StudentTerms, "StudentTermId", "StudentTermId");
            return View();
        }

        // POST: DegreePlanTermRequirements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DegreePlanTermRequirementId,DegreePlanId,StudentTermId,RequirementId,Done")] DegreePlanTermRequirement degreePlanTermRequirement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(degreePlanTermRequirement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RequirementId"] = new SelectList(_context.Requirements, "RequirementId", "RequirementId", degreePlanTermRequirement.RequirementId);
            ViewData["StudentTermId"] = new SelectList(_context.StudentTerms, "StudentTermId", "StudentTermId", degreePlanTermRequirement.StudentTermId);
            return View(degreePlanTermRequirement);
        }

        // GET: DegreePlanTermRequirements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreePlanTermRequirement = await _context.DegreePlanTermRequirements.FindAsync(id);
            if (degreePlanTermRequirement == null)
            {
                return NotFound();
            }
            ViewData["RequirementId"] = new SelectList(_context.Requirements, "RequirementId", "RequirementId", degreePlanTermRequirement.RequirementId);
            ViewData["StudentTermId"] = new SelectList(_context.StudentTerms, "StudentTermId", "StudentTermId", degreePlanTermRequirement.StudentTermId);
            return View(degreePlanTermRequirement);
        }

        // POST: DegreePlanTermRequirements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DegreePlanTermRequirementId,DegreePlanId,StudentTermId,RequirementId,Done")] DegreePlanTermRequirement degreePlanTermRequirement)
        {
            if (id != degreePlanTermRequirement.DegreePlanTermRequirementId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(degreePlanTermRequirement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DegreePlanTermRequirementExists(degreePlanTermRequirement.DegreePlanTermRequirementId))
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
            ViewData["RequirementId"] = new SelectList(_context.Requirements, "RequirementId", "RequirementId", degreePlanTermRequirement.RequirementId);
            ViewData["StudentTermId"] = new SelectList(_context.StudentTerms, "StudentTermId", "StudentTermId", degreePlanTermRequirement.StudentTermId);
            return View(degreePlanTermRequirement);
        }

        // GET: DegreePlanTermRequirements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreePlanTermRequirement = await _context.DegreePlanTermRequirements
                .Include(d => d.Requirement)
                .Include(d => d.StudentTerm)
                .FirstOrDefaultAsync(m => m.DegreePlanTermRequirementId == id);
            if (degreePlanTermRequirement == null)
            {
                return NotFound();
            }

            return View(degreePlanTermRequirement);
        }

        // POST: DegreePlanTermRequirements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var degreePlanTermRequirement = await _context.DegreePlanTermRequirements.FindAsync(id);
            _context.DegreePlanTermRequirements.Remove(degreePlanTermRequirement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DegreePlanTermRequirementExists(int id)
        {
            return _context.DegreePlanTermRequirements.Any(e => e.DegreePlanTermRequirementId == id);
        }
    }
}
