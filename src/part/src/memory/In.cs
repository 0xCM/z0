//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static System.Runtime.CompilerServices.Unsafe;
    using static memory;

    [ApiHost]
    public readonly struct In
    {
       [MethodImpl(Inline)]
        public static ref T generic<S,T>(in S src)
            => ref As<S,T>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref sbyte int8<T>(in T src)
            => ref As<T,sbyte>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref byte uint8<T>(in T src)
            => ref As<T,byte>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref short int16<T>(in T src)
            => ref As<T,short>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref ushort uint16<T>(in T src)
            => ref As<T,ushort>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref int int32<T>(in T src)
            => ref As<T,int>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref uint uint32<T>(in T src)
            => ref As<T,uint>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref long int64<T>(in T src)
            => ref As<T,long>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref ulong uint64<T>(in T src)
            => ref As<T,ulong>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref float float32<T>(in T src)
            => ref As<T,float>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref double float64<T>(in T src)
            => ref As<T,double>(ref edit(in src));
    }
}