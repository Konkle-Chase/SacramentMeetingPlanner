using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace SacramentMeetingPlanner.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SacramentMeetingPlannerContext(
                serviceProvider.GetRequiredService<DbContextOptions<SacramentMeetingPlannerContext>>()))
            {
                // Look for any movies.
                if (context.PlannedMeeting.Any())
                {
                    return;   // DB has been seeded
                }
                //int ID { get; set; }
                //DateTime MeetingDate { get; set; }
                //string Conductor { get; set; }
                //string OpeningSong { get; set; }
                //string StartPrayer { get; set; }
                //string SacramentSong { get; set; }
                //string SpeakerOne { get; set; }
                //string SpeakerTwo { get; set; }
                //string SpeakerThree { get; set; }
                //string SpeakerFour { get; set; }
                //string SpeakerFive { get; set; }
                //string OptionalSong { get; set; }
                //string ClosingSong { get; set; }
                //string EndPrayer { get; set; }
                context.PlannedMeeting.AddRange(
                     new PlannedMeeting
                     {
                         MeetingDate = DateTime.Today.Date,
                         Conductor = "Bishop Brown",
                         OpenningSong = "Come thou Fount of Every Blessing",
                         SacramentSong = "God Loved Us, So",
                         ClosingSong = "Abide With Me!",
                         StartPrayer = "Chase Konkle",
                         EndPrayer = "Christine Konkle",
                         SpeakerOne = "Dallan Prince",
                         TopicOne = "Repentance",
                         SpeakerTwo = "Devin Kelm",
                         TopicTwo = "Keep the Sabbath Day Holy",
                         SpeakerThree = "Mason Konkle",
                         TopicThree = "Missionary Work",
                         SpeakerFour = "",
                         TopicFour = "",
                         SpeakerFive = "",
                         TopicFive = ""
                        
                     },

                     new PlannedMeeting
                     {
                         MeetingDate = DateTime.Today.Date,
                         Conductor = "John Prince",
                         OpenningSong = "Praise to the Man",
                         SacramentSong = "There is a Green Hill",
                         OptionalSong = "God Speed the Right",
                         ClosingSong = "Abide With Me; 'tis Eventide",
                         StartPrayer = "Ammon DeCrescenzo",
                         EndPrayer = "Paula Prince",
                         SpeakerOne = "Emily Kelm",
                         TopicOne = "Temple Attendance",
                         SpeakerTwo = "Michael Kelm",
                         TopicTwo = "Eternal Families",
                         SpeakerThree = "",
                         TopicThree = "",
                         SpeakerFour = "",
                         TopicFour = "",
                         SpeakerFive = "",
                         TopicFive = ""
                     },

                     new PlannedMeeting
                     {
                         MeetingDate = DateTime.Today.Date,
                         Conductor = "Aaron Burt",
                         OpenningSong = "How Firm a Foundation",
                         SacramentSong = "While of These Enblems We Partake",
                         OptionalSong = "The Spirit of God",
                         ClosingSong = "God Be With You till We Meet Again",
                         StartPrayer = "Gina Russell",
                         EndPrayer = "Levi DeCrescenzo",
                         SpeakerOne = "The Congregation",
                         TopicOne = "Bearing of Testimonies",
                         SpeakerTwo = "",
                         TopicTwo = "",
                         SpeakerThree = "",
                         TopicThree = "",
                         SpeakerFour = "",
                         TopicFour = "",
                         SpeakerFive = "",
                         TopicFive = ""
                     }
                );
                context.SaveChanges();
            }
        }
    }
}