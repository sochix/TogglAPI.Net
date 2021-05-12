using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Toggl
{
    public static class ApiRoutes
    {
	    private const string TogglBaseUrl                           = "https://api.track.toggl.com/api/v8";
		private const string TogglReportUrl                         = "https://api.track.toggl.com/reports/api/v2";

	    public static class Reports
        {
            public static readonly string Detailed                  = TogglReportUrl + "/details";
            public static readonly string Weekly                    = TogglReportUrl + "/weekly";
            public static readonly string Summary                   = TogglReportUrl + "/summary";
        }

        public static class Session
        {
            public readonly static string Me                        = TogglBaseUrl + "/me";
        }
        
        public static class Client
        {
            public readonly static string ClientsUrl                = TogglBaseUrl + "/clients";
            public readonly static string ClientUrl                 = TogglBaseUrl + "/clients/{0}";
            public readonly static string ClientProjectsUrl         = TogglBaseUrl + "/clients/{0}/projects";    
        }

        public static class Workspace
        {
            public readonly static string ListWorkspaceUrl          = TogglBaseUrl + "/workspaces";
            public readonly static string AddWorkspaceUserUrl       = TogglBaseUrl + "/workspaces/{0}/project_users";
            public readonly static string ListWorkspaceUsersUrl     = TogglBaseUrl + "/workspaces/{0}/users";
            public readonly static string ListWorkspaceProjectsUrl  = TogglBaseUrl + "/workspaces/{0}/projects";
            public readonly static string ListWorkspaceClientsUrl   = TogglBaseUrl + "/workspaces/{0}/clients";
            public readonly static string ListWorkspaceTasksUrl     = TogglBaseUrl + "/workspaces/{0}/tasks";
            public readonly static string ListWorkspaceTagsUrl      = TogglBaseUrl + "/workspaces/{0}/tags";
        }

        public static class Task
        {
            public readonly static string TogglTasksUrl             = TogglBaseUrl + "/tasks";
            public readonly static string TogglTasksGet             = TogglBaseUrl + "/tasks/{0}";            
        }

        public static class TimeEntry
        {
            public readonly static string TimeEntriesUrl            = TogglBaseUrl + "/time_entries";
            public readonly static string TimeEntryStartUrl         = TogglBaseUrl + "/time_entries/start";
            public readonly static string TimeEntryStopUrl          = TogglBaseUrl + "/time_entries/{0}/stop";
            public readonly static string TimeEntryUrl              = TogglBaseUrl + "/time_entries/{0}";
            public readonly static string TimeEntryCurrentUrl       = TogglBaseUrl + "/time_entries/current";
        }

        public static class Project
        {
			public readonly static string ProjectsBulkDeleteUrl     = TogglBaseUrl + "/projects/{0}";
            public readonly static string ProjectsUrl               = TogglBaseUrl + "/projects";
            public readonly static string DetailUrl                 = TogglBaseUrl + "/projects/{0}";
            public readonly static string UsersUrl                  = TogglBaseUrl + "/projects/{0}/project_users";
            public readonly static string ProjectTasksUrl           = TogglBaseUrl + "/projects/{0}/tasks";
        }

        public static class User
        {
            public static readonly string CurrentUrl                = TogglBaseUrl + "/me";
            public static readonly string CurrentExtendedUrl        = TogglBaseUrl + "/me?with_related_data=true";
            public static readonly string CurrentSinceUrl           = TogglBaseUrl + "/me?since={0}&with_related_data=true";
            public static readonly string ResetApiTokenUrl          = TogglBaseUrl + "/reset_token";
            public static readonly string EditUrl                   = TogglBaseUrl + "/me";
            public static readonly string AddUrl                    = TogglBaseUrl + "/signups";
        }

        public static class Dashboard
        {
            public static readonly string DashboardUrl              = TogglBaseUrl + "/dashboard/{0}";
        }

        public static class Tag
        {
            public readonly static string TagsUrl = TogglBaseUrl + "/tags";
        }
    }
}
