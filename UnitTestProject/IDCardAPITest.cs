using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static TerminalDLL.IDCardAPI;
namespace UnitTestProject
{
    /// <summary>
    /// IDCardAPITest 的摘要说明
    /// </summary>
    [TestClass]
    public class IDCardAPITest
    {
        public IDCardAPITest()
        {
            //
            //TODO:  在此处添加构造函数逻辑
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性: 
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestSyn_FindReader()
        {
            string stmp;
            int i, nRet,m_iPort;
            uint[] iBaud = new uint[1];
            i = Syn_FindReader();
            m_iPort = i;
            Assert.AreEqual(i, 1001);
            //if (i > 0)
            //{
            //    if (i > 1000)
            //    {
            //        stmp = Convert.ToString(i);
            //        stmp = Convert.ToString(System.DateTime.Now) + "  读卡器连接在USB " + stmp;
            //    }
            //    else
            //    {
            //        System.Threading.Thread.Sleep(200);
            //        nRet = Syn_GetCOMBaud(i, ref iBaud[0]);
            //        stmp = Convert.ToString(i);
            //        stmp = Convert.ToString(System.DateTime.Now) + "  读卡器连接在COM " + stmp + ";当前波特率为 " + Convert.ToString(iBaud[0]);
            //    }
            //}
            //else
            //{
            //    stmp = Convert.ToString(System.DateTime.Now) + "  没有找到读卡器";
            //}
        }
    }
}
