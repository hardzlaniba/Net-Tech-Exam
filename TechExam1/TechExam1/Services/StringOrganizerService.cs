using System;
using TechExam1.Interface;

namespace TechExam1.Services
{
    public class StringOrganizerService : IStringOrganizerService
    {
        private readonly GetUnique _getUnique;
        private readonly StringHelper _stringHelper;
        public StringOrganizerService(GetUnique getUnique, StringHelper stringHelper)
        {
            _getUnique = getUnique;
            _stringHelper = stringHelper;
        }

        //need to remove task because this method return an int and completely synchronous. The async awi
        /*public int GetNumberOfUniqueCharacterFromString(string input)
        {
            //_getUnique.characters = _stringHelper.ConvertToListString(input);
            //int count = _getUnique.GetNumberOfUniqueCharacter().ToList().Count();  

            //return count;

            //need to apply an await operator here, if not then the program continues without waiting for the task to complete.
            //_getUnique.characters = _stringHelper.ConvertToListString(input);
            //var result = await Task.Run(() =>
            //{
            //    return _getUnique.GetNumberOfUniqueCharacter().ToList().Count();
            //}).ConfigureAwait(false);

            _getUnique.characters = _stringHelper.ConvertToListString(input);
            int count = _getUnique.GetNumberOfUniqueCharacter().ToList().Count();

            return Task.FromResult(count);
        }*/

        //need to remove task because this method return an int and completely synchronous. The async await method is already define on the controller.
        public int GetNumberOfUniqueCharacterFromString(string input)
        {
            _getUnique.characters = _stringHelper.ConvertToListString(input);
            int count = _getUnique.GetNumberOfUniqueCharacter().ToList().Count();

            return count;
        }


    }
}
