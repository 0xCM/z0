//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

    /// <summary>
    /// Describes an assembly code emission
    /// </summary>
    public class AsmEmissionRecord : IRecord<AsmEmissionRecord>
    {    
        public static AsmEmissionRecord Define(CaptureToken src)
            => new AsmEmissionRecord(src);

        AsmEmissionRecord(CaptureToken src)
        {
            this.TermCode = src.TermCode;
            this.Size = (int)src.Origin.Length;
            this.Uri = src.Uri;
        }
        
        [ReportField(TermCodePad)]
        public CaptureTermCode TermCode {get;}

        [ReportField(SizePad)]
        public int Size {get;}

        [ReportField]
        public OpUri Uri {get;}

        const int TermCodePad = 20;

        const int SizePad = 8;

        public string DelimitedText(char delimiter)
        {
            var dst = text.factory.Builder();
            dst.AppendField(TermCode.ToString(), TermCodePad);
            dst.DelimitField(Size.ToString(), SizePad, delimiter);
            dst.DelimitField(Uri.Format(),delimiter);
            return dst.ToString();
        }

        public IReadOnlyList<string> GetHeaders()
            => Reports.ReportHeaders(GetType());        
    }
}