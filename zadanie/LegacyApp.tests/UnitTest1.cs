namespace LegacyApp.tests;

public class UnitTest1
{
    [Fact]
    public void GetTest()
    {
        UserService us = new UserService();
        us.AddUser("Jan", "Kowalski", "kowalski@wp.pl",
            new DateTime(2002, 01, 10), 1);
        
        Client client = new Client();
        var id = client.ClientId;
        var address = client.Address;
        var mail = client.Email;
        var addres = client.Type;
        var name = client.Name;
        User user = new User();
        var cl = user.Client;
        var umail = user.EmailAddress;
        var ufn = user.FirstName;

    }
    
    [Fact]
    
    public void UserService()
}