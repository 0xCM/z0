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

        protected StreamWriter OpenShowLog(string name, FS.FileExt? ext = null)
            => Db.ShowLog(name, ext: ext ??FS.Extensions.Csv).Writer();

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