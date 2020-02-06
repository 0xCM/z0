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
        public static CaptureCompletion Empty => Define(0,0, CaptureTermCode.None, new byte[]{});

        public static CaptureCompletion Define(ulong start, ulong end,  CaptureTermCode cc, byte[] lookback)
            => new CaptureCompletion(start, end, cc,lookback);

        CaptureCompletion(ulong start, ulong end, CaptureTermCode cc, byte[] lookback)
        {   
            this.Start = start;
            this.End = end;
            this.TermCode = cc;
            this.Lookback = lookback;
        }
         
        public readonly ulong Start;

        public readonly ulong End;
        
        public readonly CaptureTermCode TermCode;

        public readonly byte[] Lookback;

        public bool IsEmpty
            => End - Start == 0 && TermCode == CaptureTermCode.None;        
    }
}