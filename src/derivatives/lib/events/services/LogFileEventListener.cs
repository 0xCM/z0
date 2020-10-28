//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.X.Events
{
    using System;
    using System.IO;

    public class LogFileEventListener : EventListener
    {
        FileStream logFile;

        TextWriter writer;

        public LogFileEventListener(string logFilePath, EventLevel maxVerbosity, EventKeys keywordFilter, IEventListenerEventSink eventSink)
            : base(maxVerbosity, keywordFilter, eventSink)
        {
            this.SetLogFilePath(logFilePath);
        }

        public override void Dispose()
        {
            if (this.writer != null)
            {
                this.writer.Dispose();
                this.writer = null;
            }

            if (this.logFile != null)
            {
                this.logFile.Dispose();
                this.logFile = null;
            }
        }

        protected override void RecordMessageInternal(TraceEventMessage message)
        {
            this.writer.WriteLine(this.GetLogString(message.EventName, message.Opcode, message.Payload));
            this.writer.Flush();
        }

        protected void SetLogFilePath(string newfilePath)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(newfilePath));
            this.logFile = File.Open(newfilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
            this.logFile.Seek(0, SeekOrigin.End);
            this.writer = StreamWriter.Synchronized(new StreamWriter(this.logFile));
        }
    }
}