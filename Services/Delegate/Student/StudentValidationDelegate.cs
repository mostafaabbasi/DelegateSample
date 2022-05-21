using Common.Exceptions;
using Models.Dto;
using System;

namespace Services.Delegate
{
    public static class StudentValidationDelegate
    {
        public static void InputValidation(this StudentQuery model, Action<StudentQuery> action)
        {
            try
            {
                action(model);
            }
            catch (InvalidInputException exception)
            {
                throw exception;
            }
            catch (InvalidLengthException exception)
            {
                throw exception;
            }
            finally
            {

            }
        }
    }
}
