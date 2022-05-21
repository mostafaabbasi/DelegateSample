using Models.Dto;
using System.Threading.Tasks;

namespace Services
{
    public interface IStudentService
    {
        Task Add(StudentQuery model);
    }
}
