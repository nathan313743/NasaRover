using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundApps
{
    public class Rover
    {
        private MovementService _moveService;

        public Rover(MovementService moveService)
        {
            _moveService = moveService;
        }

        public Position CurrentPosition => _moveService.CurrentPosition;

        public Result Move(Movement command)
        {
            return _moveService.Move(command);
        }
    }
}