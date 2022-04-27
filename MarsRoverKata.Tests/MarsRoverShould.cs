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

        [Test]
        public void move_forward_one_unit_when_facing_north()
        {
            var rover = new MarsRover(2, 2, "N");

            var result = rover.ExecuteCommand("f.1");
            
            result.Should().Be("2,1");
        }

        [Test]
        public void move_backward_one_unit_when_facing_north()
        {
            var rover = new MarsRover(2, 2, "N");

            var result = rover.ExecuteCommand("b.1");

            result.Should().Be("2,3");
        }
    }
}