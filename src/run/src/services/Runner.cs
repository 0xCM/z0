//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using Z0.Asm;

    using static Konst;
    using static z;

    ref struct Runner 
    {
        readonly WfState State;   

        readonly Span<string> Buffer;     

        IWfContext Wf => State.Wf;
        
        CorrelationToken Ct;

        WfActor Actor;

        byte offset;

        [MethodImpl(Inline)]
        public Runner(WfState wf)
        {
            Ct = wf.Ct;
            Actor = Flow.actor(nameof(Runner));
            State = wf;
            Buffer = z.span<string>(256);
            offset = 0;
        }

        void RunCalc()
        {
            CalcDemo.compute();
         
            var pos = offset;
            CalcDemo.run(Buffer, ref offset);
            for(var i=pos; i<offset; i++)
                term.print(Buffer[i]);
           
        }
        

        public void Dispose()
        {

        }

        public void Run()
        {
            using var s0 = new ListFormatPatterns(State.Wf, typeof(FormatPatterns));
            s0.Run();

            var paths = AppBase.paths();
            var files = AppFilePaths.create(paths, PartId.Control);

            Wf.Status(Actor, paths.Logs, Ct);
            Wf.Status(Actor, paths.Archives, Ct);
            Wf.Status(Actor, paths.BuildPub, Ct);
            Wf.Status(Actor, paths.BuildStage, Ct);

            Wf.Status(Actor, files.CaptureRoot, Ct);

            foreach(var file in FileSystem.dir(files.AsmDir))
            {
                Wf.Status(Actor, file, Ct);
            }
            
        

            term.print(TableIndex.AsmTAddressingModRm32);            
        }



    }
}