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

    ref struct Runner
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        public Runner(IWfShell wf)
        {
            Host = WfSelfHost.create(typeof(Runner));
            Wf = wf.WithHost(Host);
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        EmitResourceDataCmd[] Commands()
        {
            var db = Wf.Db();
            var archive = Wf.RuntimeArchive();
            var buffer = z.list<EmitResourceDataCmd>();
            var dst = span<EmitResourceDataCmd>(buffer);
            var cmd = default(EmitResourceDataCmd);
            var src = default(Assembly);

            src = archive.Dia2Lib;
            cmd = new EmitResourceDataCmd();
            cmd.Source = src;
            cmd.Target = db.Reflected(src);
            cmd.ClearTarget = true;
            buffer.Add(cmd);

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

            return buffer.Array();
        }



        public void EmitRuntimeIndex()
        {
            using var flow = Wf.Running();
            var cmd = Wf.CmdCatalog.EmitRuntimeIndex();

            using var runner = new ToolRunner(Wf, Host);
            // var cmd = Wf.CmdCatalog.EmitResourceData();
            // cmd.Source = Parts.Refs.Assembly;
            // cmd.Target = Wf.Db().RefDataRoot() + FS.folder("test.emission");
            // cmd.ClearTarget = true;

            var commands = @readonly(Commands());
            var count = commands.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var cmd2 = ref skip(commands,i);
                Wf.Status(cmd2.Source);
                runner.Run(cmd2);
            }        }

        public void Run()
        {

        }
    }

    readonly struct Msg
    {
        public static RenderPattern<uint,ApiHostUri,uint> IndexedHost => "{2} | {0} | {1} | Api summary accumulation";

        public static RenderPattern<uint> IndexingHosts => "Indexing {0} hosts";

        public static RenderPattern<T> Dispatching<T>()
            where T : struct, ICmdSpec<T> => "Dispatching {0}";


        public static RenderPattern<Assembly,utf8> NoMatchingResources => "No {0} resources found that match {1}";


        public static RenderPattern<Assembly,uint>  EmittingResources => "Emitting {1} {0} resources";

    }
}