namespace TechExam1.Interface
{
    public interface IStringOrganizerService
    {
        //need to remove task because this method return an int and completely synchronous. The async await method is now define in the controller.
        //Task<int> GetNumberOfUniqueCharacterFromString(string input);
        public int GetNumberOfUniqueCharacterFromString(string input);
    }
}
