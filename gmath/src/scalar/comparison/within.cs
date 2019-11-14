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
    

    partial class math
    {
        [MethodImpl(Inline)]
        public static bit within(sbyte a, sbyte b, sbyte epsilon)
            => dist(a,b) <= (uint)epsilon;

        [MethodImpl(Inline)]
        public static bit within(byte a, byte b, byte epsilon)
            => dist(a,b) <= epsilon;

        [MethodImpl(Inline)]
        public static bit within(short a, short b, short epsilon)
            => dist(a,b) <= (uint)epsilon;

        [MethodImpl(Inline)]
        public static bit within(ushort a, ushort b, ushort epsilon)
            => dist(a,b) <= epsilon;

        [MethodImpl(Inline)]
        public static bit within(int a, int b, int epsilon)
            => dist(a,b) <= (uint)epsilon;

        [MethodImpl(Inline)]
        public static bit within(uint a, uint b, uint epsilon)
            => dist(a,b) <= epsilon;

        [MethodImpl(Inline)]
        public static bit within(long a, long b, long epsilon)
            => dist(a,b) <= (ulong)epsilon;

        [MethodImpl(Inline)]
        public static bit within(ulong a, ulong b, ulong epsilon)
            => dist(a,b) <= epsilon;
    }

}