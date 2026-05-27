using BlogTok.Controllers;
using BlogTok.Data;
using BlogTok.Data.Enums;
using BlogTok.Data.Models;
using BlogTok.Tests.Helpers;

namespace BlogTok.Tests;

public class UserControllerTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Login_User_1()
    {
        var context = TestDBFactory.CreateDbContext();

        string email = "testuser";
        string hashedPassword = "hashedpassword";
        string firstName = "Test";
        string surname = "User";
        DateOnly birthDate = new DateOnly(1990, 1, 1);
        string profilePic = "profilepic.jpg";
        RoleType role = RoleType.User;

        context.Users.Add(new Data.Models.User
        {
            Email = email,
            HashedPassword = hashedPassword,
            FirstName = firstName,
            Surname = surname,
            BirthDate = birthDate.ToDateTime(new TimeOnly(0, 0)),
            ProfilePic = profilePic,
            Role = role
        });

        await context.SaveChangesAsync();

        UserController controller = new UserController(context);
        var user = await controller.LoginAsync(email, hashedPassword);

        Assert.IsTrue(user.Success);
        Assert.IsNotNull(user.User);

        Assert.AreEqual(email, user.User.Email);
        Assert.AreEqual(hashedPassword, user.User.HashedPassword);
        Assert.AreEqual(firstName, user.User.FirstName);
        Assert.AreEqual(surname, user.User.Surname);
        Assert.That(user.User.BirthDate, Is.EqualTo(birthDate.ToDateTime(new TimeOnly(0, 0))));
        Assert.AreEqual(profilePic, user.User.ProfilePic);
        Assert.AreEqual(role, user.User.Role);

        Assert.AreEqual("Login successful", user.Message);
    }
    [Test]
    public async Task Login_User_2()
    {
        var context = TestDBFactory.CreateDbContext();

        string email = "nonexistentuser";
        string hashedPassword = "hashedpassword";
        string firstName = "Test";
        string surname = "User";
        DateOnly birthDate = new DateOnly(1990, 1, 1);
        string profilePic = "profilepic.jpg";
        RoleType role = RoleType.User;

        context.Users.Add(new Data.Models.User
        {
            Email = "testuser",
            HashedPassword = hashedPassword,
            FirstName = firstName,
            Surname = surname,
            BirthDate = birthDate.ToDateTime(new TimeOnly(0, 0)),
            ProfilePic = profilePic,
            Role = role
        });
        await context.SaveChangesAsync();

        string wrongEmail = "wrongemail";
        UserController controller = new UserController(context);
        var user = await controller.LoginAsync(wrongEmail, hashedPassword);

        Assert.IsFalse(user.Success);
        Assert.IsNull(user.User);
        Assert.AreEqual("Wrong email or password! Try again", user.Message);
    }
    [Test]
    public async Task Login_User_3()
    {
        var context = TestDBFactory.CreateDbContext();

        string email = "nonexistentuser";
        string hashedPassword = "hashedpassword";
        string firstName = "Test";
        string surname = "User";
        DateOnly birthDate = new DateOnly(1990, 1, 1);
        string profilePic = "profilepic.jpg";
        RoleType role = RoleType.User;

        context.Users.Add(new Data.Models.User
        {
            Email = "testuser",
            HashedPassword = hashedPassword,
            FirstName = firstName,
            Surname = surname,
            BirthDate = birthDate.ToDateTime(new TimeOnly(0, 0)),
            ProfilePic = profilePic,
            Role = role
        });
        await context.SaveChangesAsync();

        string wrongPassword = "wrongemail";
        UserController controller = new UserController(context);
        var user = await controller.LoginAsync(email, wrongPassword);

        Assert.IsFalse(user.Success);
        Assert.IsNull(user.User);
        Assert.AreEqual("Wrong email or password! Try again", user.Message);
    }
}
