﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMS.Models
{
    public class Record
    {
        private ICollection<Note> notes;

        public Record()
        {
            this.notes = new HashSet<Note>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        public int DocumentId { get; set; }

        public virtual Document Document { get; set; }

        public int? RecordFileId { get; set; }

        public RecordFile RecordFile { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        public DateTime? FinishingDate { get; set; }

        [Required]
        public DateTime StatusDate { get; set; }

        [Required]
        public RecordStatus Status { get; set; }

        public int AreaId { get; set; }

        public Area Area { get; set; }

        public ICollection<Note> Notes
        {
            get { return this.notes; }
            set { this.notes = value; }
        }
    }
}
