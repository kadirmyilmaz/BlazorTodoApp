using Domain.Entities;

namespace Domain.Tests.Entities
{
    public class TodoItemTests
    {
        [Fact]
        public void CreateTaskItem_ShouldInitializeProperties()
        {
            var title = "Learn Blazor";
            var description = "Learn how to build web apps with Blazor";

            var item = new TaskItem()
            {
                Title = title,
                Description = description
            };

            Assert.Equal(title, item.Title);
            Assert.Equal(description, item.Description);
            Assert.False(item.IsCompleted, "New todo items should not be completed");
            Assert.Null(item.CompletedAt);
        }

        [Fact]
        public void CreateTaskItem_ShouldThrow_WhenTitleIsNull()
        {
            string? title = null;

            var taskItem = (() => new TaskItem { Title = title });

            Assert.Throws<ArgumentNullException>(taskItem);
        }

        [Fact]
        public void MarkAsComplete_ShouldSetIsCompleted_AndCompletedAt()
        {
            // Arrange
            var item = new TaskItem()
            {
                Title = "Walk with the dog"
            };

            Assert.False(item.IsCompleted, "New todo items should start as incomplete");
            Assert.Null(item.CompletedAt);

            // Act
            item.MarkAsComplete();

            // Assert
            Assert.True(item.IsCompleted, "TodoItem should be marked as completed");
            Assert.NotNull(item.CompletedAt);
            Assert.True((DateTime.UtcNow - item.CompletedAt.Value).TotalSeconds < 1, "CompletedAt should be set to the current time");
        }

        [Fact]
        public void MarkAsComplete_ShouldThrow_WhenAlreadyCompleted()
        {
            // Arrange
            var item = new TaskItem()
            {
                Title = "Learn TDD"
            };

            item.MarkAsComplete();

            // Act & Assert
            // Trying to mark it complete again should throw an exception
            Assert.Throws<InvalidOperationException>(() => item.MarkAsComplete());
        }
    }
}