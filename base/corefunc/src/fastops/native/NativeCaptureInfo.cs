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
    public readonly struct NativeCaptureInfo
    {
        public static NativeCaptureInfo Empty => Define(0,0, CaptureTermCode.None, new byte[]{});

        public static NativeCaptureInfo Define(ulong start, ulong end,  CaptureTermCode cc, byte[] buffer)
            => new NativeCaptureInfo(start, end, cc);

        NativeCaptureInfo(ulong start, ulong end, CaptureTermCode cc)
        {   
            this.Start = start;
            this.End = end;
            this.TermCode = cc;
        }
         
        public readonly ulong Start;

        public readonly ulong End;
        
        public readonly CaptureTermCode TermCode;

        //public readonly byte[] Buffer;

        public bool IsEmpty
            => End - Start == 0 && TermCode == CaptureTermCode.None;
    }
}