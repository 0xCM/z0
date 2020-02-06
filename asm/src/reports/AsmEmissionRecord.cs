//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;

    /// <summary>
    /// Describes an assembly code emission
    /// </summary>
    public class AsmEmissionRecord : IRecord<AsmEmissionRecord>
    {    
        public static AsmEmissionRecord Define(MemoryAddress @base, AsmEmissionToken src, AsmEmissionToken? prior = null)
            => new AsmEmissionRecord(@base, src, prior);

        AsmEmissionRecord(MemoryAddress @base, AsmEmissionToken src)
        {
            this.Size = src.Origin.Length;
            this.Uri = src.Uri;
        }

        AsmEmissionRecord(MemoryAddress @base, AsmEmissionToken src, AsmEmissionToken? prior)
            : this(@base,src)
        {
        }

        [ReportField(SizePad)]
        public ByteSize Size {get;}

        [ReportField]
        public OpUri Uri {get;}

        const int OffsetPad = 12;

        const int GapPad  = 8;

        const int SizePad = 8;

        const int OriginPad = 32;

        public string DelimitedText(char delimiter)
        {
            var dst = text();
            // dst.AppendField(Offset.FormatAsmHex(8), OffsetPad);
            // dst.DelimitField(Gap.ToString(), GapPad, delimiter);
            // dst.DelimitField(concat(Origin.Start.FormatAsmHex(), spaced(colon()), Origin.End.FormatAsmHex()), OriginPad, delimiter);
            dst.AppendField(Size.ToString(), SizePad);
            dst.DelimitField(Uri.Format(),delimiter);
            return dst.ToString();
        }

        public IReadOnlyList<string> GetHeaders()
            => Record.ReportHeaders(GetType());        
    }
}