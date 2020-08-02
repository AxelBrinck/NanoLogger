﻿using System.IO;
using LoggingFramework.Entities;
using LoggingFramework.Format;

namespace LoggingFramework.Output
{
    public class StreamLogOutput : ILogOutput
    {
        private readonly StreamWriter _writer;
        private readonly ILogStringFormat _format;
            
        public StreamLogOutput(Stream stream, ILogStringFormat format)
        {
            _writer = new StreamWriter(stream);
            _format = format;
        }
        
        public void Store(LogInfo logInfo)
        {
            var formattedLog = _format.Format(logInfo);
            
            _writer.WriteLine(formattedLog);
            
            _writer.Flush();
        }
    }
}