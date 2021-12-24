using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZBudget.Models.ZBudget
{
    public enum PayFrequency
    {
        [Display(Name = "One time pay")]
        Set,
        [Display(Name = "hourly")]
        Hourly,
        [Display(Name = "monthly")]
        Monthly,
    }

    public class Job
    {
        public Job PostJob(int id, string title, string desc, double pay, PayFrequency payfreq)
        {
            if (payfreq == null)
                PayExtension = PayFrequency.Hourly;
            else
                PayExtension = payfreq;
            Job j = new Job();
            j.PayExtension = payfreq;
            j.Id = id;
            j.Title = title;
            j.Description = desc;
            j.Pay = pay;
            j.IsValid = true;
            j.DatePosted = DateTime.Now;

            return j;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Pay { get; set; }
        public PayFrequency PayExtension { get; set; } = PayFrequency.Hourly;
        public bool IsValid { get; set; } = true;
        public DateTime DatePosted { get; set; } = DateTime.Now;
    }
}
