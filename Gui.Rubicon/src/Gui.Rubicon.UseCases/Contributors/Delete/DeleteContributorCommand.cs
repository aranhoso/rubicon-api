using Gui.Rubicon.Core.ContributorAggregate;

namespace Gui.Rubicon.UseCases.Contributors.Delete;

public record DeleteContributorCommand(ContributorId ContributorId) : ICommand<Result>;
