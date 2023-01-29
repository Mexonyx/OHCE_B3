using OHCE_B3;
using OHCE_B3.Langues;
using Xunit;

namespace OHCE.Test.xUnit
{
    public class OhceTest
    {
        [Fact]
        public void miroirTest()
        {
            Ohce ohce = new Ohce();

            var sortie = ohce.palyndrome("yolo");

            Assert.Equal("oloy", sortie);
        }

        [Theory]
        [InlineData(Expressions.Français.BienDit)]
        public void palyndromeTest(string bienDitAttendu)
        {
            Ohce ohce = new Ohce();

            var sortie = ohce.palyndrome("kayak");
            string palyndrome = "kayak";

            Assert.Contains(palyndrome + bienDitAttendu, sortie);
        }

    }
}
