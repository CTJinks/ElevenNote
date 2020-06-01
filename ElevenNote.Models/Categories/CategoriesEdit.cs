﻿using ElevenNote.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class CategoriesEdit
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<Note> NoteList { get; set; }
    }
}
