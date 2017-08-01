using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NasaRover.Test
{
    [TestFixture]
    internal class DirectionMove_North_Test
    {
        private DirectionMove _directionMove;
        private Grid _grid;
        private MoveDirection direction;

        [SetUp]
        public void SetUp()
        {
            _grid = new Grid(4, 4, new Position(0, 0));
            _directionMove = new DirectionMove(_grid);
            direction = MoveDirection.North;
        }

        [Test]
        public void Move_Forward_North()
        {
            Assert.AreEqual(0, _grid.CurrentPosition.X);
            Assert.AreEqual(0, _grid.CurrentPosition.Y);
            _directionMove.Move(Movement.Forward, direction);
            Assert.AreEqual(0, _grid.CurrentPosition.X);
            Assert.AreEqual(1, _grid.CurrentPosition.Y);
            _directionMove.Move(Movement.Forward, direction);
            Assert.AreEqual(0, _grid.CurrentPosition.X);
            Assert.AreEqual(2, _grid.CurrentPosition.Y);
            _directionMove.Move(Movement.Forward, direction);
            Assert.AreEqual(0, _grid.CurrentPosition.X);
            Assert.AreEqual(3, _grid.CurrentPosition.Y);
            _directionMove.Move(Movement.Forward, direction);
            Assert.AreEqual(0, _grid.CurrentPosition.X);
            Assert.AreEqual(0, _grid.CurrentPosition.Y);
        }

        [Test]
        public void Move_Backwards_North()
        {
            Assert.AreEqual(0, _grid.CurrentPosition.X);
            Assert.AreEqual(0, _grid.CurrentPosition.Y);
            _directionMove.Move(Movement.Backwards, direction);
            Assert.AreEqual(0, _grid.CurrentPosition.X);
            Assert.AreEqual(3, _grid.CurrentPosition.Y);
            _directionMove.Move(Movement.Backwards, direction);
            Assert.AreEqual(0, _grid.CurrentPosition.X);
            Assert.AreEqual(2, _grid.CurrentPosition.Y);
            _directionMove.Move(Movement.Backwards, direction);
            Assert.AreEqual(0, _grid.CurrentPosition.X);
            Assert.AreEqual(1, _grid.CurrentPosition.Y);
            _directionMove.Move(Movement.Backwards, direction);
            Assert.AreEqual(0, _grid.CurrentPosition.X);
            Assert.AreEqual(0, _grid.CurrentPosition.Y);
        }
    }
}