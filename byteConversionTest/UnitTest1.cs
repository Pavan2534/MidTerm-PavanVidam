using NUnit.Framework;
using byteConversion;

namespace byteConversionTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConvertMbToBtTest1()
        {
            //ARRANGE
            Conversion conversion = new Conversion();
            //ACT
            double bytes = conversion.ConvertMegabyteToByte(50);
            //ASSERT
            Assert.AreEqual(52428800, bytes);

        }
        [Test]
        public void ConvertGbToMbTest2()
        {
            //ARRANGE
            Conversion conversion = new Conversion();
            //ACT
            double megabytes = conversion.ConvertGigabyteToMegabyte(20);
            //ASSERT
            Assert.AreEqual(20480, megabytes);

        }

        [Test]
        public void ConvertTbToGbTest3()
        {
            //ARRANGE
            Conversion conversion = new Conversion();
            //ACT
            double gigabytes = conversion.ConvertTerrabyteToGigabyte(90);
            //ASSERT
            Assert.AreEqual(92160, gigabytes);

        }

        [Test]
        public void ConvertTbTestGbTest4()
        {
            //ARRANGE
            Conversion conversion = new Conversion();
            //ACT
            double gigabytes = conversion.ConvertTerrabyteToGigabyte(120);
            //ASSERT
            //Assert.AreEqual(92160, gigabytes);
            Assert.IsTrue(gigabytes > 100);

        }


        [Test]
        public void ConvertGbTestMbTest5()
        {
            //ARRANGE
            Conversion conversion = new Conversion();
            //ACT
            double megabytes = conversion.ConvertGigabyteToMegabyte(40);
            //ASSERT
            //Assert.AreEqual(92160, gigabytes);
            Assert.IsTrue(megabytes > 10);


        }


    }
}