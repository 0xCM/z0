//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;


    using static Konst;
    using static z;

    ref struct Runner 
    {
        FolderPath BuildStage 
            =>  AppPaths.Default.BuildStage;
        
        FolderPath ToolDir
            => FolderPath.Define("J:/assets/tools");
        
        readonly IRunnerContext Context;   

        readonly Span<string> Buffer;     

        byte offset;

        [MethodImpl(Inline)]
        public Runner(IRunnerContext context)
        {
            Context = context;
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
        
        public void Run()
        {
            var tool = DumpBin.init(ToolDir, BuildStage + FolderName.Define(nameof(DumpBin)));
            var disasm  = tool.Output(DumpBin.Flag.Disasm);
            var files = ListedFiles.from(disasm);
            var formatted = ListedFiles.format(files);
            term.print(formatted);
        }
    }
}