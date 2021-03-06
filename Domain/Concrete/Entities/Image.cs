﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Image
    {
        //TODO: rename home
        public int Id { get; set; }

        public byte[] Data { get; set; }

        public byte[] CompressedData { get; set; }

        public string Title { get; set; }

        public string MimeType { get; set; } //image type 

        public decimal Price { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public int AuthorId { get; set; }

        public string Description { get; set; }


    }
}
