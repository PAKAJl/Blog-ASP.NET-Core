using System;
using System.Collections.Generic;

namespace BlogASP.NET.Model
{
    public partial class Comment
    {
        public int Id { get; set; }
        public int? AuthorId { get; set; }
        public string Text { get; set; }
        public TimeSpan? PublishDate { get; set; }
        public int? LikeCount { get; set; }
    }
}
