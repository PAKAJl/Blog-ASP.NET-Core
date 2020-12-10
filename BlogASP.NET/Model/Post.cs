using System;
using System.Collections.Generic;

namespace BlogASP.NET.Model
{
    public partial class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PostContent { get; set; }
        public string MiniText { get; set; }
        public int? Views { get; set; }
        public int? Likes { get; set; }
        public int? AuthorId { get; set; }
        public TimeSpan? PublishDate { get; set; }
    }
}
