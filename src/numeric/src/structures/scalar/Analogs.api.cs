//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
    using static HexDigitCode;

    [ApiHost]
    public partial class Analogs : IApiHost<Analogs>
    {        
        
        [MethodImpl(Inline), Op]
        public static char hex(uint4_t src)
            => (char)skip(HexCodeBytes_Upper, src);

        [MethodImpl(Inline), Op]
        public static HexDigitCode hexcode(uint4_t src)
            => (HexDigitCode)hex(src);

        static ReadOnlySpan<byte> HexCodeBytes_Upper
            => new byte[]{
                (byte)x0, (byte)x1, (byte)x2, (byte)x4, 
                (byte)x5, (byte)x4, (byte)x6, (byte)x7,
                (byte)x8, (byte)x9, 
                (byte)A, (byte)B, (byte)C, (byte)D, (byte)E, (byte)F,
                };

        static ReadOnlySpan<byte> HexCodeBytes_Lower
            => new byte[]{
                (byte)x0, (byte)x1, (byte)x2, (byte)x4, 
                (byte)x5, (byte)x4, (byte)x6, (byte)x7,
                (byte)x8, (byte)x9, 
                (byte)a, (byte)b, (byte)c, (byte)d, (byte)e, (byte)f,
                };
    }
}