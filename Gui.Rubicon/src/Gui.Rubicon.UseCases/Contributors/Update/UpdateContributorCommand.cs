using Gui.Rubicon.Core.ContributorAggregate;

namespace Gui.Rubicon.UseCases.Contributors.Update;

public record UpdateContributorCommand(ContributorId ContributorId, ContributorName NewName) : ICommand<Result<ContributorDto>>;
