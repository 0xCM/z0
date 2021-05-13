//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct memory
    {
        /// <summary>
        /// Defines a <see cref='RelativeAddress'/> offset with a specified offset
        /// </summary>
        /// <param name="offset">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static RelativeAddress relative(MemoryAddress @base, ulong offset)
            => new RelativeAddress(@base, offset);

        /// <summary>
        /// Defines a <typeparamname name='T'/> valued <see cref='RelativeAddress{T}'/> relative to a specified offset
        /// </summary>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The offset type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static RelativeAddress<T> relative<T>(MemoryAddress @base, T offset)
            where T : unmanaged
                => new RelativeAddress<T>(@base, offset);
    }
}