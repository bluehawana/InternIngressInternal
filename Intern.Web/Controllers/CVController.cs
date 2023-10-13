using InternIngressInternal.Intern.Application.DTOs; // Assuming you have DTOs defined in your Application layer
using InternIngressInternal.Intern.Application.Services; // Assuming you have service interfaces defined in your Application layer
using InternIngressInternal.Intern.Web.Models; // ViewModels specific to your Web project
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace InternIngressInternal.Intern.Web.Controllers
{
    public class CVController : Controller
    {
        private readonly ICVService _cvService;
        private readonly IMapper _mapper;

        public CVController(ICVService cvService, IMapper mapper)
        {
            _cvService = cvService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var cvDTOs = _cvService.GetAllCVs();
            var cvViewModels = _mapper.Map<IEnumerable<CVViewModel>>(cvDTOs);
            return View(cvViewModels);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CVViewModel cvViewModel)
        {
            if (ModelState.IsValid)
            {
                var cvDTO = _mapper.Map<CVDTO>(cvViewModel);
                _cvService.CreateCV(cvDTO);
                return RedirectToAction("Index");
            }
            return View();
        }
        // You can add Edit, Details, Delete, etc. action methods similarly

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var cvDTO = _cvService.GetCVById(id);
            var cvViewModel = _mapper.Map<CVViewModel>(cvDTO);
            return View(cvViewModel);
        }

        [HttpPost]
        public IActionResult Edit(CVViewModel cvViewModel)
        {
            if (ModelState.IsValid)
            {
                var cvDTO = _mapper.Map<CVDTO>(cvViewModel);
                _cvService.UpdateCV(cvDTO);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _cvService.DeleteCV(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var cvDTO = _cvService.GetCVById(id);
            var cvViewModel = _mapper.Map<CVViewModel>(cvDTO);
            return View(cvViewModel);
        }

        [HttpGet]

        public IActionResult Error()
        {
            return View();
        }
   
    
  
       

    }
}