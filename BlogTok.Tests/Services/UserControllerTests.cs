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

        context.Users.Add(new User
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

        context.Users.Add(new User
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

        context.Users.Add(new User
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
    [Test]
    public async Task Get_All_Users()
    {
        var context = TestDBFactory.CreateDbContext();

        string email = "nonexistentuser";
        string hashedPassword = "hashedpassword";
        string firstName = "Test";
        string surname = "User";
        DateOnly birthDate = new DateOnly(1990, 1, 1);
        string profilePic = "profilepic.jpg";
        RoleType role = RoleType.User;

        List<User> mockUSERS = new();
        User mockUser = new User
        {
            Email = "testuser",
            HashedPassword = hashedPassword,
            FirstName = firstName,
            Surname = surname,
            BirthDate = birthDate.ToDateTime(new TimeOnly(0, 0)),
            ProfilePic = profilePic,
            Role = role
        };
        mockUSERS.Add(mockUser);

        context.Users.Add(mockUser);
        await context.SaveChangesAsync();

        UserController controller = new(context);
        var users = controller.GetAllUsersAsync();

        Assert.That(users.Result, Is.EquivalentTo(mockUSERS));
        Assert.That(users.Result, Has.Count.EqualTo(1));
    }
    [Test]
    public async Task Register_User_1()
    {
        var context = TestDBFactory.CreateDbContext();

        string email = "nonexistentuser";
        string hashedPassword = "hashedpassword";
        string firstName = "Test";
        string surname = "User";
        DateOnly birthDate = new DateOnly(1990, 1, 1);
        string profilePic = "profilepic.jpg";
        RoleType role = RoleType.User;

        List<User> mockUSERS = new();
        User mockUser = new User
        {
            Email = "testuser",
            HashedPassword = hashedPassword,
            FirstName = firstName,
            Surname = surname,
            BirthDate = birthDate.ToDateTime(new TimeOnly(0, 0)),
            ProfilePic = profilePic,
            Role = role
        };

        UserController controller = new(context);
        var result = await controller.RegisterAsync(mockUser.Email, mockUser.HashedPassword, mockUser.FirstName, mockUser.Surname, birthDate.ToDateTime(new TimeOnly(0, 0)), mockUser.ProfilePic);

        Assert.AreEqual("User registered successfully", result);
    }
    [Test]
    public async Task Register_User_2()
    {
        var context = TestDBFactory.CreateDbContext();

        string email = "";
        string hashedPassword = "hashedpassword";
        string firstName = "Test";
        string surname = "User";
        DateOnly birthDate = new DateOnly(1990, 1, 1);
        string profilePic = "profilepic.jpg";
        RoleType role = RoleType.User;

        List<User> mockUSERS = new();
        User mockUser = new User
        {
            Email = email,
            HashedPassword = hashedPassword,
            FirstName = firstName,
            Surname = surname,
            BirthDate = birthDate.ToDateTime(new TimeOnly(0, 0)),
            ProfilePic = profilePic,
            Role = role
        };

        UserController controller = new(context);
        var result = await controller.RegisterAsync(mockUser.Email, mockUser.HashedPassword, mockUser.FirstName, mockUser.Surname, birthDate.ToDateTime(new TimeOnly(0, 0)), mockUser.ProfilePic);

        Assert.AreEqual("All fields are required", result);
    }
    [TestCase("")]
    public async Task Register_User_3(string passKey)
    {
        var context = TestDBFactory.CreateDbContext();

        string email = "testuser";
        string hashedPassword = passKey;
        string firstName = "Test";
        string surname = "User";
        DateOnly birthDate = new DateOnly(1990, 1, 1);
        string profilePic = "profilepic.jpg";
        RoleType role = RoleType.User;

        List<User> mockUSERS = new();
        User mockUser = new User
        {
            Email = email,
            HashedPassword = hashedPassword,
            FirstName = firstName,
            Surname = surname,
            BirthDate = birthDate.ToDateTime(new TimeOnly(0, 0)),
            ProfilePic = profilePic,
            Role = role
        };

        UserController controller = new(context);
        var result = await controller.RegisterAsync(mockUser.Email, mockUser.HashedPassword, mockUser.FirstName, mockUser.Surname, birthDate.ToDateTime(new TimeOnly(0, 0)), mockUser.ProfilePic);

        Assert.AreEqual("All fields are required", result);
    }
    [TestCase("123")]
    public async Task Register_User_4(string passKey)
    {
        var context = TestDBFactory.CreateDbContext();

        string email = "testuser";
        string hashedPassword = passKey;
        string firstName = "Test";
        string surname = "User";
        DateOnly birthDate = new DateOnly(1990, 1, 1);
        string profilePic = "profilepic.jpg";
        RoleType role = RoleType.User;

        List<User> mockUSERS = new();
        User mockUser = new User
        {
            Email = email,
            HashedPassword = hashedPassword,
            FirstName = firstName,
            Surname = surname,
            BirthDate = birthDate.ToDateTime(new TimeOnly(0, 0)),
            ProfilePic = profilePic,
            Role = role
        };

        UserController controller = new(context);
        var result = await controller.RegisterAsync(mockUser.Email, mockUser.HashedPassword, mockUser.FirstName, mockUser.Surname, birthDate.ToDateTime(new TimeOnly(0, 0)), mockUser.ProfilePic);

        Assert.AreEqual("Password must be at least 6 characters", result);
    }
    [Test]
    public async Task Register_User_5()
    {
        var context = TestDBFactory.CreateDbContext();

        string email = "testuser";
        string hashedPassword = "hashedpassword";
        string firstName = "";
        string surname = "User";
        DateOnly birthDate = new DateOnly(1990, 1, 1);
        string profilePic = "profilepic.jpg";
        RoleType role = RoleType.User;

        List<User> mockUSERS = new();
        User mockUser = new User
        {
            Email = email,
            HashedPassword = hashedPassword,
            FirstName = firstName,
            Surname = surname,
            BirthDate = birthDate.ToDateTime(new TimeOnly(0, 0)),
            ProfilePic = profilePic,
            Role = role
        };

        UserController controller = new(context);
        var result = await controller.RegisterAsync(mockUser.Email, mockUser.HashedPassword, mockUser.FirstName, mockUser.Surname, birthDate.ToDateTime(new TimeOnly(0, 0)), mockUser.ProfilePic);

        Assert.AreEqual("All fields are required", result);
    }
    [Test]
    public async Task Register_User_6()
    {
        var context = TestDBFactory.CreateDbContext();
        string email = "testuser";
        string hashedPassword = "hashedpassword";
        string firstName = "Test";
        string surname = "";
        DateOnly birthDate = new DateOnly(1990, 1, 1);
        string profilePic = "profilepic.jpg";
        RoleType role = RoleType.User;
        List<User> mockUSERS = new();
        User mockUser = new User
        {
            Email = email,
            HashedPassword = hashedPassword,
            FirstName = firstName,
            Surname = surname,
            BirthDate = birthDate.ToDateTime(new TimeOnly(0, 0)),
            ProfilePic = profilePic,
            Role = role
        };
        UserController controller = new(context);
        var result = await controller.RegisterAsync(mockUser.Email, mockUser.HashedPassword, mockUser.FirstName, mockUser.Surname, birthDate.ToDateTime(new TimeOnly(0, 0)), mockUser.ProfilePic);
        Assert.AreEqual("All fields are required", result);
    }
    [Test]
    public async Task Register_User_7()
    {
        var context = TestDBFactory.CreateDbContext();
        string email = "testuser";
        string hashedPassword = "hashedpassword";
        string firstName = "Test";
        string surname = "User";
        DateOnly birthDate = new DateOnly(1990, 1, 1);
        string profilePic = "profilepic.jpg";
        RoleType role = RoleType.User;
        List<User> mockUSERS = new();
        User mockUser = new User
        {
            Email = email,
            HashedPassword = hashedPassword,
            FirstName = firstName,
            Surname = surname,
            BirthDate = birthDate.ToDateTime(new TimeOnly(0, 0)),
            ProfilePic = profilePic,
            Role = role
        };
        mockUSERS.Add(mockUser);
        context.Users.Add(mockUser);

        await context.SaveChangesAsync();
        UserController controller = new(context);

        var result = await controller.RegisterAsync(mockUser.Email, mockUser.HashedPassword, mockUser.FirstName, mockUser.Surname, birthDate.ToDateTime(new TimeOnly(0, 0)), mockUser.ProfilePic);
        Assert.AreEqual("Email already exists", result);
    }
    [Test]
    public async Task Get_Profile_1()
    {
        var context = TestDBFactory.CreateDbContext();
        string email = "testuser";
        string hashedPassword = "hashedpassword";
        string firstName = "Test";
        string surname = "User";
        DateOnly birthDate = new DateOnly(1990, 1, 1);
        string profilePic = "profilepic.jpg";
        RoleType role = RoleType.User;
        List<User> mockUSERS = new();
        User mockUser = new User
        {
            Email = email,
            HashedPassword = hashedPassword,
            FirstName = firstName,
            Surname = surname,
            BirthDate = birthDate.ToDateTime(new TimeOnly(0, 0)),
            ProfilePic = profilePic,
            Role = role
        };
        mockUSERS.Add(mockUser);
        context.Users.Add(mockUser);
        await context.SaveChangesAsync();
        UserController controller = new(context);
        var result = await controller.GetProfileAsync(mockUser.Id);

        Assert.IsNotNull(result);
        Assert.AreEqual(mockUser.Email, result.Email);
        Assert.AreEqual(mockUser.HashedPassword, result.HashedPassword);
        Assert.AreEqual(mockUser.FirstName, result.FirstName);
        Assert.AreEqual(mockUser.Surname, result.Surname);
        Assert.That(result.BirthDate, Is.EqualTo(birthDate.ToDateTime(new TimeOnly(0, 0))));
        Assert.AreEqual(mockUser.ProfilePic, result.ProfilePic);
        Assert.AreEqual(mockUser.Role, result.Role);
    }
    [Test]
    public async Task Get_Profile_2()
    {
        var context = TestDBFactory.CreateDbContext();
        UserController controller = new(context);
        var result = await controller.GetProfileAsync(999);
        Assert.That(result, Is.Null);
    }
    [Test]
    public async Task Update_Profile_1()
    {
        var context = TestDBFactory.CreateDbContext();
        string email = "testuser";
        string hashedPassword = "hashedpassword";
        string firstName = "Test";
        string surname = "User";
        DateOnly birthDate = new DateOnly(1990, 1, 1);
        string profilePic = "profilepic.jpg";
        RoleType role = RoleType.User;
        List<User> mockUSERS = new();
        User mockUser = new User
        {
            Email = email,
            HashedPassword = hashedPassword,
            FirstName = firstName,
            Surname = surname,
            BirthDate = birthDate.ToDateTime(new TimeOnly(0, 0)),
            ProfilePic = profilePic,
            Role = role
        };
        mockUSERS.Add(mockUser);
        context.Users.Add(mockUser);
        await context.SaveChangesAsync();
        UserController controller = new(context);
        var result = await controller.UpdateProfileAsync(mockUser.Id, "UpdatedFirstName", "UpdatedSurname", "updatedprofilepic.jpg", birthDate.ToDateTime(new TimeOnly(0, 0)));
        Assert.AreEqual("Profile updated", result);
        var updatedUser = await controller.GetProfileAsync(mockUser.Id);
        Assert.IsNotNull(updatedUser);
        Assert.AreEqual("UpdatedFirstName", updatedUser.FirstName);
        Assert.AreEqual("UpdatedSurname", updatedUser.Surname);
        Assert.AreEqual("updatedprofilepic.jpg", updatedUser.ProfilePic);
    }
    [Test]
    public async Task Update_Profile_2()
    {
        var context = TestDBFactory.CreateDbContext();
        UserController controller = new(context);
        var result = await controller.UpdateProfileAsync(999, "UpdatedFirstName", "UpdatedSurname", "updatedprofilepic.jpg", new DateTime(1990, 1, 1));
        Assert.AreEqual("User not found", result);
    }
    [Test]
    public async Task Update_Profile_3()
    {
        var context = TestDBFactory.CreateDbContext();
        string email = "testuser";
        string hashedPassword = "hashedpassword";
        string firstName = "Test";
        string surname = "User";
        DateOnly birthDate = new DateOnly(1990, 1, 1);
        string profilePic = "profilepic.jpg";
        RoleType role = RoleType.User;
        List<User> mockUSERS = [];
        User mockUser = new User
        {
            Email = email,
            HashedPassword = hashedPassword,
            FirstName = firstName,
            Surname = surname,
            BirthDate = birthDate.ToDateTime(new TimeOnly(0, 0)),
            ProfilePic = profilePic,
            Role = role
        };
        mockUSERS.Add(mockUser);
        context.Users.Add(mockUser);
        await context.SaveChangesAsync();

        UserController controller = new(context);
        var result = await controller.UpdateProfileAsync(mockUser.Id, "", "", null, birthDate.ToDateTime(new TimeOnly(0, 0)));

        Assert.AreEqual("Name fields are required", result);
        var updatedUser = await controller.GetProfileAsync(mockUser.Id);

        Assert.IsNotNull(updatedUser);
        Assert.AreEqual("Test", updatedUser.FirstName);
        Assert.AreEqual("User", updatedUser.Surname);
        Assert.AreEqual("profilepic.jpg", updatedUser.ProfilePic);
    }
    [Test]
    public async Task Update_Profile_4()
    {
        var context = TestDBFactory.CreateDbContext();
        string email = "testuser";
        string hashedPassword = "hashedpassword";
        string firstName = "Test";
        string surname = "User";
        DateOnly birthDate = new DateOnly(1990, 1, 1);
        string profilePic = "profilepic.jpg";
        RoleType role = RoleType.User;
        List<User> mockUSERS = new();
        User mockUser = new User
        {
            Email = email,
            HashedPassword = hashedPassword,
            FirstName = firstName,
            Surname = surname,
            BirthDate = birthDate.ToDateTime(new TimeOnly(0, 0)),
            ProfilePic = profilePic,
            Role = role
        };
        mockUSERS.Add(mockUser);
        context.Users.Add(mockUser);

        await context.SaveChangesAsync();
        UserController controller = new(context);

        var result = await controller.UpdateProfileAsync(mockUser.Id, "UpdatedFirstName", "UpdatedSurname", "updatedprofilepic.jpg", new DateTime(2000, 1, 1));
        Assert.AreEqual("Profile updated", result);

        var updatedUser = await controller.GetProfileAsync(mockUser.Id);
        Assert.IsNotNull(updatedUser);
        Assert.That(updatedUser.BirthDate, Is.EqualTo(new DateTime(2000, 1, 1)));
    }
    [Test]
    public async Task Update_Profile_5()
    {
        var context = TestDBFactory.CreateDbContext();
        string email = "testuser";
        string hashedPassword = "hashedpassword";
        string firstName = "Test";
        string surname = "User";
        DateOnly birthDate = new DateOnly(1990, 1, 1);
        string profilePic = "profilepic.jpg";
        RoleType role = RoleType.User;
        List<User> mockUSERS = new();
        User mockUser = new User
        {
            Email = email,
            HashedPassword = hashedPassword,
            FirstName = firstName,
            Surname = surname,
            BirthDate = birthDate.ToDateTime(new TimeOnly(0, 0)),
            ProfilePic = profilePic,
            Role = role
        };
        mockUSERS.Add(mockUser);
        context.Users.Add(mockUser);

        await context.SaveChangesAsync();
        UserController controller = new(context);

        var result = await controller.UpdateProfileAsync(mockUser.Id, "UpdatedFirstName", "", null, birthDate.ToDateTime(new TimeOnly(0, 0)));
        Assert.AreEqual("Name fields are required", result);

        var updatedUser = await controller.GetProfileAsync(mockUser.Id);

        Assert.IsNotNull(updatedUser);
        Assert.AreEqual("Test", updatedUser.FirstName);
        Assert.AreEqual("User", updatedUser.Surname);
    }
    [Test]
    public async Task Delete_User_1()
    {
        var context = TestDBFactory.CreateDbContext();

        User admin = new User
        {
            Email = "admin@test.com",
            HashedPassword = "password",
            FirstName = "Admin",
            Surname = "User",
            BirthDate = new DateTime(1990, 1, 1),
            Role = RoleType.Admin
        };

        User target = new User
        {
            Email = "user@test.com",
            HashedPassword = "password",
            FirstName = "Normal",
            Surname = "User",
            BirthDate = new DateTime(1995, 1, 1),
            Role = RoleType.User
        };

        context.Users.Add(admin);
        context.Users.Add(target);

        await context.SaveChangesAsync();
        UserController controller = new(context);

        var result = await controller.DeleteUserAsync(admin, target.Id);
        Assert.AreEqual("User deleted", result);

        var deletedUser = await controller.GetProfileAsync(target.Id);
        Assert.IsNull(deletedUser);
    }

    [Test]
    public async Task Delete_User_2()
    {
        var context = TestDBFactory.CreateDbContext();

        User normalUser = new User
        {
            Email = "user@test.com",
            HashedPassword = "password",
            FirstName = "Normal",
            Surname = "User",
            BirthDate = new DateTime(1995, 1, 1),
            Role = RoleType.User
        };
        context.Users.Add(normalUser);
        await context.SaveChangesAsync();

        UserController controller = new(context);
        var result = await controller.DeleteUserAsync(normalUser, 999);
        Assert.AreEqual("Only admin can delete users", result);
    }

    [Test]
    public async Task Delete_User_3()
    {
        var context = TestDBFactory.CreateDbContext();

        User admin = new User
        {
            Email = "admin@test.com",
            HashedPassword = "password",
            FirstName = "Admin",
            Surname = "User",
            BirthDate = new DateTime(1990, 1, 1),
            Role = RoleType.Admin
        };
        context.Users.Add(admin);
        await context.SaveChangesAsync();

        UserController controller = new(context);
        var result = await controller.DeleteUserAsync(admin, 999);
        Assert.AreEqual("User not found", result);
    }

    [Test]
    public async Task Search_Users_1()
    {
        var context = TestDBFactory.CreateDbContext();

        User user1 = new User
        {
            Email = "john@test.com",
            HashedPassword = "password",
            FirstName = "John",
            Surname = "Smith",
            BirthDate = new DateTime(1990, 1, 1),
            Role = RoleType.User
        };

        User user2 = new User
        {
            Email = "maria@test.com",
            HashedPassword = "password",
            FirstName = "Maria",
            Surname = "Johnson",
            BirthDate = new DateTime(1992, 1, 1),
            Role = RoleType.User
        };

        context.Users.Add(user1);
        context.Users.Add(user2);
        await context.SaveChangesAsync();

        UserController controller = new(context);
        var result = await controller.SearchUsersAsync("John");
        Assert.That(result.Count, Is.EqualTo(2));
    }

    [Test]
    public async Task Search_Users_2()
    {
        var context = TestDBFactory.CreateDbContext();

        User admin = new User
        {
            Email = "admin@test.com",
            HashedPassword = "password",
            FirstName = "Admin",
            Surname = "User",
            BirthDate = new DateTime(1990, 1, 1),
            Role = RoleType.Admin
        };
        context.Users.Add(admin);
        await context.SaveChangesAsync();

        UserController controller = new(context);
        var result = await controller.SearchUsersAsync("Admin");
        Assert.That(result.Count, Is.EqualTo(0));
    }

    [Test]
    public async Task Follow_User_1()
    {
        var context = TestDBFactory.CreateDbContext();

        User user1 = new User
        {
            Email = "user1@test.com",
            HashedPassword = "password",
            FirstName = "User1",
            Surname = "Test",
            BirthDate = new DateTime(1990, 1, 1),
            Role = RoleType.User
        };

        User user2 = new User
        {
            Email = "user2@test.com",
            HashedPassword = "password",
            FirstName = "User2",
            Surname = "Test",
            BirthDate = new DateTime(1991, 1, 1),
            Role = RoleType.User
        };

        context.Users.Add(user1);
        context.Users.Add(user2);
        await context.SaveChangesAsync();

        UserController controller = new(context);
        var result = await controller.FollowAsync(user1.Id, user2.Id);
        Assert.AreEqual("Followed successfully", result);

        var following = await controller.GetFollowingAsync(user1.Id);
        Assert.That(following.Any(u => u.Id == user2.Id), Is.True);
    }

    [Test]
    public async Task Follow_User_2()
    {
        var context = TestDBFactory.CreateDbContext();

        UserController controller = new(context);
        var result = await controller.FollowAsync(1, 1);

        Assert.AreEqual("You cannot follow yourself", result);
    }

    [Test]
    public async Task Follow_User_3()
    {
        var context = TestDBFactory.CreateDbContext();

        User user1 = new User
        {
            Email = "user1@test.com",
            HashedPassword = "password",
            FirstName = "User1",
            Surname = "Test",
            BirthDate = new DateTime(1990, 1, 1),
            Role = RoleType.User
        };

        User user2 = new User
        {
            Email = "user2@test.com",
            HashedPassword = "password",
            FirstName = "User2",
            Surname = "Test",
            BirthDate = new DateTime(1991, 1, 1),
            Role = RoleType.User
        };
        context.Users.Add(user1);
        context.Users.Add(user2);

        UserFollow follow = new UserFollow
        {
            FollowerId = user1.Id,
            FollowingId = user2.Id
        };

        context.UserFollows.Add(follow);
        await context.SaveChangesAsync();

        UserController controller = new(context);
        var result = await controller.FollowAsync(user1.Id, user2.Id);
        Assert.AreEqual("Already following this user", result);
    }

    [Test]
    public async Task Unfollow_User_1()
    {
        var context = TestDBFactory.CreateDbContext();

        User user1 = new User
        {
            Email = "user1@test.com",
            HashedPassword = "password",
            FirstName = "User1",
            Surname = "Test",
            BirthDate = new DateTime(1990, 1, 1),
            Role = RoleType.User
        };

        User user2 = new User
        {
            Email = "user2@test.com",
            HashedPassword = "password",
            FirstName = "User2",
            Surname = "Test",
            BirthDate = new DateTime(1991, 1, 1),
            Role = RoleType.User
        };

        context.Users.Add(user1);
        context.Users.Add(user2);
        await context.SaveChangesAsync();

        context.UserFollows.Add(new UserFollow
        {
            FollowerId = user1.Id,
            FollowingId = user2.Id
        });
        await context.SaveChangesAsync();

        UserController controller = new(context);
        var result = await controller.UnfollowAsync(user1.Id, user2.Id);
        Assert.AreEqual("Unfollowed successfully", result);
    }

    [Test]
    public async Task Unfollow_User_2()
    {
        var context = TestDBFactory.CreateDbContext();

        User user1 = new User
        {
            Email = "user1@test.com",
            HashedPassword = "password",
            FirstName = "User1",
            Surname = "Test",
            BirthDate = new DateTime(1990, 1, 1),
            Role = RoleType.User
        };

        User user2 = new User
        {
            Email = "user2@test.com",
            HashedPassword = "password",
            FirstName = "User2",
            Surname = "Test",
            BirthDate = new DateTime(1991, 1, 1),
            Role = RoleType.User
        };

        context.Users.Add(user1);
        context.Users.Add(user2);

        await context.SaveChangesAsync();

        UserController controller = new(context);

        var result = await controller.UnfollowAsync(user1.Id, user2.Id);

        Assert.AreEqual("You are not following this user", result);
    }

    [Test]
    public async Task Get_Followers_1()
    {
        var context = TestDBFactory.CreateDbContext();

        User user1 = new User
        {
            Email = "user1@test.com",
            HashedPassword = "password",
            FirstName = "User1",
            Surname = "Test",
            BirthDate = new DateTime(1990, 1, 1),
            Role = RoleType.User
        };

        User user2 = new User
        {
            Email = "user2@test.com",
            HashedPassword = "password",
            FirstName = "User2",
            Surname = "Test",
            BirthDate = new DateTime(1991, 1, 1),
            Role = RoleType.User
        };

        context.Users.Add(user1);
        context.Users.Add(user2);
        await context.SaveChangesAsync();

        context.UserFollows.Add(new UserFollow
        {
            FollowerId = user1.Id,
            FollowingId = user2.Id
        });
        await context.SaveChangesAsync();

        UserController controller = new(context);
        var followers = await controller.GetFollowersAsync(user2.Id);
        Assert.That(followers.Any(u => u.Id == user1.Id), Is.True);
    }

    [Test]
    public async Task Get_Following_1()
    {
        var context = TestDBFactory.CreateDbContext();

        User user1 = new User
        {
            Email = "user1@test.com",
            HashedPassword = "password",
            FirstName = "User1",
            Surname = "Test",
            BirthDate = new DateTime(1990, 1, 1),
            Role = RoleType.User
        };

        User user2 = new User
        {
            Email = "user2@test.com",
            HashedPassword = "password",
            FirstName = "User2",
            Surname = "Test",
            BirthDate = new DateTime(1991, 1, 1),
            Role = RoleType.User
        };

        context.Users.Add(user1);
        context.Users.Add(user2);
        await context.SaveChangesAsync();

        context.UserFollows.Add(new UserFollow
        {
            FollowerId = user1.Id,
            FollowingId = user2.Id
        });
        await context.SaveChangesAsync();

        UserController controller = new(context);
        var following = await controller.GetFollowingAsync(user1.Id);
        Assert.That(following.Any(u => u.Id == user2.Id), Is.True);
    }
    [Test]
    public async Task Import_Users_From_Json_1()
    {
        var context = TestDBFactory.CreateDbContext();

        UserController controller = new(context);

        string filePath = Path.GetTempFileName();
        string json = """
        [
            {
                "Email":"john@test.com",
                "HashedPassword":"password",
                "FirstName":"John",
                "Surname":"Doe",
                "BirthDate":"1990-01-01"
            }
        ]
        """;
        await File.WriteAllTextAsync(filePath, json);

        var result = await controller.ImportUsersFromJsonAsync(filePath);
        Assert.AreEqual("Users imported successfully", result);
        Assert.That(context.Users.Count(), Is.EqualTo(1));

        File.Delete(filePath);
    }
    [Test]
    public async Task Import_Users_From_Json_2()
    {
        var context = TestDBFactory.CreateDbContext();

        UserController controller = new(context);
        var result = await controller.ImportUsersFromJsonAsync("missing.json");

        Assert.AreEqual("JSON file not found.", result);
    }
    [Test]
    public async Task Import_Users_From_Json_3()
    {
        var context = TestDBFactory.CreateDbContext();

        UserController controller = new(context);

        string filePath = Path.GetTempFileName();
        await File.WriteAllTextAsync(filePath, "{ invalid json }");

        var result = await controller.ImportUsersFromJsonAsync(filePath);
        Assert.AreEqual("Failed to import users", result);

        File.Delete(filePath);
    }
}
