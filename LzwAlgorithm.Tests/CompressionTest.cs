using LzwAlgorithm.Tests.Builders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;

namespace LzwAlgorithm.Tests
{
    [TestClass]
    public class CompressionTest
    {
        [TestMethod]
        public void CompressAndDecompressTest()
        {
            var lzwCore = new LzwCore();
            var testData = new TestDataBuilder().Build(4 * 1024 * 1024);

            var compressedData = lzwCore.Compress(testData);
            var uncompressedData = lzwCore.UnCompress(compressedData);

            Assert.IsTrue(uncompressedData.SequenceEqual(testData));
        }
    }
}
