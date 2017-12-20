using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Controllers
{
    public class MeetingPlannerController : Controller
    {
        private readonly SacramentMeetingPlannerContext _context;

        public MeetingPlannerController(SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        // GET: Movies
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public async Task<IActionResult> Index(string meetingDate, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<DateTime> meetingQuery = from m in _context.PlannedMeeting
                                             orderby m.Meeting
                                            select m.Meeting;

            var plannedMeetings = from m in _context.PlannedMeeting
                         select m;

            if (!String.IsNullOrEmpty(meetingDate))
            {
                plannedMeetings = plannedMeetings.Where(x => x.Meeting == DateTime.Parse(meetingDate));
            }

            var meetingDateVM = new MeetingDateViewModel();
            meetingDateVM.meetings = new SelectList(await meetingQuery.Distinct().ToListAsync());
            meetingDateVM.plannedMeetings = await plannedMeetings.ToListAsync();

            return View(meetingDateVM);
        }
        
        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plannedMeeting = await _context.PlannedMeeting
                .SingleOrDefaultAsync(m => m.ID == id);
            if (plannedMeeting == null)
            {
                return NotFound();
            }

            return View(plannedMeeting);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Meeting,Conductor,OpeningSong,StartPrayer,SacramentSong,Sacrament,SpeakerOne,SpeakerTwo,OptionalSong,SpeakerThree,ClosingSong,EndPrayer")] PlannedMeeting plannedMeeting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(plannedMeeting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(plannedMeeting);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plannedMeeting = await _context.PlannedMeeting.SingleOrDefaultAsync(m => m.ID == id);
            if (plannedMeeting == null)
            {
                return NotFound();
            }
            return View(plannedMeeting);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Meeting,Conductor,OpeningSong,StartPrayer,SacramentSong,Sacrament,SpeakerOne,SpeakerTwo,OptionalSong,SpeakerThree,ClosingSong,EndPrayer")] PlannedMeeting plannedMeeting)
        {
            if (id != plannedMeeting.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(plannedMeeting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlannedMeetingExists(plannedMeeting.ID))
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
            return View(plannedMeeting);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plannedMeeting = await _context.PlannedMeeting
                .SingleOrDefaultAsync(m => m.ID == id);
            if (plannedMeeting == null)
            {
                return NotFound();
            }

            return View(plannedMeeting);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var plannedMeeting = await _context.PlannedMeeting.SingleOrDefaultAsync(m => m.ID == id);
            _context.PlannedMeeting.Remove(plannedMeeting);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlannedMeetingExists(int id)
        {
            return _context.PlannedMeeting.Any(e => e.ID == id);
        }
    }
}
