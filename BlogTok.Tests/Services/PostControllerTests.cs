using BlogTok.Controllers;
using BlogTok.Data.Enums;
using BlogTok.Data.Models;
using BlogTok.Tests.Helpers;

namespace BlogTok.Tests;

public class PostControllerTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Create_Post_1()
    {
        var context = TestDBFactory.CreateDbContext();

        User user = new()
        {
            Email = "test@test.com",
            HashedPassword = "password",
            FirstName = "Test",
            Surname = "User",
            BirthDate = new DateTime(1990, 1, 1)
        };
        context.Users.Add(user);
        await context.SaveChangesAsync();

        PostController controller = new(context);
        var result = await controller.CreatePostAsync(user.Id, "Test Post", "Test Description", "image.jpg");
        Assert.AreEqual("Post created successfully", result);

        var post = context.Posts.FirstOrDefault();
        Assert.IsNotNull(post);
        Assert.AreEqual(user.Id, post.UserId);
        Assert.AreEqual("Test Post", post.Title);
        Assert.AreEqual("Test Description", post.Description);
        Assert.AreEqual("image.jpg", post.Picture);
    }

    [Test]
    public async Task Create_Post_2()
    {
        var context = TestDBFactory.CreateDbContext();

        PostController controller = new(context);
        var result = await controller.CreatePostAsync(1, "", "Description", "image.jpg");

        Assert.AreEqual("Title is required", result);
        Assert.That(context.Posts.Count(), Is.EqualTo(0));
    }

    [Test]
    public async Task Create_Post_3()
    {
        var context = TestDBFactory.CreateDbContext();

        PostController controller = new(context);

        string longTitle = new string('A', 101);

        var result = await controller.CreatePostAsync(1, longTitle, "Description", "image.jpg");
        Assert.AreEqual("Title too long", result);
        Assert.That(context.Posts.Count(), Is.EqualTo(0));
    }

    [Test]
    public async Task Delete_Post_1()
    {
        var context = TestDBFactory.CreateDbContext();

        User user = new()
        {
            Email = "test@test.com",
            HashedPassword = "password",
            FirstName = "Test",
            Surname = "User",
            BirthDate = new DateTime(1990, 1, 1)
        };

        context.Users.Add(user);
        await context.SaveChangesAsync();

        Post post = new()
        {
            UserId = user.Id,
            Title = "Test Post",
            Description = "Description",
            CreatedAt = DateTime.Now
        };

        context.Posts.Add(post);
        await context.SaveChangesAsync();

        PostController controller = new(context);
        var result = await controller.DeletePostAsync(user.Id, post.Id);
        Assert.AreEqual("Post deleted", result);

        var deletedPost = await controller.GetPostAsync(post.Id);
        Assert.IsNull(deletedPost);
    }

    [Test]
    public async Task Delete_Post_2()
    {
        var context = TestDBFactory.CreateDbContext();

        PostController controller = new(context);
        var result = await controller.DeletePostAsync(1, 999);
        Assert.AreEqual("Post not found", result);
    }

    [Test]
    public async Task Delete_Post_3()
    {
        var context = TestDBFactory.CreateDbContext();

        User user1 = new()
        {
            Email = "user1@test.com",
            HashedPassword = "password",
            FirstName = "User1",
            Surname = "Test",
            BirthDate = new DateTime(1990, 1, 1)
        };

        User user2 = new()
        {
            Email = "user2@test.com",
            HashedPassword = "password",
            FirstName = "User2",
            Surname = "Test",
            BirthDate = new DateTime(1991, 1, 1)
        };

        context.Users.Add(user1);
        context.Users.Add(user2);
        await context.SaveChangesAsync();

        Post post = new()
        {
            UserId = user1.Id,
            Title = "User1 Post",
            CreatedAt = DateTime.Now
        };

        context.Posts.Add(post);
        await context.SaveChangesAsync();

        PostController controller = new(context);
        var result = await controller.DeletePostAsync(user2.Id, post.Id);

        Assert.AreEqual("You can only delete your own posts", result);
        var existingPost = await controller.GetPostAsync(post.Id);
        Assert.IsNotNull(existingPost);
    }

    [Test]
    public async Task Get_User_Posts_1()
    {
        var context = TestDBFactory.CreateDbContext();

        User user = new()
        {
            Email = "test@test.com",
            HashedPassword = "password",
            FirstName = "Test",
            Surname = "User",
            BirthDate = new DateTime(1990, 1, 1)
        };
        context.Users.Add(user);
        await context.SaveChangesAsync();

        Post post1 = new()
        {
            UserId = user.Id,
            Title = "Post 1",
            CreatedAt = DateTime.Now
        };

        Post post2 = new()
        {
            UserId = user.Id,
            Title = "Post 2",
            CreatedAt = DateTime.Now
        };

        context.Posts.Add(post1);
        context.Posts.Add(post2);
        await context.SaveChangesAsync();

        PostController controller = new(context);
        var result = await controller.GetUserPostsAsync(user.Id);

        Assert.That(result.Count, Is.EqualTo(2));
        Assert.That(result.Any(p => p.Title == "Post 1"), Is.True);
        Assert.That(result.Any(p => p.Title == "Post 2"), Is.True);
    }

    [Test]
    public async Task Get_Feed_1()
    {
        var context = TestDBFactory.CreateDbContext();

        User user1 = new()
        {
            Email = "user1@test.com",
            HashedPassword = "password",
            FirstName = "User1",
            Surname = "Test",
            BirthDate = new DateTime(1990, 1, 1)
        };

        User user2 = new()
        {
            Email = "user2@test.com",
            HashedPassword = "password",
            FirstName = "User2",
            Surname = "Test",
            BirthDate = new DateTime(1991, 1, 1)
        };

        context.Users.Add(user1);
        context.Users.Add(user2);
        await context.SaveChangesAsync();

        context.UserFollows.Add(new UserFollow
        {
            FollowerId = user1.Id,
            FollowingId = user2.Id
        });

        context.Posts.Add(new Post
        {
            UserId = user1.Id,
            Title = "My Post",
            CreatedAt = DateTime.Now
        });

        context.Posts.Add(new Post
        {
            UserId = user2.Id,
            Title = "Followed User Post",
            CreatedAt = DateTime.Now
        });
        await context.SaveChangesAsync();

        PostController controller = new(context);
        var feed = await controller.GetFeedAsync();

        Assert.That(feed, Has.Count.EqualTo(2));
        Assert.That(feed.Any(p => p.Title == "My Post"), Is.True);
        Assert.That(feed.Any(p => p.Title == "Followed User Post"), Is.True);
    }

    [Test]
    public async Task Get_Post_1()
    {
        var context = TestDBFactory.CreateDbContext();

        Post post = new()
        {
            UserId = 1,
            Title = "Test Post",
            Description = "Description",
            CreatedAt = DateTime.Now
        };
        context.Posts.Add(post);
        await context.SaveChangesAsync();

        PostController controller = new(context);
        var result = await controller.GetPostAsync(post.Id);

        Assert.IsNotNull(result);
        Assert.AreEqual(post.Id, result.Id);
        Assert.AreEqual(post.Title, result.Title);
        Assert.AreEqual(post.Description, result.Description);
    }

    [Test]
    public async Task Get_Post_2()
    {
        var context = TestDBFactory.CreateDbContext();

        PostController controller = new(context);
        var result = await controller.GetPostAsync(999);
        Assert.IsNull(result);
    }

    [Test]
    public async Task Get_Most_Liked_Posts_1()
    {
        var context = TestDBFactory.CreateDbContext();

        User user = new()
        {
            Email = "test@test.com",
            HashedPassword = "password",
            FirstName = "Test",
            Surname = "User",
            BirthDate = new DateTime(1990, 1, 1)
        };

        User user2 = new()
        {
            Email = "u2@test.com",
            HashedPassword = "password",
            FirstName = "U2",
            Surname = "Test",
            BirthDate = new DateTime(1990, 1, 1)
        };

        User user3 = new()
        {
            Email = "u3@test.com",
            HashedPassword = "password",
            FirstName = "U3",
            Surname = "Test",
            BirthDate = new DateTime(1990, 1, 1)
        };
        context.Users.AddRange(user, user2, user3);
        await context.SaveChangesAsync();

        Post post1 = new()
        {
            UserId = user.Id,
            Title = "Most Liked",
            CreatedAt = DateTime.Now
        };

        Post post2 = new()
        {
            UserId = user.Id,
            Title = "Less Liked",
            CreatedAt = DateTime.Now
        };
        context.Posts.AddRange(post1, post2);
        await context.SaveChangesAsync();

        context.Reactions.AddRange(
            new Reaction { PostId = post1.Id, UserId = user.Id, Emotion = ReactionType.Like },
            new Reaction { PostId = post1.Id, UserId = user2.Id, Emotion = ReactionType.Like},
            new Reaction { PostId = post1.Id, UserId = user3.Id, Emotion = ReactionType.Like}
        );
        await context.SaveChangesAsync();

        PostController controller = new(context);
        var result = await controller.GetMostLikedPostsAsync();

        Assert.That(result.Count, Is.EqualTo(2));
        Assert.That(result[0].Title, Is.EqualTo("Most Liked"));
        Assert.That(result[1].Title, Is.EqualTo("Less Liked"));
    }
    [Test]
    public async Task Get_Most_Liked_Posts_2()
    {
        var context = TestDBFactory.CreateDbContext();

        PostController controller = new(context);
        var result = await controller.GetMostLikedPostsAsync();

        Assert.That(result, Is.Not.Null);
        Assert.That(result, Is.Empty);
    }
}