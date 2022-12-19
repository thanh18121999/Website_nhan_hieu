using System.ComponentModel.DataAnnotations;

namespace Project.Models.Dto
{
    public class CourseDto
    {
        public int ID { get; set; }
        public string? CODE {get;set;}
        public string? NAME {get;set;}
        public string? DESCRIPTION {get;set;}
        public DateTime CREATEDDATE { get; set; }
        public DateTime STARTDATE { get; set; }
        public DateTime ENDDATE { get; set; }
        public string? CREATEDUSER { get; set; }
        public string? STATUS { get; set; }
        public string? Type {get;set;}
        public IEnumerable<CourseFeedBack>? Feedbacks {get;set;} 
    }
}