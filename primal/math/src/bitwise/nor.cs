//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static zfunc;    
    using static As;

    partial class math
    {

        [MethodImpl(Inline)]
        public static uint nor(uint a, uint b)
            => ~ (a | b);

        [MethodImpl(Inline)]
        public static ulong nor(ulong a, ulong b)
            => ~ (a | b);

        [MethodImpl(Inline)]
        public static byte nor(byte a, byte b)
            => (byte)(nor((uint)a,(uint)b));

        [MethodImpl(Inline)]
        public static ushort nor(ushort a, ushort b)
            => (ushort)(nor((uint)a,(uint)b));
    }
}