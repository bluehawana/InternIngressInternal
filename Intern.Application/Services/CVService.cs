namespace Intern.Application;
using AutoMapper;
using Intern.Application.DTOs;
using Intern.Domain.Entities;
using Intern.Application.Services; 
using System.Threading.Tasks;

public class CVService
{
    private readonly IMapper _mapper;
    private readonly IInternRepository _internRepository;

    public CVService(IMapper mapper, IInternRepository internRepository)
    {
        _mapper = mapper;
        _internRepository = internRepository;
    }

    public async Task<CVViewModel> GetCVAsync()
    {
        var cv = await _internRepository.GetCVAsync();
        var cvViewModel = _mapper.Map<CVViewModel>(cv);
        return cvViewModel;
    }

    public async Task UpdateCVAsync(CVViewModel cvViewModel)
    {
        var cv = _mapper.Map<CV>(cvViewModel);
        await _internRepository.UpdateCVAsync(cv);
    }

}
