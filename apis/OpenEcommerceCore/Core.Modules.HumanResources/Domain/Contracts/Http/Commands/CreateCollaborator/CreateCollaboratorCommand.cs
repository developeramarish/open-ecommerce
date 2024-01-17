using Core.Modules.HumanResources.Domain.Entities;
using Core.Modules.HumanResources.Domain.Enums;
using Core.Modules.Shared.Domain.BusinessHierarchy;
using MediatR;

namespace Core.Modules.HumanResources.Domain.Contracts.Http.Commands.CreateCollaborator;

public record CreateCollaboratorCommand : IRequest<CreateCollaboratorCommandResponse>
{
    public string FirstName { get; init; }
    public string? LastName { get; init; }
    public string? Description { get; init; }
    public int Age { get; init; }
    public string Email { get; init; }
    public string Phone { get; init; }
    public List<Contract> Contracts { get; init; }
    public List<SocialLink> SocialLinks { get; init; } 
    public List<Address> Addresses { get; init; }
    
    public record Contract
    {
        public string Name { get; init; }
        public ECollaboratorSector Sector { get; init; }
        public List<ContributionYears> ContributionsYears { get; init; }
        public DateTime StartDate { get; init; }
        public DateTime EndDate { get; init; }
        public decimal MonthlySalary { get; init; }
        public bool Broken { get; init; }

        public record ContributionYears
        {
            public int Year { get; init; }
            public List<WorkHour> WorkHours { get; init; }

            public record WorkHour
            {
                public DateTime Date { get; init; }
                public TimeSpan Start { get; init; }
                public TimeSpan End { get; init; }
            }
        }
    }

    public record Address
    {
        public Guid StateId { get; init; }
        public int ZipCode { get; init; }
        public string Neighbourhood { get; init; }
        public string Street { get; init; }
    }
      
    public record SocialLink
    {
        public SocialMedia SocialMedia { get; init; }
        public string Url { get; init; }
    }

};



