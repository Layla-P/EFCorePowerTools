﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using ConsoleApp.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public partial interface IChinookContextProcedures
    {
        Task<List<GetTitlesResult>> GetTitlesAsync(string Title, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
