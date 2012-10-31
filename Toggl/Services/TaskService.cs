﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Toggl.Properties;

namespace Toggl.Services
{
    public class TaskService
    {
        private readonly string TogglTasksUrl = ApiRoutes.Task.TogglTasksUrl;
        

        private ITogglService ToggleSrv { get; set; }


        public TaskService(string apiKey)
            : this(new TogglService(apiKey))
        {

        }

        public TaskService()
            : this(new TogglService())
        {
        }

        public TaskService(ITogglService srv)
        {
            ToggleSrv = srv;
        }

        public List<Task> GetTasks()
        {
            return ToggleSrv.GetResponse(TogglTasksUrl).GetData<List<Task>>();
        }
       
        public Task Add(Task t)
        {
            return ToggleSrv.PostResponse(TogglTasksUrl, t.ToJson()).GetData<Task>();
        }
    }
}