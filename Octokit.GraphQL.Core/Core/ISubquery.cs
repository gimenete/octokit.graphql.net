﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Octokit.GraphQL.Core
{
    /// <summary>
    /// Represents a query which fetches subsequent pages of data after a master query has run.
    /// </summary>
    public interface ISubquery
    {
        /// <summary>
        /// Gets a method which reads the query paging information from subquery results.
        /// </summary>
        Func<JObject, JToken> PageInfo { get; }

        /// <summary>
        /// Gets a method which reads the query paging information the master query results.
        /// </summary>
        Func<JObject, JToken> ParentPageInfo { get; }

        /// <summary>
        /// Gets a query runner to run the query to completion.
        /// </summary>
        /// <param name="connection">The connection on which to run the query.</param>
        /// <param name="after">The end cursor from the master query.</param>
        /// <param name="variables">The query variables.</param>
        /// <returns>An <see cref="IQueryRunner"/>.</returns>
        IQueryRunner Start(
            IConnection connection,
            string after,
            IDictionary<string, object> variables);
    }
}