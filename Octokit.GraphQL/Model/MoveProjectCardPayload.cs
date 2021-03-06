namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of MoveProjectCard
    /// </summary>
    public class MoveProjectCardPayload : QueryableValue<MoveProjectCardPayload>
    {
        public MoveProjectCardPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// The new edge of the moved card.
        /// **Upcoming Change on 2019-01-01 UTC**
        /// **Description:** Type for `cardEdge` will change from `ProjectCardEdge!` to `ProjectCardEdge`.
        /// **Reason:** In preparation for an upcoming change to the way we report mutation errors, non-nullable payload fields are becoming nullable.
        /// </summary>
        public ProjectCardEdge CardEdge => this.CreateProperty(x => x.CardEdge, Octokit.GraphQL.Model.ProjectCardEdge.Create);

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        internal static MoveProjectCardPayload Create(Expression expression)
        {
            return new MoveProjectCardPayload(expression);
        }
    }
}