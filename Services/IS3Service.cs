using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace justTesting.Services
{
    public interface IS3Service
    {
        Task<string> AddItem(IFormFile photoFile, string v);

    }
}
