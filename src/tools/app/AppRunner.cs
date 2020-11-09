//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    ref struct AppRunner
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly Multiplex Mpx;

        readonly AppArgs Args;

        readonly CmdBuilder CmdBuilder;

        readonly IFileDb Db;

        public AppRunner(IWfShell wf, WfHost host)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Mpx = Multiplex.create(wf, Multiplex.configure(wf.Db().Root));
            Args = wf.Args;
            CmdBuilder = wf.CmdBuilder();
            Db = Wf.Db();
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


        public void Run()
        {
            using var runner = new ToolRunner(Wf, Host);
            // var cmd = Wf.CmdCatalog.EmitResourceData();
            // cmd.Source = Parts.Refs.Assembly;
            // cmd.Target = Wf.Db().RefDataRoot() + FS.folder("test.emission");
            // cmd.ClearTarget = true;

            var commands = @readonly(Commands());
            var count = commands.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var cmd = ref skip(commands,i);
                Wf.Status(cmd.Source);
                runner.Run(cmd);
            }
        }
    }


    partial class XTend
    {
        [MethodImpl(Inline), Op]
        public static FS.FilePath Path(this Assembly src)
            => FS.path(src.Location);
    }
}