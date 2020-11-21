//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Konst;
    using static z;

    class Dynoshell : IDisposable
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        public Dynoshell(IWfShell wf)
        {
            Host = WfShell.host(typeof(Dynoshell));
            Wf = wf.WithHost(Host);
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        ICmdSpec[] Commands()
        {
            var db = Wf.Db();
            var archive = Wf.RuntimeArchive();
            var buffer = z.list<ICmdSpec>();
            var dst = span<ICmdSpec>(buffer);
            var cmd = default(EmitResourceDataCmd);
            var src = default(Assembly);

            src = archive.Srm;
            cmd = new EmitResourceDataCmd();
            cmd.Source = src;
            cmd.Target = db.Reflected(src);
            cmd.ClearTarget = true;
            buffer.Add(cmd);

            src = archive.CodeAnalysis;
            cmd = new EmitResourceDataCmd();
            cmd.Source = src;
            cmd.Target = db.Reflected(src);
            cmd.ClearTarget = true;
            buffer.Add(cmd);

            buffer.Add(Wf.CmdCatalog.EmitRuntimeIndex());

            buffer.Add(Wf.CmdCatalog.ShowRuntimeArchive());

            var spec = EmitAsmOpCodes.Spec();
            spec.WithTarget(Wf.Db().RefDataPath("asm.opcodes"));
            buffer.Add(spec);

            return buffer.Array();
        }

        public void DispatchCommands()
        {
            using var flow = Wf.Running();
            using var runner = new ToolRunner(Wf, Host);
            iter(Wf.Router.SupportedCommands.Storage, c => Wf.Status($"{c} enabled"));

            runner.Run(new EmitHexIndexCmd());

            //runner.Run(Wf.CmdCatalog.EmitRuntimeIndex());
            // var commands = @readonly(Commands());
            // var count = commands.Length;
            // for(var i=0; i<count; i++)
            //     runner.Run(skip(commands,i));
        }

        public void Run()
        {
            DispatchCommands();
        }
    }

    readonly struct Msg
    {
        public static RenderPattern<uint,ApiHostUri,uint> IndexedHost => "{2} | {0} | {1} | Api summary accumulation";

        public static RenderPattern<uint,FS.FilePath> EmittedOpIndex => "Emitted operation index for {0} hosts to {1}";

        public static RenderPattern<T> Dispatching<T>()
            where T : struct, ICmdSpec<T> => "Dispatching {0}";

        public static RenderPattern<CmdId> Dispatching() => "Dispatching {0}";
    }
}