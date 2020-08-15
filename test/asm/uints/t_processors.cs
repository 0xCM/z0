//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Linq;

    using static Konst;
    using static Root;

    public class t_processors : t_asm<t_processors>
    {
        public void process_cpuid()
        {
            var processors = AsmProcessors.Service;
            var src = array(CpuidFeature.AVX2, CpuidFeature.AVX, CpuidFeature.X64);
            var dst = processors.Process(src,Step);
            Trace(dst.Format());
        }

        void Step(Vector128<byte> encoded)
        {
            Trace(encoded.FormatHex());
        }


        // void process_parsed()
        // {
        //     var processor = AsmProcessors.Service.Parsed(Context);
        //     var parts = Api.Resolved.Select(p => p.Id).ToArray();
        //     var result = processor.Process(parts);
        //     var sets = result.Content.ToReadOnlySpan();
        //     var count = result.Count;
        //     for(var i=0; i<count; i++)
        //         Emit(skip(sets,i));                        
        // }

        void Emit(in AsmRecordSet<Mnemonic> src)
        {
            var count = src.Count;
            var records = src.Sequenced.ToReadOnlySpan();
            using var writer = CaseWriter($"{src.Key}");
            writer.WriteLine(AsmRecord.FormatHeader());
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(records,i);
                writer.WriteLine(record.Format());
            }            
        }


        public void blah_blah()
        {
            var records = PartFiles.parsed(Context, PartId.Sys);
            Trace(records.Length);
        }        
    }
}