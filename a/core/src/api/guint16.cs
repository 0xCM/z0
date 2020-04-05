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

    partial class Core
    {
        [MethodImpl(Inline)]
        public static T generic<T>(ushort src)
            => As.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref ushort src)
            => ref As.generic<T>(ref src);

        [MethodImpl(Inline)]
        public static ushort uint16<T>(T src)
            => As.uint16(src);

        [MethodImpl(Inline)]
        public static ref ushort uint16<T>(ref T src)
            => ref As.uint16(ref src);

        [MethodImpl(Inline)]
        public static ushort? uint16<T>(T? src)
            where T : unmanaged
                => As.uint16(src);
    }
}