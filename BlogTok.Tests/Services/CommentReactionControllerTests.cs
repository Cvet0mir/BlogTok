using BlogTok.Controllers;
using BlogTok.Data.Enums;
using BlogTok.Data.Models;
using BlogTok.Tests.Helpers;

namespace BlogTok.Tests;

public class CommentReactionControllerTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task React_To_Comment_1()
    {
        var context = TestDBFactory.CreateDbContext();

        User user = new()
        {
            Email = "user@test.com",
            HashedPassword = "password",
            FirstName = "Test",
            Surname = "User",
            BirthDate = new DateTime(1990, 1, 1)
        };

        Post post = new()
        {
            Title = "Test Post",
            CreatedAt = DateTime.Now
        };

        context.Users.Add(user);
        context.Posts.Add(post);
        await context.SaveChangesAsync();

        Comment comment = new()
        {
            UserId = user.Id,
            PostId = post.Id,
            Content = "Test Comment"
        };
        context.Comments.Add(comment);
        await context.SaveChangesAsync();

        CommentReactionController controller = new(context);
        var result = await controller.ReactToCommentAsync(user.Id, comment.Id, ReactionType.Like);

        Assert.AreEqual("Reaction added to comment", result);
        var reaction = context.CommentReactions.FirstOrDefault();

        Assert.IsNotNull(reaction);
        Assert.AreEqual(user.Id, reaction.UserId);
        Assert.AreEqual(comment.Id, reaction.CommentId);
        Assert.AreEqual(ReactionType.Like, reaction.Emotion);
    }

    [Test]
    public async Task React_To_Comment_2()
    {
        var context = TestDBFactory.CreateDbContext();

        User user = new()
        {
            Email = "user@test.com",
            HashedPassword = "password",
            FirstName = "Test",
            Surname = "User",
            BirthDate = new DateTime(1990, 1, 1)
        };

        Post post = new Post
        {
            Title = "Test Post",
            CreatedAt = DateTime.Now
        };

        context.Users.Add(user);
        context.Posts.Add(post);
        await context.SaveChangesAsync();

        Comment comment = new()
        {
            UserId = user.Id,
            PostId = post.Id,
            Content = "Test Comment"
        };
        context.Comments.Add(comment);
        await context.SaveChangesAsync();

        CommentReaction existingReaction = new()
        {
            UserId = user.Id,
            CommentId = comment.Id,
            Emotion = ReactionType.Like
        };
        context.CommentReactions.Add(existingReaction);
        await context.SaveChangesAsync();

        CommentReactionController controller = new(context);
        var result = await controller.ReactToCommentAsync(user.Id, comment.Id, ReactionType.Like);
        Assert.AreEqual("Reaction removed from comment", result);

        var reaction = context.CommentReactions.FirstOrDefault();
        Assert.IsNull(reaction);
    }

    [Test]
    public async Task Unreact_Comment_1()
    {
        var context = TestDBFactory.CreateDbContext();

        User user = new()
        {
            Email = "user@test.com",
            HashedPassword = "password",
            FirstName = "Test",
            Surname = "User",
            BirthDate = new DateTime(1990, 1, 1)
        };

        Post post = new()
        {
            Title = "Test Post",
            CreatedAt = DateTime.Now
        };

        context.Users.Add(user);
        context.Posts.Add(post);
        await context.SaveChangesAsync();

        Comment comment = new()
        {
            UserId = user.Id,
            PostId = post.Id,
            Content = "Test Comment"
        };
        context.Comments.Add(comment);
        await context.SaveChangesAsync();

        CommentReaction reaction = new CommentReaction
        {
            UserId = user.Id,
            CommentId = comment.Id,
            Emotion = ReactionType.Like
        };
        context.CommentReactions.Add(reaction);
        await context.SaveChangesAsync();

        CommentReactionController controller = new(context);
        var result = await controller.UnreactCommentAsync(user.Id, comment.Id);
        Assert.AreEqual("Reaction removed", result);

        var deletedReaction = context.CommentReactions.FirstOrDefault();
        Assert.IsNull(deletedReaction);
    }

    [Test]
    public async Task Unreact_Comment_2()
    {
        var context = TestDBFactory.CreateDbContext();

        CommentReactionController controller = new(context);
        var result = await controller.UnreactCommentAsync(1, 999);
        Assert.AreEqual("No reaction to remove", result);
    }
}