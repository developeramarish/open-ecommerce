using Core.Modules.Shared.Messaging.IntegrationEvents.HumanResources.Events.Contracts;
using Core.Modules.UserAccess.Domain.Contracts.Contexts;
using Core.Modules.UserAccess.Domain.Contracts.Messaging.Commands;
using MassTransit;
using Microsoft.EntityFrameworkCore;

namespace Core.Modules.UserAccess.Application.Messaging.Commands.RemoveCollaboratorSector;

internal class RemoveCollaboratorSectorCommandHandler : IRemoveCollaboratorSector
{
    private readonly IUserAccessContext _dbContext;

    public RemoveCollaboratorSectorCommandHandler(IUserAccessContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task Consume(ConsumeContext<BrokeContractIntegrationEvent> context)
    {
        var collaborator = await _dbContext.Collaborators
            .FirstOrDefaultAsync(c => c.CollaboratorModuleId == context.Message.CollaboratorId);

        if (collaborator is null)
        {
            return;
        }

        collaborator.Sectors.Remove(context.Message.Sector);
        await _dbContext.SaveChangesAsync();
    }
}