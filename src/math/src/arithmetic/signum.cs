//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    partial class math
    {
        [MethodImpl(Inline), Op]
        public static sbyte sign(sbyte src)
            => mul(core.@sbyte(src < 0),(sbyte)-1);
        
        [MethodImpl(Inline), Op]
        public static SignKind signum(sbyte src)
            => signum((int)src);
            
        [MethodImpl(Inline), Op]
        public static SignKind signum(byte src)
            => (SignKind)core.@byte(src != 0);

        [MethodImpl(Inline), Op]
        public static SignKind signum(short src)
            => signum((int)src);

        [MethodImpl(Inline), Op]
        public static SignKind signum(ushort src)
            => (SignKind)core.@byte(src != 0);

        [MethodImpl(Inline), Op]
        public static SignKind signum(int src)
            => (SignKind)((src >> 31) | (int)(negate((uint)src) >> 31)); 

        [MethodImpl(Inline), Op]
        public static SignKind signum(uint src)
            => (SignKind)core.@byte(src != 0);

        [MethodImpl(Inline), Op]
        public static SignKind signum(long src)
            => (SignKind)((src >> 63) | (long)(negate((ulong)src) >> 63)); 

        [MethodImpl(Inline), Op]
        public static SignKind signum(ulong src)
            => (SignKind)core.@byte(src != 0);
    }
}