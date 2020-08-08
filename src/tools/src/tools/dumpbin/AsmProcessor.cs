//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct DumpBin
    {
        [MethodImpl(Inline)]
        public AsmProcessor processor(AsmFileKind asm)              
            => new AsmProcessor(Wf);

        public struct AsmProcessor : IToolProcessor<DumpBin,Flag>
        {
            public const string ActorName = nameof(AsmProcessor);
            
            readonly WfContext Wf;

            public uint LineCount;
            
            [MethodImpl(Inline)]    
            public AsmProcessor(WfContext wf)
            {
                Wf = wf;
                LineCount = 0;

                Wf.Created();
            }
            
            public void Process(IToolFile<DumpBin,Flag> src)
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