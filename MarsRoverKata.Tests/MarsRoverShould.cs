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
            var rover = new MarsRover(1,1);

            var result = rover.GetPosition();

            result.Should().Be("1,1");
        }
    }
}