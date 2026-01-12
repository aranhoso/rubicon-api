using Gui.Rubicon.Core.ContributorAggregate;
using Vogen;

namespace Gui.Rubicon.Infrastructure.Data.Config;

[EfCoreConverter<ContributorId>]
[EfCoreConverter<ContributorName>]
internal partial class VogenEfCoreConverters;
