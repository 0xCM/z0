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
        public static T generic<T>(byte src)
            => AsDeprecated.generic<T>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T generic<T>(ref byte src)
            => ref AsDeprecated.generic<T>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(ushort src)
            => AsDeprecated.generic<T>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T generic<T>(ref ushort src)
            => ref AsDeprecated.generic<T>(ref src);


        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(uint src)
            => AsDeprecated.generic<T>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T generic<T>(ref uint src)
            => ref AsDeprecated.generic<T>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(ulong src)
            => AsDeprecated.generic<T>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T generic<T>(ref ulong src)
            => ref AsDeprecated.generic<T>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(float src)
            => AsDeprecated.generic<T>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(double src)
            => AsDeprecated.generic<T>(src);
    }
}