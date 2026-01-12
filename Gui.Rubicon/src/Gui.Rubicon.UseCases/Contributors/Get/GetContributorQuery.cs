using Gui.Rubicon.Core.ContributorAggregate;

namespace Gui.Rubicon.UseCases.Contributors.Get;

public record GetContributorQuery(ContributorId ContributorId) : IQuery<Result<ContributorDto>>;
