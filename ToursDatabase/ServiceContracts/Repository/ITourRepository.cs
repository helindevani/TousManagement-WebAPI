﻿using ToursDatabase.Domain.Entities;
using ToursDatabase.DTO;

namespace ToursDatabase.ServiceContracts.Repository
{
    public interface ITourRepository
    {
        Task<IEnumerable<TourDTO>> GetToursAsync(int? minRating, int? maxRating, string difficultyLevel, string sortBy, DateTime? startDate);
        Task<TourDTO> GetTourByIdAsync(Guid id);
        Task<TourDTO> AddTourAsync(TourDTO tourDTO);
        Task<bool> UpdateTourAsync(Guid id, TourDTO tourDTO);
        Task<bool> DeleteTourAsync(Guid id);
    }
}
