namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> userInfos = new();

        static Repository() 
        {
            userInfos.Add(new UserInfo { Id = 1 ,Name="Ali",Email="abc@gmail.com",Phone="121212",WillAttend=false});
            userInfos.Add(new UserInfo { Id = 2, Name = "Ahmet", Email = "a6c@gmail.com", Phone = "121212", WillAttend = true });
            userInfos.Add(new UserInfo { Id = 3, Name = "Canan", Email = "arc@gmail.com", Phone = "121212", WillAttend = true });

        }
        
        public static List<UserInfo> users{ get 
            {
                return userInfos;
            } }

        public static void Create(UserInfo userInfo) 
        {
            userInfo.Id = users.Count + 1;
            userInfos.Add(userInfo);
        }

        public static UserInfo? GetById(int id) 
        {
            return userInfos.FirstOrDefault(user => user.Id == id);
        }
    }
}
