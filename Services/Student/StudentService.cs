using Common.Exceptions;
using Models.Dto;
using Services.Delegate;
using System.Threading.Tasks;

namespace Services
{
    public class StudentService : IStudentService
    {
        public async Task Add(StudentQuery model)
        {
            model.InputValidation(Validation);
        }

        public void Validation(StudentQuery model)
        {
            if (string.IsNullOrWhiteSpace(model.FullName))
                throw new InvalidInputException(nameof(model.FullName));

            if (model.FullName.Length > 20)
                throw new InvalidLengthException(model.FullName);
        }
    }
}