﻿using DOTNET_CORE_WEBAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOTNET_CORE_WEBAPI.Services
{
    public interface ICityInfoRepository
    {
        bool CityExists(int cityId);
        IEnumerable<City> GetCities();
        City GetCity(int cityId, bool includePointsOfInterest);
        IEnumerable<PointOfInterest> GetPointsOfInterestForCity(int cityId);
        PointOfInterest GetPointOfInterestForCity(int cityId, int pointOfInterestId);
        void AddPointOfInterestForCity(int cityId, PointOfInterest pointOfInterest);
        void DeletePointOfInterest(PointOfInterest pointOfInterestEntity);
        bool Save();
        
    }
}
