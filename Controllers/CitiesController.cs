using System.Collections.Generic;
using AutoMapper;
using CityGuide.API.Data;
using CityGuide.API.Dtos;
using CityGuide.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityGuide.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly IAppRepository _appRepository;
        private readonly IMapper _mapper;

        public CitiesController(IAppRepository appRepository, IMapper mapper)
        {
            _appRepository = appRepository;
            _mapper = mapper;
        }

        public ActionResult GetCities()
        {
            var cities = _appRepository.GetCities();
            var citiesToReturn = _mapper.Map<List<CityForListDto>>(cities);
            return Ok(citiesToReturn);
        }
        [HttpPost]
        [Route("add")]
        public ActionResult Add([FromBody]City city)
        {
            _appRepository.Add(city);
            _appRepository.SaveAll();
            return Ok(city);

        }
        [HttpGet]
        [Route("detail")]
        public ActionResult GetCityById(int id)
        {
            var city = _appRepository.GetCityById(id);
            var cityToReturn = _mapper.Map<CityForDetailDto>(city);
            return Ok(cityToReturn);
        }

        [HttpGet]
        [Route("photos")]
        public ActionResult GetPhotosByCity(int cityId)
        {
            var photos = _appRepository.GetPhotosByCity(cityId);
            return Ok(photos);
        }

    }
}