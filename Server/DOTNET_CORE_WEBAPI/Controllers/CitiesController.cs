using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOTNET_CORE_WEBAPI.Models;
using DOTNET_CORE_WEBAPI.Services;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Microsoft.AspNetCore.Cors;

namespace DOTNET_CORE_WEBAPI.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        private ICityInfoRepository _cityInfoRepository;

        public CitiesController(ICityInfoRepository cityInfoRepository)
        {
            _cityInfoRepository = cityInfoRepository;
        }
        [HttpGet()]
        [EnableCors("AllowOrigin")]
        public IActionResult GetCities()
        {
            var cityEntities = _cityInfoRepository.GetCities();
            
            var results = Mapper.Map<IEnumerable<CityDto>>(cityEntities);
            
            return Ok(results);
            
        }


        //api/cities/1?includePointsOfInterest=true
        [HttpGet("{id}")]
        public IActionResult GetCity(int id, bool includePointsOfInterest = false)
        {
            var city = _cityInfoRepository.GetCity(id, includePointsOfInterest);

            if (city == null)
            {
                return NotFound();
            }

            if (includePointsOfInterest)
            {
                var cityResult = Mapper.Map<CityDto>(city);
                return Ok(cityResult);
            }

            //Refactory
            var cityWithoutPointsOfInterestResult = Mapper.Map<CityWithoutPointOfInterestDto>(city);
            return Ok(cityWithoutPointsOfInterestResult);
            //var city = _cityInfoRepository.GetCity(id, includePointsOfInterest);

            //if(city == null)
            //{
            //    return NotFound();
            //}

            //if (includePointsOfInterest)
            //{
            //    //var result = new CityDto()
            //    //{
            //    //    Id = cityEntity.Id,
            //    //    Name = cityEntity.Name,
            //    //    Description = cityEntity.Description
            //    //};

            //    //foreach (var poi in cityEntity.PointOfInterests)
            //    //{
            //    //    result.PointsOfInterest.Add(
            //    //        new PointOfInterestDto()
            //    //        {
            //    //            Id = poi.Id,
            //    //            Name = poi.Name,
            //    //            Description = poi.Description
            //    //        }
            //    //    );
            //    //}
            //    var result = Mapper.Map<CityDto>(city);
            //    return Ok(result);
            //}

            ////var cityWithoutPointsOfInterestResult = new CityWithoutPointOfInterestDto()
            ////{
            ////    Id = cityEntity.Id,
            ////    Name = cityEntity.Name,
            ////    Description = cityEntity.Description
            ////};
            //var cityWithoutPointsOfInterestResult = Mapper.Map<CityWithoutPointOfInterestDto>(city);

            //return Ok(cityWithoutPointsOfInterestResult);

        }
    }


}