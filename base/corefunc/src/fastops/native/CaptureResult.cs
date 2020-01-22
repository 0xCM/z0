//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public readonly struct CaptureResult
    {
        public static CaptureResult Empty => Define(0,0,CaptureTermReason.None, new byte[]{});

        public static CaptureResult Define(ulong start, ulong end,  CaptureTermReason reason, byte[] buffer)
            => new CaptureResult(start, end, reason, buffer);

        CaptureResult(ulong start, ulong end, CaptureTermReason reason, byte[] buffer)
        {   
            this.Start = start;
            this.End = end;
            this.TermReason = reason;
            this.Buffer = buffer;
        }
         
        public readonly ulong Start;

        public readonly ulong End;
        
        public readonly CaptureTermReason TermReason;

        public readonly byte[] Buffer;

        public bool IsEmpty
            => End - Start == 0 && TermReason == CaptureTermReason.None;
    }
}