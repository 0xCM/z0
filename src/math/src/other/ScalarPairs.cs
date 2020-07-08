//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static Konst;
    using static core;

    [ApiHost]
    public class ScalarPairs
    {       
        /// <summary>
        /// Zero, the the one and only.
        /// </summary>
        public static ConstPair<ulong> Zero 
            => default;

        /// <summary>
        /// One, just.
        /// </summary>
        public static ConstPair<ulong> One 
            => (1,0);

        /// <summary>
        /// One, so many
        /// </summary>
        public static ConstPair<ulong> Ones 
            => (ulong.MaxValue, ulong.MaxValue);

        [MethodImpl(Inline), Op]
        public static ref ulong inc(ref ulong x)
        {
            var o = ConstPair.define(1ul,0ul);
            math.add(x, o.Left, ref x);
            return ref x;
        }

        [MethodImpl(Inline), Op]
        public static void inc(in ulong x, ref ulong y)
        {
            var o = ConstPair.define(1ul,0ul);
            math.add(x, o.Left, ref y);
        }

        [MethodImpl(Inline), Op]
        public static ref ulong dec(ref ulong x)
        {
            var o = ConstPair.define(1ul,0ul);
            math.sub(in x, in o.Left, ref x);
            return ref x;
        }

        [MethodImpl(Inline), Op]
        public static void dec(in ulong x, ref ulong y)
        {
            var o = ConstPair.define(1ul,0ul);
            math.sub(in x, in o.Left, ref y);
        }
   }
}