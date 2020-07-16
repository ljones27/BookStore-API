﻿using BookStore_API.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NLog;

namespace BookStore_API.Services
{
    public class LoggerService : ILoggerService
    {

        private static ILogger logger = LogManager.GetCurrentClassLogger();

        void ILoggerService.LogDebug(string message)
        {
            logger.Debug(message);
        }

        void ILoggerService.LogError(string message)
        {
            logger.Error(message);
        }

        void ILoggerService.LogInfo(string message)
        {
            logger.Info(message);
        }

        void ILoggerService.LogWarn(string message)
        {
            logger.Warn(message);
        }
    }
}
