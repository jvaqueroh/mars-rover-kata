using System;
using FluentAssertions;
using NUnit.Framework;

namespace MarsRoverKata.Tests
{
    public class MarsRoverShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void return_current_position()
        {
            var rover = new MarsRover(1, 1, String.Empty);

            var result = rover.GetPosition();

            result.Should().Be("1,1");
        }
        
        [Test]
        public void return_current_direction()
        {
            var rover = new MarsRover(1, 1, "N");

            var result = rover.GetDirection();

            result.Should().Be("N");
        }
    }
}