using ApplicationServiceLayer.ApplicationService.Contracts;
using ApplicationServiceLayer.ApplicationService.Dtos.PersonDtos;
using ApplicationServiceLayer.Models.DomainModels.PersonAggregates;
using ApplicationServiceLayer.Models.Services.Contracts;
namespace ApplicationServiceLayer.ApplicationService.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        async Task<IEnumerable<SelectPersonDtos>> SelectAll()
        {
            List<SelectPersonDtos> employdto = new List<SelectPersonDtos>();
            var Employes = await _personRepository.SelectAll();
            foreach (var person in Employes)
            {
                var personDto = new SelectPersonDtos()
                {
                    Id = person.Id,
                    FirstName = person.FirstName,
                    LastName = person.LastName
                };
                employdto.Add(personDto);
            }
           
        }

        public async Task<SelectPersonDtos> Select(Guid id)
        {
            var selectperson = await _personRepository.SelectById(id);
            if (selectperson != null)
            {
                var selectpersonDto = new SelectPersonDtos()
                {
                    Id = selectperson.Id,
                    FirstName = selectperson.FirstName,
                    LastName = selectperson.LastName
                };
                return selectpersonDto;
            }
           
        }

        public async Task Insert(CreatePersonDtos createpersondto)
        {
            var createperson = new Person()
            {
                Id = new Guid(),
                FirstName = createpersondto.FirstName,
                LastName = createpersondto.LastName,
            };

            await _personRepository.Insert(createperson);
            
        }

        public async Task Update(UpdatePersonDtos updatePersondto)
        {
            var updatePerson = await _personRepository.SelectById(updatePersondto.Id);
            if (updatePerson != null)
            {
                updatePerson.FirstName = updatePersondto.FirstName;
                updatePerson.LastName = updatePersondto.LastName;
                 await _personRepository.Update(updatePerson);
                
            }
        }

        public async Task Delete(Guid id)
        {
            await _personRepository.Delete(id);
        }

        public async Task Delete(DeletePersonDtos deletePersondto)
        {
            var DeletedPerson = await _personRepository.SelectById(deletePersondto.Id);
            if (DeletedPerson != null)
            {

                await _personRepository.Delete(DeletedPerson);

            }
        }

        public async Task Save()
        {
            await _personRepository.Save();
        }
    }

       
        
}


