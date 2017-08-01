using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NasaRover.Test
{
    [TestFixture]
    internal class OrientationMove_Test
    {
        private OrientationMove _orientation;

        [SetUp]
        public void SetUp()
        {
            _orientation = new OrientationMove();
        }

        [Test]
        public void ChangeDirection_TurnRight()
        {
            MoveDirection currentDirection = MoveDirection.North;

            currentDirection = _orientation.ChangeOrientation(Movement.Right, currentDirection);
            Assert.AreEqual(MoveDirection.East, currentDirection);
            currentDirection = _orientation.ChangeOrientation(Movement.Right, currentDirection);
            Assert.AreEqual(MoveDirection.South, currentDirection);
            currentDirection = _orientation.ChangeOrientation(Movement.Right, currentDirection);
            Assert.AreEqual(MoveDirection.West, currentDirection);
            currentDirection = _orientation.ChangeOrientation(Movement.Right, currentDirection);
            Assert.AreEqual(MoveDirection.North, currentDirection);
        }

        [Test]
        public void ChangeDirection_TurnLeft()
        {
            MoveDirection currentDirection = MoveDirection.North;
            currentDirection = _orientation.ChangeOrientation(Movement.Left, currentDirection);
            Assert.AreEqual(MoveDirection.West, currentDirection);
            currentDirection = _orientation.ChangeOrientation(Movement.Left, currentDirection);
            Assert.AreEqual(MoveDirection.South, currentDirection);
            currentDirection = _orientation.ChangeOrientation(Movement.Left, currentDirection);
            Assert.AreEqual(MoveDirection.East, currentDirection);
            currentDirection = _orientation.ChangeOrientation(Movement.Left, currentDirection);
            Assert.AreEqual(MoveDirection.North, currentDirection);
        }
    }
}