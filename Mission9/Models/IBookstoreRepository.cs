﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9.Models
{
    //db first method
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
