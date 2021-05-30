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
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    [WfService]
    public abstract class AppService<H> : IAppService<H>
        where H : AppService<H>, new()
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
        public static H create(IWfRuntime wf)
        {
            var service = @new();
            service.Init(wf);
            return service;
        }

        public IWfRuntime Wf {get; private set;}

        protected WfHost Host {get; private set;}

        public IWfDb Db {get; private set;}

        public EnvData Env => Wf.Env;

        public virtual Type ContractType
            => typeof(H);

        protected WfCmdBuilder CmdBuilder
            => Wf.CmdBuilder();

        public Identifier HostName {get;}

        public void Init(IWfRuntime wf)
        {
            var flow = wf.Creating(typeof(H).Name);
            Host = new WfSelfHost(typeof(H));
            Wf = wf.WithHost(Host);
            Db = new WfDb(wf, wf.Env.Db);
            OnInit();
            Initialized();
            wf.Created(flow);
        }

        protected AppService()
        {
            HostName = GetType().Name;
        }

        protected string Worker([Caller] string name = null)
            => string.Format("{0,-14}",string.Format("worker({0}) >>", name));

        protected AppService(IWfRuntime wf)
            : this()
        {
            Host = new WfSelfHost(HostName);
            Wf = wf;
        }

        FS.FileName NameShowLog(string src, FS.FileExt ext)
            => FS.file(root.controller().Id().PartName() + "." + HostName + "." + src, ext);

        ShowLog ShowLog(FS.FileName file)
            => new ShowLog(Wf, Db.ShowLog(file));

        protected ShowLog ShowLog(FS.FileExt ext, [Caller] string name = null)
            => ShowLog(NameShowLog(name,ext));

        protected ShowLog ShowLog([Caller] string name = null, FS.FileExt? ext = null)
            => ShowLog(NameShowLog(name,ext ?? FS.Csv));

        protected StreamWriter OpenShowLog(string name, FS.FileExt? ext = null)
            => Db.ShowLog(NameShowLog(name, ext ?? FS.Csv)).Writer();

        protected StreamWriter OpenAppLog(string name, FS.FileExt ext)
            => Db.AppLog(name,ext).Writer();

        protected void Show(string name, FS.FileExt ext, Action<ShowLog> f)
        {
            using var log = ShowLog(NameShowLog(name,ext));
            f(log);
        }

        protected void ShowRecords<T>(ReadOnlySpan<T> src)
            where T : struct, IRecord<T>
        {
            var id = Tables.identify<T>();
            var count = src.Length;
            if(count ==0)
            {
                Wf.Warn($"No {id} records were provided");
                return;
            }
            var dst = Db.AppLogDir() + FS.file(id.Format(), FS.Csv);
            var flow = Wf.EmittingTable<T>(dst);
            var formatter = Tables.formatter<T>();
            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
            {
                var formatted = formatter.Format(memory.skip(src,i));
                writer.WriteLine(formatted);
                Wf.Row(formatted);
            }
            Wf.EmittedTable(flow, count);
        }

        [Op,Closures(UInt64k)]
        protected void ShowSymbols<T>(Symbols<T> src, ShowLog dst)
            where T : unmanaged
        {
            var count = src.Count;
            var symbols = src.View;
            for(var i=0; i<count; i++)
                dst.Show(core.skip(symbols,i).Format());
        }

        protected void ShowSpan<T>(ReadOnlySpan<T> src, FS.FileName file, Func<T,string> render, string title = EmptyString)
        {
            var count = src.Length;
            if( count != 0)
            {
                using var log = ShowLog(file);

                if(text.nonempty(title))
                    log.Show(title);

                for(var i=0; i<count; i++)
                    log.Show(render(core.skip(src,i)));
            }
        }

        protected void Babble<T>(T content)
            => Wf.Babble(content);

        protected void Babble(string pattern, params object[] args)
            => Wf.Babble(string.Format(pattern,args));

        protected void Status<T>(T content)
            => Wf.Status(content);

        protected void Status(string pattern, params object[] args)
            => Wf.Status(string.Format(pattern,args));

        protected void Warn<T>(T content)
            => Wf.Warn(content);

        protected void Warn(string pattern, params object[] args)
            => Wf.Warn(string.Format(pattern,args));

        protected void RowMsg<T>(T content)
            => Wf.Row(content);

        protected void RowMsg(string pattern, params object[] args)
            => Wf.Row(string.Format(pattern,args));

        protected void ShowSpan<T>(ReadOnlySpan<T> src, FS.FileName file, string title = EmptyString)
            => ShowSpan(src, file, item => text.format("{0}", item), title);

        protected void Show<T>(T data, StreamWriter dst)
        {
            dst.WriteLine(string.Format("{0}",data));
            Wf.Row(data);
        }

        protected uint TableEmit<T>(ReadOnlySpan<T> src, FS.FilePath dst)
            where T : struct, IRecord<T>
        {
            var flow = Wf.EmittingTable<T>(dst);
            var count = Tables.emit(src,dst);
            Wf.EmittedTable(flow,count);
            return count;
        }

        protected uint TableEmit<T>(ReadOnlySpan<T> src, ReadOnlySpan<byte> widths, FS.FilePath dst)
            where T : struct, IRecord<T>
        {
            var flow = Wf.EmittingTable<T>(dst);
            var count = Tables.emit(src, widths, dst);
            Wf.EmittedTable(flow,count);
            return count;
        }

        protected uint TableEmit<T>(Span<T> src, ReadOnlySpan<byte> widths,  FS.FilePath dst)
            where T : struct, IRecord<T>
                => TableEmit(src.ReadOnly(), widths, dst);

        protected uint TableEmit<T>(Span<T> src, FS.FilePath dst)
            where T : struct, IRecord<T>
                => TableEmit(src.ReadOnly(), dst);

        protected uint TableEmit<T>(T[] src, FS.FilePath dst)
            where T : struct, IRecord<T>
                => TableEmit(core.@readonly(src), dst);

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