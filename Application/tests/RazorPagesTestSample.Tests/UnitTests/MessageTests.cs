using RazorPagesTestSample.Data;
using RazorPagesTestSample.Tests.UnitTests.Utils;
using System;
using System.Linq;
using Xunit;

namespace RazorPagesTestSample.Tests.UnitTests
{
    public class MessageTests
    {
        [Fact]
        public void TestMessageLengthExceedsLimit()
        {
            // Arrange
            var text = new String('a', 251); // Create a string that is longer than 250 characters
            var expected_error_message = "There's a 250 character limit on messages. Please shorten your message.";
            var expected_error_number = 1;

            // Act
            var message = new Message { Text = text };

            var result = message.ValidateModelAnnotations();

            // Assert
            Assert.Equal(expected_error_number, result.Count());
            Assert.Equal(expected_error_message, result.First().ErrorMessage);
        }
    }
}