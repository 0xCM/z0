//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CmdLogger : IDisposable
    {
        public IWfShell Wf {get;}

        readonly FS.FilePath Target;

        readonly Stream LogStream;

        [MethodImpl(Inline)]
        public CmdLogger(IWfShell wf, FS.FilePath dst)
        {
            Wf = wf;
            Target = dst;
            LogStream = new FileStream(dst.EnsureParentExists().Name, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);;
        }

        public void Dispose()
        {
            LogStream.Dispose();
        }

        public void Log(in ErrorEvent<Exception> error)
        {
            Log(LogLevel.Error, error.Format());
        }

        /// <summary>
        /// Log a line of text to the logging file, with string.Format arguments.
        /// </summary>
        public void Log(LogLevel kind, params object[] args)
            => Log(kind, string.Join("| ", args));

        /// <summary>
        /// Log a line of text to the logging file.
        /// </summary>
        /// <param name="kind">The message kind</param>
        /// <param name="content">The message content</param>
        public void Log(LogLevel kind, string content)
        {
            const string Pattern = "| {0,-10} | {1}";
            var entry = string.Format(Pattern, kind, content);
            var data = Encoded.utf8(entry + Eol);
            LogStream.Seek(0, SeekOrigin.End);
            LogStream.Write(data, 0, data.Length);
            LogStream.Flush();
        }

        public void LogError(string content)
            => Log(LogLevel.Error, content);

        public void LogError(string format, params object[] args)
            => Log(LogLevel.Error, args);
    }
}