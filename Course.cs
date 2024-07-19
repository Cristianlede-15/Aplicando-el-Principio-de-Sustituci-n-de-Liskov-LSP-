namespace Aplicando_el_Principio_de_Sustitución_de_Liskov__LSP_
{
    public abstract class Course
    {
        public int CourseId { get; set; }
        public string? Title { get; set; }  

        public abstract void Subscribe(Student std);
    }
}
