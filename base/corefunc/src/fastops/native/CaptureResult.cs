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
        public static CaptureResult Empty => Define(0,0, CaptureTermCode.None, new byte[]{});

        public static CaptureResult Define(ulong start, ulong end,  CaptureTermCode cc, byte[] buffer)
            => new CaptureResult(start, end, cc, buffer);

        CaptureResult(ulong start, ulong end, CaptureTermCode cc, byte[] buffer)
        {   
            this.Start = start;
            this.End = end;
            this.TermCode = cc;
            this.Buffer = buffer;
        }
         
        public readonly ulong Start;

        public readonly ulong End;
        
        public readonly CaptureTermCode TermCode;

        public readonly byte[] Buffer;

        public bool IsEmpty
            => End - Start == 0 && TermCode == CaptureTermCode.None;
    }
}