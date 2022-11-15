﻿using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Wexflow.Tests
{
    [TestClass]
    public class PdfToText
    {
        private static readonly string PdfToTextFolder = @"C:\WexflowTesting\PdfToText\";

        [TestInitialize]
        public void TestInitialize()
        {
            Helper.DeleteFiles(PdfToTextFolder);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Helper.DeleteFiles(PdfToTextFolder);
        }

        [TestMethod]
        public void PdfToTextTest()
        {
            string[] files = GetFiles();
            Assert.AreEqual(0, files.Length);
            Helper.StartWorkflow(64);
            files = GetFiles();
            Assert.AreEqual(1, files.Length);
        }

        private string[] GetFiles()
        {
            return Directory.GetFiles(PdfToTextFolder, "*.txt");
        }
    }
}
