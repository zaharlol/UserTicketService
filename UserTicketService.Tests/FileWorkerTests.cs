using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTicketService.Tests
{
    [TestFixture]
    public class FileWorkerTests
    {
        [Test]
        public void FWT()
        {
            var FWR = new FileWorker();

            PrivateObject po = new PrivateObject(FWR);
            var pF = po.Invoke("GetSafeFilename", @"Raaxa____asdasdasd");
            NUnit.Framework.Assert.AreEqual(pF, "Raaxa____asdasdasd");
        }
    }
}
