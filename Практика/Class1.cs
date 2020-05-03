using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace Практика
{
    class Class1
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        private static void Class(string[] args)
        {
            logger.Trace("trace message");
            logger.Debug("debug message");
            logger.Info("info message");
            logger.Warn("warn message");
            logger.Error("error message");
            logger.Fatal("fatal message");
        }
    }
}
