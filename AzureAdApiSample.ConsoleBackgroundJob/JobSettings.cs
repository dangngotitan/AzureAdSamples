﻿namespace AzureAdApiSample.ConsoleBackgroundJob
{
    public class JobSettings
    {
        public string Authority { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string ApiResourceUri { get; set; }
        public string ApiBaseUrl { get; set; }
    }
}
