using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FundApps.Test
{
    [TestFixture]
    public class RoverPosition_Test
    {
        private RoverPosition _position;

        [SetUp]
        public void SetUp()
        {
            _position = new RoverPosition(new Grid(3, 3, new Position(0, 0)));
        }

        [Test]
        public void ChangeDirection_TurnRight()
        {
            _position.ChangeDirection(Movement.Right);
            Assert.AreEqual(RoverDirection.East, _position.Direction);
            _position.ChangeDirection(Movement.Right);
            Assert.AreEqual(RoverDirection.South, _position.Direction);
            _position.ChangeDirection(Movement.Right);
            Assert.AreEqual(RoverDirection.West, _position.Direction);
            _position.ChangeDirection(Movement.Right);
            Assert.AreEqual(RoverDirection.North, _position.Direction);
        }

        [Test]
        public void ChangeDirection_TurnLeft()
        {
            _position.ChangeDirection(Movement.Left);
            Assert.AreEqual(RoverDirection.West, _position.Direction);
            _position.ChangeDirection(Movement.Left);
            Assert.AreEqual(RoverDirection.South, _position.Direction);
            _position.ChangeDirection(Movement.Left);
            Assert.AreEqual(RoverDirection.East, _position.Direction);
            _position.ChangeDirection(Movement.Left);
            Assert.AreEqual(RoverDirection.North, _position.Direction);
        }

        [Test]
        public void Move_Forward_North()
        {
            Assert.AreEqual(0, _position.CurrentPosition.X);
            Assert.AreEqual(0, _position.CurrentPosition.Y);
            _position.Move(Movement.Forward);
            Assert.AreEqual(0, _position.CurrentPosition.X);
            Assert.AreEqual(1, _position.CurrentPosition.Y);
            _position.Move(Movement.Forward);
            Assert.AreEqual(0, _position.CurrentPosition.X);
            Assert.AreEqual(2, _position.CurrentPosition.Y);
            _position.Move(Movement.Forward);
            Assert.AreEqual(0, _position.CurrentPosition.X);
            Assert.AreEqual(3, _position.CurrentPosition.Y);
            _position.Move(Movement.Forward);
            Assert.AreEqual(0, _position.CurrentPosition.X);
            Assert.AreEqual(0, _position.CurrentPosition.Y);
        }

        [Test]
        public void Move_Backwards_North()
        {
            Assert.AreEqual(0, _position.CurrentPosition.X);
            Assert.AreEqual(0, _position.CurrentPosition.Y);
            _position.Move(Movement.Backwards);
            Assert.AreEqual(0, _position.CurrentPosition.X);
            Assert.AreEqual(3, _position.CurrentPosition.Y);
            _position.Move(Movement.Backwards);
            Assert.AreEqual(0, _position.CurrentPosition.X);
            Assert.AreEqual(2, _position.CurrentPosition.Y);
            _position.Move(Movement.Backwards);
            Assert.AreEqual(0, _position.CurrentPosition.X);
            Assert.AreEqual(1, _position.CurrentPosition.Y);
            _position.Move(Movement.Backwards);
            Assert.AreEqual(0, _position.CurrentPosition.X);
            Assert.AreEqual(0, _position.CurrentPosition.Y);
        }
    }
}