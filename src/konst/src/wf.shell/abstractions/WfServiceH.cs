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

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

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

    [WfService]
    public abstract class WfService<H> : IWfService<H>
        where H : WfService<H>, new()
    {
        /// <summary>
        /// Instantites the serice without initialization
        /// </summary>
        [MethodImpl(Inline)]
        protected static H @new() => new H();

        /// <summary>
        /// Creates and initializes the service
        /// </summary>
        /// <param name="wf">The source workflow</param>
        public static H create(IWfShell wf)
        {
            var service = @new();
            service.Init(wf);
            return service;
        }

        IWfEventCache Events {get; set;}

        public IWfShell Wf {get; private set;}

        protected WfHost Host {get; private set;}

        public IWfDb Db {get; private set;}

        public virtual Type ContractType
            => typeof(H);

        protected CmdBuilder CmdBuilder
            => Wf.CmdBuilder();

        public void Init(IWfShell wf)
        {
            wf.Babble($"Initializing {typeof(H).Name}");
            Host = WfShell.host(typeof(H));
            Wf = wf.WithHost(Host);
            Db = new WfDb(wf, wf.Env.Db.Value);
            Events = EventCache.init(wf);
            OnInit();
            Initialized();
            wf.Babble($"Initialized {typeof(H).Name}");
        }

        protected WfService()
        {

        }

        protected WfService(IWfShell wf)
        {
            Host = WfShell.host(typeof(H));
            Wf = wf.WithHost(Host);
        }

        protected ShowLog ShowLog(FS.FileExt ext, [Caller] string name = null)
            => new ShowLog(Wf, Db.ShowLog(name, ext));

        protected ShowLog ShowLog([Caller] string name = null, FS.FileExt? ext = null)
            => new ShowLog(Wf, Db.ShowLog(name, ext ?? FS.Extensions.Csv));

        protected StreamWriter OpenShowLog(string name, FS.FileExt? ext = null)
            => Db.ShowLog(name, ext ?? FS.Extensions.Csv).Writer();

        protected void Show<T>(T data, StreamWriter dst)
        {
            dst.WriteLine(string.Format("{0}",data));
            Wf.Row(data);
        }

        protected virtual void OnInit()
        {

        }

        protected virtual void Initialized()
        {

        }
        protected virtual void Disposing() { }

        public void Dispose()
        {
            Disposing();
            Wf.Disposed();
        }
    }
}