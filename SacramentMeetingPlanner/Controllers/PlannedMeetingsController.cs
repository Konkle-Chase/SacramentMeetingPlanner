using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Models;
using System.Web;

namespace SacramentMeetingPlanner.Controllers
{
    public class PlannedMeetingsController : Controller
    {
        private readonly SacramentMeetingPlannerContext _context;

        public PlannedMeetingsController(SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        // GET: PlannedMeetings
        public async Task<IActionResult> Index(string searchString)
        {
            
            var plannedMeeting = from m in _context.PlannedMeeting
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                plannedMeeting = plannedMeeting.Where(s => s.MeetingDate.ToString().Contains(searchString));
            }

            return View(await plannedMeeting.ToListAsync());
        }

        public async Task<IActionResult> BigView()
        {
            return View(await _context.PlannedMeeting.ToListAsync());
        }


        // GET: PlannedMeetings/Details/5
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

        // GET: PlannedMeetings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PlannedMeetings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MeetingDate,Conductor,OpenningSong,StartPrayer,SacramentSong,SpeakerOne,TopicOne,SpeakerTwo,TopicTwo,SpeakerThree,TopicThree,SpeakerFour,TopicFour,SpeakerFive,TopicFive,OptionalSong,ClosingSong,EndPrayer,MeetingID")] PlannedMeeting plannedMeeting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(plannedMeeting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(plannedMeeting);
        }

        // GET: PlannedMeetings/Edit/5
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

        // POST: PlannedMeetings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MeetingDate,Conductor,OpenningSong,StartPrayer,SacramentSong,SpeakerOne,TopicOne,SpeakerTwo,TopicTwo,SpeakerThree,TopicThree,SpeakerFour,TopicFour,SpeakerFive,TopicFive,OptionalSong,ClosingSong,EndPrayer,MeetingID")] PlannedMeeting plannedMeeting)
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

        // GET: PlannedMeetings/Delete/5
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

        // POST: PlannedMeetings/Delete/5
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
