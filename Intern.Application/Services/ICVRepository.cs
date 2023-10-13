
using InternIngressInternal.Intern.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intern.Application.Service
{
    internal class ICVRepository
    {
        Task<CV> GetCVAsync(int ResumeCVid);
        Task<IEnmerable<CV>> GetAllCVsAsync();
        Task<CV> AddCVAsync(CV cv);
        Task<CV> UpdateCVAsync(CV cv);
        Task<CV> DeleteCVAsync(int ResumeCVid);
    }
}
