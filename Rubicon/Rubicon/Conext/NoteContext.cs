using Microsoft.EntityFrameworkCore;
using Rubicon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubicon.Controllers.Conext
{
    public class NoteContext: DbContext
    {
        public NoteContext(DbContextOptions<NoteContext> options) : base(options)
        {

        }
        public DbSet<Note> Notes { get; set; }
    }
}
