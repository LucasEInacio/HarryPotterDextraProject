using Flunt.Validations;
using HarryPotterProject.Domain.Commom;
using HarryPotterProject.Domain.Commom.Interfaces;
using HarryPotterProject.Domain.Resources;

namespace HarryPotterProject.Domain.Characters.Dtos
{
    public class CharacterRequest : RequestBase, IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string School { get; set; }
        public string House { get; set; }
        public string Patronus { get; set; }

        public void Validate()
        {
            var contract = new Contract();

            contract.IsNotNullOrEmpty(Name, nameof(Name), string.Format(Translate.Required_Field, nameof(Name)));
            contract.IsNotNullOrEmpty(Role, nameof(Role), string.Format(Translate.Required_Field, nameof(Role)));
            contract.IsNotNullOrEmpty(School, nameof(School), string.Format(Translate.Required_Field, nameof(School)));
            contract.IsNotNullOrEmpty(House, nameof(House), string.Format(Translate.Required_Field, nameof(House)));
            contract.IsNotNullOrEmpty(Patronus, nameof(Patronus), string.Format(Translate.Required_Field, nameof(Patronus)));

            AddNotifications(contract);
        }
    }
}
