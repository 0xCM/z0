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
        public static uint nand(uint a, uint b)
            => ~ (a & b);

        [MethodImpl(Inline)]
        public static ulong nand(ulong a, ulong b)
            => ~ (a & b);

        [MethodImpl(Inline)]
        public static byte nand(byte a, byte b)
            => (byte)(nand((uint)a,(uint)b));

        [MethodImpl(Inline)]
        public static ushort nand(ushort a, ushort b)
            => (ushort)(nand((uint)a,(uint)b));

    }

}