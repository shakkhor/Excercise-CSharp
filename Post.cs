using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execercise_OOP
{
    public class Post
    {
        private int Vote { get; set; }
        public DateTime CreateDate { get; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Post()
        {
            Vote = 0;
            CreateDate = DateTime.Now;
        }
        public void UpVote() => Vote++;
        public void DownVote() => Vote--;
        public int GetVote()=>  Vote; 
    }
}
