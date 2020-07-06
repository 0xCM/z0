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
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(bool src)
            => As.generic<T>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(char src)
            => As.generic<T>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(sbyte src)
            => As.generic<T>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T generic<T>(ref sbyte src)
            => ref As.generic<T>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static T generic<T>(byte src)
            => As.generic<T>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static ref T generic<T>(ref byte src)
            => ref As.generic<T>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static T generic<T>(short src)
            => As.generic<T>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static ref T generic<T>(ref short src)
            => ref As.generic<T>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static T generic<T>(ushort src)
            => As.generic<T>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static ref T generic<T>(ref ushort src)
            => ref As.generic<T>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(int src)
            => As.generic<T>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T generic<T>(ref int src)
            => ref As.generic<T>(ref src);

        
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(uint src)
            => As.generic<T>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T generic<T>(ref uint src)
            => ref As.generic<T>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static T generic<T>(long src)
            => As.generic<T>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(ulong src)
            => As.generic<T>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T generic<T>(ref ulong src)
            => ref As.generic<T>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(float src)
            => As.generic<T>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(double src)
            => As.generic<T>(src);
    }
}