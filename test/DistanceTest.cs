﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makaretu.Collections
{
    [TestClass]
    public class DistanceTest
    {
        /// <summary>
        ///  From https://github.com/tristanls/k-bucket/blob/master/test/defaultDistance.js
        /// </summary>
        [TestMethod]
        public void Tristanls()
        {
            var bucket = new KBucket();

            Assert.AreEqual(0, bucket.Distance(new byte[] { 0x00 }, new byte[] { 0x00 }));
            Assert.AreEqual(1, bucket.Distance(new byte[] { 0x00 }, new byte[] { 0x01 }));
            Assert.AreEqual(3, bucket.Distance(new byte[] { 0x02 }, new byte[] { 0x01 }));
            Assert.AreEqual(255, bucket.Distance(new byte[] { 0x00 }, new byte[] { 0x00, 0x00 }));
            Assert.AreEqual(16640, bucket.Distance(new byte[] { 0x01, 0x24 }, new byte[] { 0x40, 0x24 }));
        }
    }
}