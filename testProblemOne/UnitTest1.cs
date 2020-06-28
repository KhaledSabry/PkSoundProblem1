using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit.Framework;
using problemOne;
using System.Collections.Generic;
using Xunit;

namespace testProblemOne
{
    [TestClass]
    public class UnitTest1
    {
        public static IEnumerable<object[]> TestMethodInput
        {
            get
            {
                return new[]
                {
                    new object[] {
@"5 5
1 2 N
LMLMLMLMM
3 3 E
MMRMMRMRRM",
@"1 3 N
5 1 E"} ,
                    
                    new object[] {
@"7 7
0 3 W
RMMMLLMLLM
0 3 E
MRRMRMRRM",
@"0 6 N
0 3 S"} ,
                };
            }
        }

        [DynamicData(nameof(TestMethodInput))]
        [DataTestMethod]  
        public void TestMethod1(string input,string Expected)
        { 
            plateauProject project1 = new plateauProject(input);
            string result = project1.state;

             Assert.AreEqual(Expected, result); 
        }
         
    }
}
