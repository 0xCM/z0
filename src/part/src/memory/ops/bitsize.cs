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

    partial struct memory
    {
        /// <summary>
        /// Computes the bit-width of a parametrically-identified type
        /// </summary>
        /// <param name="w">The result width selector</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op]
        public static BitSize bitsize<T>()
            => Unsafe.SizeOf<T>()*8;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint bitwidth<T>()
            => (uint)SizeOf<T>() * 8;
    }
}