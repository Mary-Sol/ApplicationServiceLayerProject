using System.Runtime.InteropServices;

namespace ApplicationServiceLayer.ApplicationService.Dtos.PersonDtos
{
    public class DeletePersonDtos
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
