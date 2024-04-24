namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();
        static Repository()
        {
            _users.Add(new() {Id=1, Name="Ali", Email="email1@email.com", Phone="111", WillAttend=true});
            _users.Add(new() {Id=2, Name="Berk", Email="email2@email.com", Phone="222", WillAttend=false});
            _users.Add(new() {Id=3, Name="Ceren", Email="email3@email.com", Phone="333", WillAttend=true});
            _users.Add(new() {Id=4, Name="Deniz", Email="email4@email.com", Phone="444", WillAttend=true});
        }

        public static List<UserInfo> Users
        {
            get{
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int? id)
        {
            return _users.FirstOrDefault(t=>t.Id == id);
        }
    }
}