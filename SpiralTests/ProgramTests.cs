using Spiral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SpiralTests
{
    public class ProgramTests
    {
        [Fact]
        public void Working()
        {
            Assert.True(true);
        }

        [Fact]
        public void BoardGeneratedWithCorrectDimensions()
        {
            var board = new Board(5, 5);

            Assert.Equal(5, board.Cells.Length);
            Assert.Equal(5, board.Cells[0].Length);
        }
    }
}
