//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Text;

    using static Root;
    using static core;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

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

        ITextBuffer _TextBuffer;

        public EnvData Env => Wf.Env;

        public virtual Type ContractType
            => typeof(H);

        public Identifier HostName {get;}

        public void Init(IWfRuntime wf)
        {
            var flow = wf.Creating(typeof(H).Name);
            Host = new WfSelfHost(typeof(H));
            Wf = wf;
            Db = new WfDb(wf, wf.Env.Db);
            OnInit();
            Initialized();
            wf.Created(flow);
        }

        protected AppService()
        {
            HostName = GetType().Name;
            _TextBuffer = TextTools.buffer();
        }

        protected string Worker([Caller] string name = null)
            => string.Format("{0,-14}",string.Format("worker({0}) >>", name));

        protected AppService(IWfRuntime wf)
            : this()
        {
            Host = new WfSelfHost(HostName);
            Wf = wf;
        }

        protected ITextBuffer TextBuffer()
        {
            _TextBuffer.Clear();
            return _TextBuffer;
        }

        protected void RedirectEmissions(string name, FS.FolderPath dst)
            => Wf.RedirectEmissions(WfEmissionLog.create(name,dst));

        FS.FileName NameShowLog(string src, FS.FileExt ext)
            => FS.file(core.controller().Id().PartName() + "." + HostName + "." + src, ext);

        ShowLog ShowLog(FS.FileName file)
            => new ShowLog(Wf, Db.ShowLog(file));

        protected ShowLog ShowLog(FS.FileExt ext, [Caller] string name = null)
            => ShowLog(NameShowLog(name,ext));

        protected ShowLog ShowLog([Caller] string name = null, FS.FileExt? ext = null)
            => ShowLog(NameShowLog(name,ext ?? FS.Csv));

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
                var formatted = formatter.Format(core.skip(src,i));
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
                dst.Show(skip(symbols,i).Format());
        }

        protected void Pipe<S,T>(ReadOnlySpan<S> src, Func<S,T> converter, string channel = null)
            where T : ITextual
        {
            var count = src.Length;
            if(count != 0)
            {
                var dst = Db.AppLog(string.Format("{0}.{1}",Timestamp.now(), channel ?? typeof(T).Name));
                using var writer = dst.AsciWriter();
                for(var i=0; i<count; i++)
                    writer.WriteLine((converter(skip(src,i)).Format()));
            }
        }

        protected void Pipe<T>(ReadOnlySpan<T> src, string channel = null)
            where T : ITextual
        {
            var count = src.Length;
            if(count != 0)
            {
                var dst = Db.AppLog(string.Format("{0}.{1}",Timestamp.now(), channel ?? typeof(T).Name));
                using var writer = dst.AsciWriter();
                for(var i=0; i<count; i++)
                    writer.WriteLine(skip(src,i).Format());
            }
        }

        protected void Babble<T>(T content)
            => Wf.Babble(content);

        protected void Babble(string pattern, params object[] args)
            => Wf.Babble(string.Format(pattern,args));

        protected void Status<T>(T content)
            => Wf.Status(content);

        protected void Status(ReadOnlySpan<char> src)
            => Wf.Status(new string(src));

        protected void Status(string pattern, params object[] args)
            => Wf.Status(string.Format(pattern,args));

        protected void Warn<T>(T content)
            => Wf.Warn(content);

        protected void Warn(string pattern, params object[] args)
            => Wf.Warn(string.Format(pattern,args));

        protected void Write<T>(T content)
            => Wf.Row(content);

        protected void Write(ReadOnlySpan<char> src)
            => Wf.Row(new string(src));

        protected void Write<T>(T src, StreamWriter dst)
        {
            dst.WriteLine(src.ToString());
            Wf.Row(src);
        }

        protected void Write<T>(ReadOnlySpan<T> src)
            where T : struct, IRecord<T>
        {
            Tables.emit(src, x => Wf.Row(x));
        }

        protected void Error<T>(T content)
            => Wf.Error(content);

        protected WfExecFlow<T> Running<T>(T msg, [Caller] string operation = null)
            where T : IMsgPattern
                => Wf.Running(msg, string.Format("{0}/{1}", HostName, operation));

        protected WfExecFlow<string> Running([Caller] string msg = null)
            => Wf.Running(string.Format("{0}/{1}", HostName, msg));

        protected ExecToken Ran<T>(WfExecFlow<T> flow, [Caller] string msg = null)
                => Wf.Ran(flow.WithMsg(string.Format("{0}/{1}", HostName, msg)));

        protected ExecToken Ran<T,D>(WfExecFlow<T> flow, D data, [Caller] string operation = null)
            where T : IMsgPattern
                => Wf.Ran(flow.WithMsg(string.Format("{0} | {1}/{2}", data, HostName, operation)));

        protected WfFileFlow EmittingFile(FS.FilePath dst)
            => Wf.EmittingFile(dst);

        public ExecToken EmittedFile(WfFileFlow flow, Count count)
            => Wf.EmittedFile(flow,count);

        protected WfTableFlow<T> EmittingTable<T>(FS.FilePath dst)
            where T : struct, IRecord<T>
                => Wf.EmittingTable<T>(dst);

        protected ExecToken EmittedTable<T>(WfTableFlow<T> flow, Count count, FS.FilePath? dst = null)
            where T : struct, IRecord<T>
                => Wf.EmittedTable(flow,count, dst);

        protected uint Emit<T>(ReadOnlySpan<T> src, FS.FilePath dst)
            where T : struct, IRecord<T>
        {
            var flow = EmittingTable<T>(dst);
            var spec = Tables.rowspec<T>();
            var count = Tables.emit(src, spec, dst);
            EmittedTable(flow,count);
            return count;
        }

        protected uint Emit<T>(ReadOnlySpan<T> src, ReadOnlySpan<byte> widths, FS.FilePath dst)
            where T : struct, IRecord<T>
        {
            var flow = EmittingTable<T>(dst);
            var spec = Tables.rowspec<T>(widths, z16);
            var count = Tables.emit(src, spec, dst);
            EmittedTable(flow,count);
            return count;
        }

        protected uint Emit<T>(ReadOnlySpan<T> src, ReadOnlySpan<byte> widths, ushort rowpad, Encoding encoding, FS.FilePath dst)
            where T : struct, IRecord<T>
        {
            var flow = Wf.EmittingTable<T>(dst);
            var spec = Tables.rowspec<T>(widths, rowpad);
            var count = Tables.emit(src, spec, encoding, dst);
            Wf.EmittedTable(flow, count);
            return count;
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