//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;
    using static Part;

    partial struct memory
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static int int32<T>(T src)
            => As<T,int>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static int? int32<T>(T? src)
            where T : unmanaged
                => As<T?, int?>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref int int32<T>(ref T src)
            => ref As<T,int>(ref src);

        /// <summary>
        /// Projects a sequence of <typeparamref name='T'/> cells onto a sequence of <see cref='int'/> cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<int> int32<T>(Span<T> src)
            where T : struct
                => recover<T,int>(src);

        /// <summary>
        /// Projects a readonly sequence of <typeparamref name='T'/> cells onto a sequence of readonly <see cref='int'/> cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<int> int32<T>(ReadOnlySpan<T> src)
            where T : struct
                => recover<T,int>(src);
    }
}