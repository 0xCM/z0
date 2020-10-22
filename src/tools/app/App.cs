//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static z;

    sealed class App : WfHost<App>
    {
        public App()
        {

        }

        public static void Main(params string[] args)
        {
            try
            {
                using var wf = WfShell.create(args);
                using var runner = new AppRunner(wf, App.create());
                runner.Run();
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }
    }

    ref struct AppRunner
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly Multiplex Mpx;

        public AppRunner(IWfShell wf, WfHost host)
        {
            Host = host;
            Wf = wf;
            Mpx = Multiplex.create(Multiplex.configure(wf.Db().Root));
        }

        CmdResult EmitOpCodes()
            => EmitAsmOpCodes.run(Wf);

        CmdResult EmitPatterns()
            => EmitRenderPatterns.run(Wf, Wf.CmdBuilder().EmitRenderPatterns(typeof(RP)));

        CmdResult EmitSymbols()
            => EmitAsmSymbols.run(Wf, Wf.CmdBuilder().EmitAsmSymbols());

        void EmitResources()
        {
            var descriptors = @readonly(Resources.descriptors(Wf.Controller));
            var count = descriptors.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var descriptor = ref skip(descriptors,i);
                Wf.Status(descriptor);
                var target = Wf.Db().RefDataPath(Parts.Tools.Resolved, FS.file(descriptor.Name));
                var data = Resources.data(descriptor);
                var text = Encoded.utf8(data);
                using var writer = target.Writer();
                writer.Write(text);
                Wf.EmittedFile(text.Length, target);
            }
        }

        public unsafe void Run()
        {
            EmitOpCodes();
            EmitPatterns();
            EmitResources();
            EmitSymbols();
        }


        public void Dispose()
        {

        }
    }

    public static partial class XTend { }
}