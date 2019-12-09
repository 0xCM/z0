//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using static zfunc;

    partial class BitGrid
    {                
        [MethodImpl(Inline)]
        public static BitGrid16<T> define<T>(N16 w, int rows, int cols, ushort data)
            where T : unmanaged
                => new BitGrid16<T>(data,rows,cols);

        [MethodImpl(Inline)]
        public static BitGrid32<T> define<T>(N32 w, int rows, int cols, uint data)
            where T : unmanaged
                => new BitGrid32<T>(data,rows,cols);

        [MethodImpl(Inline)]
        public static BitGrid64<T> define<T>(N64 w, int rows, int cols, ulong data)
            where T : unmanaged
                => new BitGrid64<T>(data,rows,cols);

    }

}