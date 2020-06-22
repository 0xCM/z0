//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Memories
    {
        [MethodImpl(Inline)]
        public static ref T offset<T>(ref T src, IntPtr offset)
            => ref Unsafe.Add(ref src, offset);
    }
}