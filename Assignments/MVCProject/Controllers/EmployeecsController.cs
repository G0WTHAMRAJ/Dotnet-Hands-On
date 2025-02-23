﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCProject;
using MVCProject.Models;

namespace MVCProject.Controllers
{
    public class EmployeecsController : Controller
    {
        private readonly EmployeeDBContext _context;

        public EmployeecsController(EmployeeDBContext context)
        {
            _context = context;
        }

        // GET: Employeecs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employees.ToListAsync());
        }

        // GET: Employeecs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeecs = await _context.Employees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employeecs == null)
            {
                return NotFound();
            }

            return View(employeecs);
        }

        // GET: Employeecs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employeecs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Department,Salary")] Employeecs employeecs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeecs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employeecs);
        }

        // GET: Employeecs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeecs = await _context.Employees.FindAsync(id);
            if (employeecs == null)
            {
                return NotFound();
            }
            return View(employeecs);
        }

        // POST: Employeecs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Department,Salary")] Employeecs employeecs)
        {
            if (id != employeecs.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeecs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeecsExists(employeecs.Id))
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
            return View(employeecs);
        }

        // GET: Employeecs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeecs = await _context.Employees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employeecs == null)
            {
                return NotFound();
            }

            return View(employeecs);
        }

        // POST: Employeecs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeecs = await _context.Employees.FindAsync(id);
            if (employeecs != null)
            {
                _context.Employees.Remove(employeecs);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeecsExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }
    }
}
