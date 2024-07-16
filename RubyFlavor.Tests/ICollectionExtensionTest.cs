using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace RubyFlavor.Tests
{
    public class ICollectionExtensionsTests
    {
        [Fact]
        public void Sample_ThrowsInvalidOperationException_WhenCollectionIsEmpty()
        {
            // Arrange
            var collection = new List<int>();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => collection.Sample());
        }

        [Fact]
        public void Sample_ReturnsElement_FromCollection()
        {
            // Arrange
            var collection = new List<int> { 1, 2, 3, 4, 5 };
            var random = new Random(0); // Use a seed for reproducibility

            // Act
            var result = collection.Sample(random);

            // Assert
            Assert.Contains(result, collection);
        }

        [Fact]
        public void Sample_ThrowsInvalidOperationException_WhenCountIsZero()
        {
            // Arrange
            var collection = new List<int>();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => collection.Sample(1));
        }

        [Fact]
        public void Sample_ThrowsArgumentOutOfRangeException_WhenCountIsNegative()
        {
            // Arrange
            var collection = new List<int> { 1, 2, 3, 4, 5 };

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => collection.Sample(-1));
        }

        [Fact]
        public void Sample_ReturnsElements_FromCollection()
        {
            // Arrange
            var collection = new List<int> { 1, 2, 3, 4, 5 };
            var random = new Random(0); // Use a seed for reproducibility
            int count = 3;

            // Act
            var result = collection.Sample(count, random);

            // Assert
            Assert.Equal(count, result.Count());
            Assert.All(result, item => Assert.Contains(item, collection));
        }

        [Fact]
        public void Sample_ReturnsFewerElements_WhenCountIsGreaterThanCollection()
        {
            // Arrange
            var collection = new List<int> { 1, 2, 3 };
            var random = new Random(0); // Use a seed for reproducibility
            int count = 5;

            // Act
            var result = collection.Sample(count, random);

            // Assert
            Assert.Equal(collection.Count, result.Count());
            Assert.All(result, item => Assert.Contains(item, collection));
        }
    }
}
