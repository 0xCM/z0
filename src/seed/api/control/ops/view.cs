//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Control
    {
        /// <summary>
        /// Presents a readonly T-reference as a reference of bit-width w
        /// </summary>
        /// <param name="w">The target width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly byte view<T>(W8 w, in T src)
            => ref view<T,byte>(src);

        /// <summary>
        /// Presents a readonly T-reference as a reference of bit-width w
        /// </summary>
        /// <param name="w">The target width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly ushort view<T>(W16 w, in T src)
            => ref view<T,ushort>(src);

        /// <summary>
        /// Presents a readonly T-reference as a reference of bit-width w
        /// </summary>
        /// <param name="w">The target width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly uint view<T>(W32 w, in T src)
            => ref view<T,uint>(src);

        /// <summary>
        /// Presents a readonly T-reference as a reference of bit-width w
        /// </summary>
        /// <param name="w">The target width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly ulong view<T>(W64 w, in T src)
            => ref view<T,ulong>(src);
    }
}