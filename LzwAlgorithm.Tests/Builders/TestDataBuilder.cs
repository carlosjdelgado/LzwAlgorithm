using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LzwAlgorithm.Tests.Builders
{
    public class TestDataBuilder
    {
        private readonly string[] words = { "lorem", "ipsum", "dolor", "sit", "amet",
                "consectetuer", "adipiscing", "elit", "sed", "diam", "nonummy", "nibh",
                "euismod", "tincidunt", "ut", "laoreet", "dolore", "magna", "aliquam",
                "erat" };

        public byte[] Build(int sizeInBytes)
        {
            var result = new StringBuilder();
            var rand = new Random();

            while (result.Length < sizeInBytes)
            {
                result.Append(words[rand.Next(words.Length - 1)]);
            }

            result.Length = sizeInBytes;
            return result.ToString().Select(Convert.ToByte).ToArray();
        }
    }
}
