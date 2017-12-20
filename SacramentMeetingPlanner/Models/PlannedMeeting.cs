using System;
using System.ComponentModel.DataAnnotations;


namespace SacramentMeetingPlanner.Models
{
    public class PlannedMeeting
    {
        public int ID { get; set; }

        [Display(Name = "Meeting Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(100)]
        public string Conductor { get; set; }

        [Display(Name = "Opening Hymn")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(100)]
        public string OpenningSong { get; set; }

        [Display(Name = "Opening Prayer")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(100)]
        public string StartPrayer { get; set; }

        [Display(Name = "Sacrament Hymn")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(100)]
        public string SacramentSong { get; set; }

        [Display(Name = "Speaker")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(100)]
        public string SpeakerOne { get; set; }

        [Display(Name = "Topic")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(100)]
        public string TopicOne { get; set; }

        [Display(Name = "Speaker")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(100)]
        public string SpeakerTwo { get; set; }

        [Display(Name = "Topic")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(100)]
        public string TopicTwo { get; set; }

        [Display(Name = "Speaker")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(100)]
        public string SpeakerThree { get; set; }

        [Display(Name = "Topic")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(100)]
        public string TopicThree { get; set; }

        [Display(Name = "Speaker")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(100)]
        public string SpeakerFour { get; set; }

        [Display(Name = "Topic")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(100)]
        public string TopicFour { get; set; }

        [Display(Name = "Speaker")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(100)]
        public string SpeakerFive { get; set; }

        [Display(Name = "Topic")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(100)]
        public string TopicFive { get; set; }

        [Display(Name = "Intermediate Hymn")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(100)]
        public string OptionalSong { get; set; }

        [Display(Name = "Closing Hymn")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(100)]
        public string ClosingSong { get; set; }

        [Display(Name = "Closing Prayer")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(100)]
        public string EndPrayer { get; set; }
    }


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