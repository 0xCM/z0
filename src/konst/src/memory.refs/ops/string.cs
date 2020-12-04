//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct MemRefs
    {
        /// <summary>
        /// Creates a <see cref='StringRef'/> from a specified <see cref='string'/> and optional user data
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="user">The user data, if any</param>
        [MethodImpl(Inline), Op]
        public static unsafe StringRef @string(string src, uint user = 0)
            => new StringRef((ulong)pchar2(src), (uint)src.Length, user);

        /// <summary>
        /// Creates a <see cref='StringRef'/> from a specified <see cref='MemoryAddress'/> and memory size
        /// </summary>
        /// <param name="address">The reference address</param>
        /// <param name="length">The size, in bytes, of the segment</param>
        [MethodImpl(Inline)]
        public static StringRef @string(MemoryAddress address, uint length)
            => new StringRef(address, length);

        /// <summary>
        /// Creates a <see cref='StringRef'/> from a specified <see cref='SegRef'/>
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static StringRef @string(SegRef src)
            => new StringRef(vparts(N128.N, src.Address, (ulong)src.DataSize));

        /// <summary>
        /// Creates a <see cref='StringRef'/> from a specified <see cref='Ref'/>
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static StringRef @string(Ref src)
            => new StringRef(vparts(N128.N, src.Address, (ulong)src.DataSize));
    }
}