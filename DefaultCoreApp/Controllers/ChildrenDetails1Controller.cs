using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DefaultCoreApp.Models;

namespace DefaultCoreApp.Controllers
{
    public class ChildrenDetails1Controller : Controller
    {
        private readonly ChildrenDetailsContext _context;

        public ChildrenDetails1Controller(ChildrenDetailsContext context)
        {
            _context = context;
        }

        // GET: ChildrenDetails1
        public async Task<IActionResult> Index()
        {
            return View(await _context.ChildrenDetails.ToListAsync());
        }

        // GET: ChildrenDetails1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var childrenDetails = await _context.ChildrenDetails
                .SingleOrDefaultAsync(m => m.Id == id);
            if (childrenDetails == null)
            {
                return NotFound();
            }

            return View(childrenDetails);
        }

        // GET: ChildrenDetails1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ChildrenDetails1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ChildLastName,ChildFirstName,ChildGender,ChildBirthDate,ChildStatus,ChildAddress,ChildType,Parent1LastName,Parent1FirstName,Parent1Private,Parent1Gender,Parent1ChildRelation,Parent1Address,Parent1Unit,Parent1City,Parent1Province,Parent1PostalCode,Parent1HomePhone,Parent1WorkPhone,Parent1CellPhone,Parent1Email,Parent1PrimaryEmail,Parent1Comments,Parent1SpecialCustody,Parent2LastName,Parent2FirstName,Parent2Private,Parent2Gender,Parent2ChildRelation,Parent2Address,Parent2Unit,Parent2City,Parent2Province,Parent2PostalCode,Parent2HomePhone,Parent2WorkPhone,Parent2CellPhone,Parent2Email,Parent2PrimaryEmail,Parent2Comments,Parent2SpecialCustody,SiblingName,SiblingAge,SiblingGender,Contact1Name,Contact1Phone,Contact1Email,Contact1Address,Contact1Relationship,Contact2Name,Contact2Phone,Contact2Email,Contact2Address,Contact2Relationship,Contact3Name,Contact3Phone,Contact3Email,Contact3Address,Contact3Relationship,Contact4Name,Contact4Phone,Contact4Email,Contact4Address,Contact4Relationship")] ChildrenDetails childrenDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(childrenDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(childrenDetails);
        }

        // GET: ChildrenDetails1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var childrenDetails = await _context.ChildrenDetails.SingleOrDefaultAsync(m => m.Id == id);
            if (childrenDetails == null)
            {
                return NotFound();
            }
            return View(childrenDetails);
        }

        // POST: ChildrenDetails1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ChildLastName,ChildFirstName,ChildGender,ChildBirthDate,ChildStatus,ChildAddress,ChildType,Parent1LastName,Parent1FirstName,Parent1Private,Parent1Gender,Parent1ChildRelation,Parent1Address,Parent1Unit,Parent1City,Parent1Province,Parent1PostalCode,Parent1HomePhone,Parent1WorkPhone,Parent1CellPhone,Parent1Email,Parent1PrimaryEmail,Parent1Comments,Parent1SpecialCustody,Parent2LastName,Parent2FirstName,Parent2Private,Parent2Gender,Parent2ChildRelation,Parent2Address,Parent2Unit,Parent2City,Parent2Province,Parent2PostalCode,Parent2HomePhone,Parent2WorkPhone,Parent2CellPhone,Parent2Email,Parent2PrimaryEmail,Parent2Comments,Parent2SpecialCustody,SiblingName,SiblingAge,SiblingGender,Contact1Name,Contact1Phone,Contact1Email,Contact1Address,Contact1Relationship,Contact2Name,Contact2Phone,Contact2Email,Contact2Address,Contact2Relationship,Contact3Name,Contact3Phone,Contact3Email,Contact3Address,Contact3Relationship,Contact4Name,Contact4Phone,Contact4Email,Contact4Address,Contact4Relationship")] ChildrenDetails childrenDetails)
        {
            if (id != childrenDetails.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(childrenDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChildrenDetailsExists(childrenDetails.Id))
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
            return View(childrenDetails);
        }

        // GET: ChildrenDetails1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var childrenDetails = await _context.ChildrenDetails
                .SingleOrDefaultAsync(m => m.Id == id);
            if (childrenDetails == null)
            {
                return NotFound();
            }

            return View(childrenDetails);
        }

        // POST: ChildrenDetails1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var childrenDetails = await _context.ChildrenDetails.SingleOrDefaultAsync(m => m.Id == id);
            _context.ChildrenDetails.Remove(childrenDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChildrenDetailsExists(int id)
        {
            return _context.ChildrenDetails.Any(e => e.Id == id);
        }
    }
}
