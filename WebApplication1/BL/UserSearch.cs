using Models;
using DL;
namespace BL
{
    public class UserSearch
    {
        readonly IRepo<UserModel> repo;
        public UserSearch(IRepo<UserModel> repo)
        {
            this.repo = repo;
        }


        public List<UserModel> GetAllUser()
        {
            //UserRepository userRepository =new userRepository();
            List<UserModel> userList = repo.GetItemFromDB();
            return userList;
        }
    }
}