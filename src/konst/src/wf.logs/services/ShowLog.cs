//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;

    public readonly struct ShowLog : IDisposable
    {
        readonly IWfShell Wf;

        readonly Lazy<StreamWriter> _Writer;

        readonly Lazy<ITextBuffer> _Buffer;

        StreamWriter Writer => _Writer.Value;

        readonly FS.FilePath Target;

        [MethodImpl(Inline)]
        internal ShowLog(IWfShell wf, FS.FilePath dst)
        {
            Wf = wf;
            _Writer = root.lazy(() => dst.Writer());
            Target = dst;
            _Buffer = root.lazy(() => text.buffer());
        }

        public void Dispose()
        {
            if(_Writer.IsValueCreated)
            {
                Writer.Flush();
                Writer.Dispose();
            }
        }

        public ITextBuffer Buffer
        {
            [MethodImpl(Inline)]
            get => _Buffer.Value;
        }

        public void Show<T>(T src)
        {
            Writer.WriteLine(string.Format("{0}",src));
            Wf.Row(src);
        }

        public void ShowBuffer()
        {
            var src = Buffer.Emit();
            Writer.WriteLine(string.Format("{0}", src));
            Wf.Row(src);
        }
    }
}