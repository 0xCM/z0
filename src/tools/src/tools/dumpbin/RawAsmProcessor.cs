//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static FileKinds;
    using static z;

    partial struct DumpBin
    {        
        [MethodImpl(Inline)]
        public RawAsmProcessor processor(Asm asm)              
            => new RawAsmProcessor(Wf);

        public struct RawAsmProcessor : IToolProcessor<DumpBin,DumpBinFlag>
        {
            public const string ActorName = nameof(RawAsmProcessor);
            
            public IWfContext Wf {get;}

            public uint LineCount;

            public uint IxCount;
            
            [MethodImpl(Inline)]    
            public RawAsmProcessor(IWfContext wf)
            {
                Wf = wf;
                LineCount = 0;
                IxCount = 0;

                Wf.Created(ActorName);
            }

            const byte Seg0Min = 0;
            
            const byte Seg0Max = 17;

            const byte Seg0Size = Seg0Max - Seg0Min;            

            const byte Seg1Size = Seg1Max - Seg1Min;            

            const byte Seg1Min = 19;
                        
            const byte Seg1Max = 32;
            
            const byte Seg2Min = 33;
                        

            [MethodImpl(Inline)]
            bool Parse(string src, ref RawAsmTable dst)
            {
                var parser = HexNumericParser.Service;
                if(src.Length >= 33)
                {
                    dst = new RawAsmTable(
                        LineCount,
                        parser.Parse<ulong>(text.slice(src,Seg0Min, Seg0Size), 0ul),
                        text.slice(src, Seg1Min, Seg1Size),
                        text.slice(src,Seg2Min));     
                    return true;   
                }            
                return false;
            }
            
            public void Process(IToolFile<DumpBin,DumpBinFlag> src)
            {
                LineCount = 0;
                IxCount = 0;
                Wf.Processing(ExtMap.Asm, src.Path);
                using var reader = src.Path.Reader();
                var dst = new RawAsmTable();
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine().Trim();
                    if(Parse(line, ref dst))
                    {
                        IxCount++;
                    }
                    
                    LineCount++;                    
                }

                Wf.Processed(ExtMap.Asm, src.Path, LineCount);
            }

            public void Dispose()
            {
                Wf.Finished(ActorName);   
            }
        }
    }
}