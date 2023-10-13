<<<<<<< HEAD
﻿using InternIngressInternal.Intern.Application.DTOs; // We have DTOs defined in your Application layer
using InternIngressInternal.Intern.Application.Services; // We have service interfaces defined in your Application layer
using InternIngressInternal.Intern.Web.Models; // ViewModels specific to your Web project
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
=======
﻿using InternIngressInternal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
>>>>>>> 381f5bcd1dc8994e048975415536031dcf9c4a2d

namespace InternIngressInternal.Intern.Web.Controllers
{
    public class CVController : Controller
    {
<<<<<<< HEAD
        private readonly ICVService _cvService;
        private readonly IMapper _mapper;

        public CVController(ICVService cvService, IMapper mapper)
        {
            _cvService = cvService;
            _mapper = mapper;
=======
        private readonly ILogger<CVController> _logger;

        public CVController(ILogger<CVController> logger)
        {
            _logger = logger;
>>>>>>> 381f5bcd1dc8994e048975415536031dcf9c4a2d
        }

        public IActionResult Index()
        {
<<<<<<< HEAD
            var cvDTOs = _cvService.GetAllCVs();
            var cvViewModels = _mapper.Map<IEnumerable<CVViewModel>>(cvDTOs);
            return View(cvViewModels);
        }

        [HttpGet]
        public IActionResult Create()
=======
            return View();
        }

        public IActionResult Privacy()
>>>>>>> 381f5bcd1dc8994e048975415536031dcf9c4a2d
        {
            return View();
        }

<<<<<<< HEAD
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
   
    
  
       

=======
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
>>>>>>> 381f5bcd1dc8994e048975415536031dcf9c4a2d
    }
}