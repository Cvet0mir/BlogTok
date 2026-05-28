using BlogTok.Controllers;
using BlogTok.Data.Models;
using BlogTok.Tests.Helpers;

namespace BlogTok.Tests;

public class CommentControllerTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Create_Comment_1()
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
            UserId = 1,
            Title = "Test Post",
            CreatedAt = DateTime.Now
        };

        context.Users.Add(user);
        context.Posts.Add(post);
        await context.SaveChangesAsync();

        CommentController controller = new(context);
        var result = await controller.CreateCommentAsync(user.Id, post.Id, "Test comment");
        Assert.AreEqual("Comment added", result);

        var comment = context.Comments.FirstOrDefault();
        Assert.That(comment, Is.Not.Null);

        Assert.AreEqual(user.Id, comment.UserId);
        Assert.AreEqual(post.Id, comment.PostId);
        Assert.AreEqual("Test comment", comment.Content);
    }

    [Test]
    public async Task Create_Comment_2()
    {
        var context = TestDBFactory.CreateDbContext();

        CommentController controller = new(context);
        var result = await controller.CreateCommentAsync(1, 1, "");

        Assert.AreEqual("Comment cannot be empty", result);
        Assert.That(context.Comments.Count(), Is.EqualTo(0));
    }

    [Test]
    public async Task Create_Comment_3()
    {
        var context = TestDBFactory.CreateDbContext();

        CommentController controller = new(context);
        string longComment = new string('A', 251);

        var result = await controller.CreateCommentAsync(1, 1, longComment);
        Assert.AreEqual("Comment too long (max 250 characters)", result);
        Assert.That(context.Comments.Count(), Is.EqualTo(0));
    }

    [Test]
    public async Task Edit_Comment_1()
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
        context.Users.Add(user);
        await context.SaveChangesAsync();

        Comment comment = new()
        {
            UserId = user.Id,
            PostId = 1,
            Content = "Old content"
        };
        context.Comments.Add(comment);
        await context.SaveChangesAsync();

        CommentController controller = new(context);
        var result = await controller.EditCommentAsync(user.Id, comment.Id, "Updated content");
        Assert.AreEqual("Comment updated", result);

        var updatedComment = context.Comments.FirstOrDefault(c => c.Id == comment.Id);
        Assert.That(updatedComment, Is.Not.Null);
        Assert.AreEqual("Updated content", updatedComment.Content);
    }

    [Test]
    public async Task Edit_Comment_2()
    {
        var context = TestDBFactory.CreateDbContext();

        CommentController controller = new(context);
        var result = await controller.EditCommentAsync( 1, 1, "");

        Assert.AreEqual("Comment cannot be empty", result);
    }

    [Test]
    public async Task Edit_Comment_3()
    {
        var context = TestDBFactory.CreateDbContext();

        CommentController controller = new(context);
        var result = await controller.EditCommentAsync(1, 999,"Updated content");
        Assert.AreEqual("Comment not found", result);
    }

    [Test]
    public async Task Edit_Comment_4()
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

        Comment comment = new()
        {
            UserId = user1.Id,
            PostId = 1,
            Content = "Original comment"
        };
        context.Comments.Add(comment);
        await context.SaveChangesAsync();

        CommentController controller = new(context);
        var result = await controller.EditCommentAsync(user2.Id, comment.Id, "Hacked comment");

        Assert.AreEqual("You can only edit your own comments", result);

        var unchangedComment = context.Comments.FirstOrDefault(c => c.Id == comment.Id);

        Assert.That(unchangedComment, Is.Not.Null);
        Assert.That(unchangedComment.Content, Is.EqualTo("Original comment"));
    }

    [Test]
    public async Task Delete_Comment_1()
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
        context.Users.Add(user);
        await context.SaveChangesAsync();

        Comment comment = new()
        {
            UserId = user.Id,
            PostId = 1,
            Content = "Comment to delete"
        };
        context.Comments.Add(comment);
        await context.SaveChangesAsync();

        CommentController controller = new(context);
        var result = await controller.DeleteCommentAsync(user.Id, comment.Id);
        Assert.AreEqual("Comment deleted", result);

        var deletedComment = context.Comments.FirstOrDefault(c => c.Id == comment.Id);
        Assert.That(deletedComment, Is.Null);
    }

    [Test]
    public async Task Delete_Comment_2()
    {
        var context = TestDBFactory.CreateDbContext();

        CommentController controller = new(context);
        var result = await controller.DeleteCommentAsync(1, 999);
        Assert.AreEqual("Comment not found", result);
    }

    [Test]
    public async Task Delete_Comment_3()
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

        Comment comment = new()
        {
            UserId = user1.Id,
            PostId = 1,
            Content = "Protected comment"
        };
        context.Comments.Add(comment);
        await context.SaveChangesAsync();

        CommentController controller = new(context);
        var result = await controller.DeleteCommentAsync(user2.Id, comment.Id);
        Assert.AreEqual("You can only delete your own comments", result);

        var existingComment = context.Comments.FirstOrDefault(c => c.Id == comment.Id);
        Assert.That(existingComment, Is.Not.Null);
    }

    [Test]
    public async Task Get_Comments_For_Post_1()
    {
        var context = TestDBFactory.CreateDbContext();

        Comment comment1 = new()
        {
            UserId = 1,
            PostId = 1,
            Content = "Comment 1"
        };
        Comment comment2 = new()
        {
            UserId = 2,
            PostId = 1,
            Content = "Comment 2"
        };
        Comment comment3 = new()
        {
            UserId = 3,
            PostId = 2,
            Content = "Different post comment"
        };

        context.Comments.Add(comment1);
        context.Comments.Add(comment2);
        context.Comments.Add(comment3);
        await context.SaveChangesAsync();

        CommentController controller = new(context);
        var result = await controller.GetCommentsForPostAsync(1);

        Assert.That(result, Has.Count.EqualTo(2));
        Assert.That(result.Any(c => c.Content == "Comment 1"), Is.True);
        Assert.That(result.Any(c => c.Content == "Comment 2"), Is.True);
    }
}