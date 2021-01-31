//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct StringTables
    {
        // [Op, Closures(UnsignedInts)]
        // internal static StringTable<T> define<T>(MemoryAddress @base, T[] offsets, T[] lengths)
        //     => new StringTable<T>(@base, offsets, lengths);

        // public static StringTable<T> alloc<T>(MemoryAddress @base, uint count)
        //     => new StringTable<T>(@base, sys.alloc<T>(count), sys.alloc<T>(count));
    }

}