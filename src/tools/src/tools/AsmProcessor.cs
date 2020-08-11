//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct DumpBin
    {
        [MethodImpl(Inline)]
        public AsmProcessor processor(AsmFileKind asm)              
            => new AsmProcessor(Wf);

        public struct AsmProcessor : IToolProcessor<DumpBin,DumpBinFlag>
        {
            public const string ActorName = nameof(AsmProcessor);
            
            public IWfContext Wf {get;}

            public uint LineCount;
            
            [MethodImpl(Inline)]    
            public AsmProcessor(IWfContext wf)
            {
                Wf = wf;
                LineCount = 0;

                Wf.Created();
            }
            
            public void Process(IToolFile<DumpBin,DumpBinFlag> src)
            {
                Wf.Processing(ExtMap.Asm, src.Path);
                
                using var reader = src.Path.Reader();
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    LineCount++;                    
                }

                Wf.Processed(ExtMap.Asm, src.Path, LineCount);
            }

            public void Dispose()
            {
                Wf.Finished();   
            }
        }
    }
}