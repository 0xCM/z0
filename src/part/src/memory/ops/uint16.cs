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
        /// <summary>
        /// Presents a parametric source to a <see cref='ushort'/>
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ushort uint16<T>(T src)
            => As<T,ushort>(ref src);

        /// <summary>
        /// Presents a parametric source reference to a <see cref='ushort'/>
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ushort uint16<T>(ref T src)
            => ref As<T,ushort>(ref src);

        /// <summary>
        /// Converts a nullable parametric source to a nullable <see cref='ushort'/>
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ushort? uint16<T>(T? src)
            where T : unmanaged
                => As<T?, ushort?>(ref src);

        /// <summary>
        /// Projects a sequence of <typeparamref name='T'/> cells onto a sequence of <see cref='ushort'/> cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<ushort> uint16<T>(Span<T> src)
            where T : struct
                => recover<T,ushort>(src);

        /// <summary>
        /// Projects a readonly sequence of <typeparamref name='T'/> cells onto a readonly sequence of <see cref='ushort'/> cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<ushort> uint16<T>(ReadOnlySpan<T> src)
            where T : struct
                => recover<T,ushort>(src);
    }
}