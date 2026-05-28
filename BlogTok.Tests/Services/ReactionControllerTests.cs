using BlogTok.Controllers;
using BlogTok.Data;
using BlogTok.Data.Enums;
using BlogTok.Data.Models;
using BlogTok.Tests.Helpers;

namespace BlogTok.Tests;

public class ReactionControllerTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task React_To_Post_1()
    {
        var context = TestDBFactory.CreateDbContext();

        User user = new User
        {
            Email = "user@test.com",
            HashedPassword = "password",
            FirstName = "Test",
            Surname = "User",
            BirthDate = new DateTime(1990, 1, 1),
            Role = RoleType.User
        };

        context.Users.Add(user);
        await context.SaveChangesAsync();

        Post post = new Post
        {
            Title = "Test Title",
            Description = "Test Description",
            CreatedAt = DateTime.Now,
            UserId = user.Id
        };

        context.Posts.Add(post);
        await context.SaveChangesAsync();

        ReactionController controller = new(context);
        var result = await controller.ReactToPostAsync(user.Id, post.Id, ReactionType.Like);
        Assert.AreEqual("Reaction added to post", result);

        var reaction = context.Reactions.FirstOrDefault(r =>
            r.UserId == user.Id &&
            r.PostId == post.Id);

        Assert.IsNotNull(reaction);
        Assert.AreEqual(ReactionType.Like, reaction!.Emotion);
    }

    [Test]
    public async Task React_To_Post_2()
    {
        var context = TestDBFactory.CreateDbContext();

        User user = new User
        {
            Email = "user@test.com",
            HashedPassword = "password",
            FirstName = "Test",
            Surname = "User",
            BirthDate = new DateTime(1990, 1, 1),
            Role = RoleType.User
        };

        context.Users.Add(user);
        await context.SaveChangesAsync();

        Post post = new Post
        {
            Title = "Test Title",
            Description = "Test Description",
            CreatedAt = DateTime.Now,
            UserId = user.Id
        };

        context.Posts.Add(post);
        await context.SaveChangesAsync();

        Reaction reaction = new Reaction
        {
            UserId = user.Id,
            PostId = post.Id,
            Emotion = ReactionType.Like
        };

        context.Reactions.Add(reaction);
        await context.SaveChangesAsync();

        ReactionController controller = new(context);
        var result = await controller.ReactToPostAsync(user.Id, post.Id, ReactionType.Like);
        Assert.AreEqual("Reaction removed from post", result);

        var deletedReaction = context.Reactions.FirstOrDefault(r =>
            r.UserId == user.Id &&
            r.PostId == post.Id);
        Assert.IsNull(deletedReaction);
    }

    [Test]
    public async Task Unreact_Post_1()
    {
        var context = TestDBFactory.CreateDbContext();

        User user = new User
        {
            Email = "user@test.com",
            HashedPassword = "password",
            FirstName = "Test",
            Surname = "User",
            BirthDate = new DateTime(1990, 1, 1),
            Role = RoleType.User
        };

        context.Users.Add(user);
        await context.SaveChangesAsync();

        Post post = new Post
        {
            Title = "Test Title",
            Description = "Test Description",
            CreatedAt = DateTime.Now,
            UserId = user.Id
        };

        context.Posts.Add(post);
        await context.SaveChangesAsync();

        Reaction reaction = new Reaction
        {
            UserId = user.Id,
            PostId = post.Id,
            Emotion = ReactionType.Like
        };

        context.Reactions.Add(reaction);
        await context.SaveChangesAsync();

        ReactionController controller = new(context);
        var result = await controller.UnreactPostAsync(user.Id, post.Id);
        Assert.AreEqual("Reaction removed", result);

        var deletedReaction = context.Reactions.FirstOrDefault(r =>
            r.UserId == user.Id &&
            r.PostId == post.Id);
        Assert.IsNull(deletedReaction);
    }

    [Test]
    public async Task Unreact_Post_2()
    {
        var context = TestDBFactory.CreateDbContext();

        User user = new User
        {
            Email = "user@test.com",
            HashedPassword = "password",
            FirstName = "Test",
            Surname = "User",
            BirthDate = new DateTime(1990, 1, 1),
            Role = RoleType.User
        };

        context.Users.Add(user);
        await context.SaveChangesAsync();

        Post post = new Post
        {
            Title = "Test Title",
            Description = "Test Description",
            CreatedAt = DateTime.Now,
            UserId = user.Id
        };

        context.Posts.Add(post);
        await context.SaveChangesAsync();

        ReactionController controller = new(context);
        var result = await controller.UnreactPostAsync(user.Id, post.Id);
        Assert.AreEqual("No reaction to remove", result);
    }
}