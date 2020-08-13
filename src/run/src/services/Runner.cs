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


        void Status<T>(T message)
        {
            Wf.Status(Actor, message, Ct);

        }
        void ReadRes()
        {
            var map = MemoryFile.resbundle();
            var @base = map.BaseAddress;
            var sig = map.Read(@base, 2).AsUInt16();
            var magic = Z0.Image.PeLiterals.Magical;
            if(magic== sig[0])
                Status("Magic lives!");

            //var info = map.FileInfo;
            // Status(info.Length);
            // Status(@base);
            // Status(data.Length);
            // Status(new BinaryCode(data.ToArray()));
        }


        void ListCaptureFiles()
        {
            var paths = AppBase.paths();
            var files = AppFilePaths.create(paths, PartId.Control);

            Status(paths.Logs);
            Status(paths.Archives);
            Status(paths.BuildPub);
            Status(paths.BuildStage);

            Status(files.CaptureRoot);

            foreach(var file in FileSystem.dir(files.AsmDir))
            {
                Wf.Status(Actor, file, Ct);
            }

        }
        public void Run()
        {
            using var s0 = new ListFormatPatterns(State.Wf, typeof(FormatPatterns));
            s0.Run();

            ReadRes();
        

            term.print(TableIndex.AsmTAddressingModRm32);            
        }



    }
}