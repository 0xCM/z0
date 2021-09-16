//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct BitFlow
    {
        /// <summary>
        /// Creates the empty vector
        /// </summary>
        /// <param name="n">The length selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static v0<T> v<T>(N0 n)
            where T : unmanaged
                => default;

        /// <summary>
        /// Represents the empty vector
        /// </summary>
        public struct v0<T> : IVector<T>
            where T : unmanaged
        {
            public const ulong Width = 0;

            public ref T this[uint i]
                => throw new Exception("I do not exist");

            public uint N => 0;

            public Span<T> Cells
                => default;

            BitWidth IPrimitive.ContentWidth
                => Width;
        }
   }
}