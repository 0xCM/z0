//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    /// <summary>
    /// Describes the outcome of a native capture operation
    /// </summary>
    public readonly struct CaptureCompletion
    {
        public static CaptureCompletion Empty => Define(0,0, CaptureTermCode.None);

        public static CaptureCompletion Define(ulong start, ulong end, CaptureTermCode cc)
            => new CaptureCompletion(start, end, cc);

        CaptureCompletion(ulong start, ulong end, CaptureTermCode cc)
        {   
            this.Start = start;
            this.End = end;
            this.ByteCount = (int)(end - start);
            this.TermCode = cc;
        }
         
        public readonly ulong Start;

        public readonly ulong End;

        public readonly int ByteCount;

        public readonly CaptureTermCode TermCode;

        public MemoryRange Range
            => (Start,End);


        public bool IsEmpty
            => End - Start == 0 && TermCode == CaptureTermCode.None;        
    }
}