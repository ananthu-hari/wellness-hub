﻿using ExerciseServiceAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExerciseServiceAPI.Repository
{
    public interface IExerciseLogRepository
    {
        Task<IEnumerable<ExerciseLog>> GetExerciseLogsAsync();
        Task<ExerciseLog> GetExerciseLogByIdAsync(int logId);
        Task InsertExerciseLogAsync(ExerciseLog exerciseLog);
        Task UpdateExerciseLogAsync(ExerciseLog exerciseLog);
        Task DeleteExerciseLogAsync(int logId);
        Task<IEnumerable<ExerciseLog>> GetLogsForPast7DaysAsync(string userName);
        Task<List<ExerciseLog>> GetExerciseLogsByUsernameAndDateAsync(string username, DateTime date);
        Task<List<ExerciseLog>> GetExerciseLogsByUsernameAsync(string username);
    }
}