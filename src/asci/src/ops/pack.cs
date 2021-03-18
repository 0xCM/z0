//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Asci
    {
        [MethodImpl(Inline), Op]
        public static ushort pack(AsciCharCode c0, AsciCharCode c1)
            => (ushort)((uint)c0 | ((uint)c1 << 8));

        [MethodImpl(Inline), Op]
        public static ref uint pack(AsciCharCode c0, AsciCharCode c1, AsciCharCode c2, out uint dst)
        {
            dst = (uint)c0 | ((uint)c1 << 8) | (uint)c2 << 16;
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref uint pack(AsciCharCode c0, AsciCharCode c1, AsciCharCode c2, AsciCharCode c3, out uint dst)
        {
            dst = (uint)c0 | ((uint)c1 << 8) | (uint)c2 << 16 | (uint)c3 << 24;
            return ref dst;
        }
    }
}