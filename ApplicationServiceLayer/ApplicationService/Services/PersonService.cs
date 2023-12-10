using ApplicationServiceLayer.ApplicationService.Contracts;
using ApplicationServiceLayer.ApplicationService.Dtos.PersonDtos;
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

        public async Task DeleteByIdAsync(Guid Id)
        {
             await _personRepository.Delete(Id);
           
        }

        public async Task DeleteAsync(DeletePersonDtos deletePerson)
        {
            var DeletedPerson = await _personRepository.SelectById(deletePerson.Id);
            if (DeletedPerson != null) {

                 await _personRepository.Delete(DeletedPerson);
                
            }
        }

        public async Task InsertAsync(CreatePersonDtos createPersonDtos)
        {
            if (createPersonDtos is null) return false;
            var createPerson = new Person()
            {
                Id = new Guid(),
                FirstName = createPersonDtos.FirstName,
                LastName = createPersonDtos.LastName,
            };
            var result = await _personRepository.Insert(createPerson);
            return result;

        }

        public async Task SaveAsync()
        {
            await _personRepository.Save();
        }

        public async Task<SelectPersonDtos> SelectByIdAsync(Guid Id)
        {
            var selectperson = await _personRepository.SelectById;
            if (selectperson != null)
            {
                var selectpersonDto = new SelectPersonDtos();
                id = selectperson.Id,
                FirstName = selectperson.FirstName,
                LastName = selectperson.LastName
                    }
            return selectpersonDto;
        }

        public async Task<IEnumerable<SelectPersonDtos>> SelectAll()
        {
            List<SelectPersonDtos> persDto = new List<SelectPersonDtos>();
            var personDto = await _personRepository.SelectAll();
            foreach (var person in personDto)
            {
                var personDto = new SelectPersonDtos();
                id = person.Id,
                FirstName = person.FirstName,
                LastName = person.LastName
            };
            persDto.Add(personDto);
        }



        public async Task UpdateAsync(UpdatePersonDtos updatePersonDtos)
        {
            var updatePerson = await _personRepository.SelectById(updatePersonDtos.Id);
            if (updatePerson != null)
            {
                updatePerson.FirstName = updatePerson.FirstName;
                updatePerson.LastName = updatePerson.LastName;
                var result = await _personRepository.Update(updatePerson);
                return result;
            }

        }
    }
}


