using CRUD1.Entities;

namespace CRUD1.Data
{
    public interface IAllUsers
    {
        public List<UserInfo> userInfos { get; set; }

    }
    public class AllUsers : IAllUsers
    {
        public List<UserInfo> userInfos { get; set; } = new List<UserInfo>
        {
            new UserInfo
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = "Richard",
                LastName = "Amo Mante",
                Email = "amomanterichard@gmail.com"
            },
             new UserInfo
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = "Samuel",
                LastName = "Amo Mante",
                Email = "amomanterichard@gmail.com"
            },
              new UserInfo
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = "Alfred",
                LastName = "Amo Mante",
                Email = "amomanterichard@gmail.com"
            },
               new UserInfo
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = "James",
                LastName = "Amo Mante",
                Email = "amomanterichard@gmail.com"
            }
        };

    }
}
