//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class math
    {

        [MethodImpl(Inline)]
        public static uint xnor(uint a, uint b)
            => ~ (a ^ b);

        [MethodImpl(Inline)]
        public static ulong xnor(ulong a, ulong b)
            => ~ (a ^ b);

        [MethodImpl(Inline)]
        public static byte xnor(byte a, byte b)
            => (byte)(xnor((uint)a,(uint)b));

        [MethodImpl(Inline)]
        public static ushort xnor(ushort a, ushort b)
            => (ushort)(xnor((uint)a,(uint)b));
    }

}