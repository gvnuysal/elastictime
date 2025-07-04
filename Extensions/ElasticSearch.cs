﻿using Elasticsearch.Net;
using Nest;

namespace GvnAtlas.ElasticSearchAPI.Extensions
{
    public static class ElasticSearch
    {
        public static void AddElasticSearch(this IServiceCollection services, IConfiguration configuration)
        {
            var pool = new SingleNodeConnectionPool(new Uri(configuration.GetSection("Elastic")["Url"]!));
            var settings = new ConnectionSettings(pool);
            var client = new ElasticClient(settings);
            services.AddSingleton(client);
        }
    }
}
