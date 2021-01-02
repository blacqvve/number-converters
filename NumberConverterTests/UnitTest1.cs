using NumberConverter;
using NUnit.Framework;

namespace NumberConverterTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [TestCase(1996,"MCMXCVI")]
        [TestCase(3,"III")]
        [TestCase(5688,"MMMMMDCLXXXVIII")]
        [TestCase(189862,"MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMDCCCLXII")]
        public void RomanConverterTest(int value,string output)
        {
            //https://www.mathsisfun.com/roman-numerals.html test results according to Roman Number converter in this website
            Assert.AreEqual(value.RomanNumber(),output);
        }
    }
}