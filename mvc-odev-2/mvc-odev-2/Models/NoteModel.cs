namespace mvc_odev_2.Models
{
    public class NoteModel
    {
        public Guid? UserId { get; set; }

        public Guid? NoteId { get; set; }

        public string? NoteDescription { get; set; }

        public string? NoteDate { get; set; }

    }
}