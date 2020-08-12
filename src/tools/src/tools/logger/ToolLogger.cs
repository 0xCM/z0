//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
// Original   : roslyn/src/Compilers/Core/CommandLine/CompilerServerLogger.cs
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct ToolLogger : IDisposable
    {
        public IToolContext Context {get;}        
    
        readonly FilePath Target;

        readonly Stream LogStream;
        
        [MethodImpl(Inline)]
        public ToolLogger(IToolContext context, FilePath target)
        {
            Context = context;
            Target = target;
            LogStream = new FileStream(target.CreateParentIfMissing().Name, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);;
        }

        public void Dispose()
        {
            LogStream.Dispose();
        }

        /// <summary>
        /// Log an exception. Also logs information about inner exceptions.
        /// </summary>
        public void Log(Exception exception, string reason)
        {
            LogError(ErrorTrace, exception.GetType().Name, exception.Message, reason, exception.StackTrace);

            int level = 0;

            Exception? e = exception.InnerException;
            while (e != null)
            {
                Log(AppMsgKind.Error, InnerTrace, level, e.GetType().Name, e.Message, e.StackTrace);
                e = e.InnerException;
                level += 1;
            }
        }

        /// <summary>
        /// Log a line of text to the logging file, with string.Format arguments.
        /// </summary>
        public void Log(AppMsgKind kind, string format, params object[] args)
            => Log(kind, string.Format(format, args));
        
        /// <summary>
        /// Log a line of text to the logging file.
        /// </summary>
        /// <param name="kind">The message kind</param>
        /// <param name="content">The message content</param>        
        public void Log(AppMsgKind kind, string content)
        {
            var data = Encoded.utf8(EntryPrefix + content + Eol);
            
            // Because multiple processes might be logging to the same file, we always seek to the end, write, and flush.
            LogStream.Seek(0, SeekOrigin.End);
            LogStream.Write(data, 0, data.Length);
            LogStream.Flush();
        }

        public void LogError(string content) 
            => Log(AppMsgKind.Error, $"Error: {content}");

        public void LogError(string format, params object[] args) 
            => Log(AppMsgKind.Error, $"Error: {format}", args);

        /// <summary>
        /// Get the string that prefixes all log entries. Shows the process, thread, and time.
        /// </summary>
        static string EntryPrefix
        {
            [MethodImpl(Inline)]
            get => string.Format(EntryPattern, CurrentProcess.ProcessId, CurrentProcess.OsThreadId, Environment.TickCount);
        }

        const string ErrorTrace = "'{0}' '{1}' occurred during '{2}'. Stack trace:\r\n{3}";
        
        const string InnerTrace = "Inner exception[{0}] '{1}' '{2}'. Stack trace: \r\n{3}";

        const string EntryPattern = "PID={1} TID={2} Ticks={3}: ";
        
    }
}