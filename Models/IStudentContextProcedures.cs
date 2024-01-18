﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using BlazorApp.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public partial interface IStudentContextProcedures
    {
        Task<int> BackStudentAsync(int? StudentId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteSoftAsync(int? StudentId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetAllSkillsStudentResult>> GetAllSkillsStudentAsync(int? StudentId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<RestoreStudentResult>> RestoreStudentAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<StudentDeleteByIdResult>> StudentDeleteByIdAsync(int? StudentId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> StudentDeleteByyIdAsync(int? StudentId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> StudentEditAsync(int? StudentId, string StudName, int? StudAge, string StudEmail, string StudDepartment, string Skills, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<StudentViewAllResult>> StudentViewAllAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<StudentViewByIdResult> StudentViewByIdAsync(int? StudentId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
