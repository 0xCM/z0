//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static z;

    partial struct MemRefs
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        internal static uint length<T>(Vector128<ulong> src)
        {
            unpack(vcell(src,1), out var size, out var _);
            return size/scale<T>();
        }

        [MethodImpl(Inline), Op]
        static ulong lo(StringRef src)
            => z.vcell(src.Data, 0);

        [MethodImpl(Inline), Op]
        static ulong hi(StringRef src)
            => z.vcell(src.Data, 1);

        /// <summary>
        /// Computes the number of characters represented by a <see cref='StringRef'/>
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static uint length(StringRef src)
            => (uint)(hi(src)/scale<char>());
    }
}