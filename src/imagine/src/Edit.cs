//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    public readonly struct Edit
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T generic<T>(ref sbyte src)
            => ref As<sbyte,T>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T generic<T>(ref byte src)
            => ref As<byte,T>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T generic<T>(ref short src)
            => ref As<short,T>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T generic<T>(ref ushort src)
            => ref As<ushort,T>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T generic<T>(ref int src)
            => ref As<int,T>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T generic<T>(ref uint src)
            => ref As<uint,T>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T generic<T>(ref ulong src)
            => ref As<ulong,T>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T generic<T>(ref decimal src)
            => ref As<decimal,T>(ref src);
    }
}
