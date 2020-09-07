using Flunt.Notifications;
using HarryPotterProject.Domain.Commom.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Generic;
using System.Linq;

namespace HarryPotterProject.Api
{
    public class ApiBase : ControllerBase
    {
        private readonly IService _appService;

        public ApiBase(IService appService)
        {
            _appService = appService;
        }

        protected new IActionResult Response(object result = null)
        {
            if (_appService.Notifications.Any())
                return BadRequest(new
                {
                    success = false,
                    errors = GetErrors()
                });

            return Ok(result);
        }

        private string[] GetErrors()
        {
            var erros = new List<string>();

            if (_appService.Notifications != null)
                erros.AddRange(_appService.Notifications.Select(n => n.Message));

            return erros.ToArray();
        }
    }
}
