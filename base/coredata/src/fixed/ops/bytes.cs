//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    partial class Fixed
    {
        /// <summary>
        /// Presents fixed storage as a bytespan
        /// </summary>
        /// <param name="src">The storage block</param>
        [MethodImpl(Inline)]
        public static Span<byte> bytes(in Fixed128 src)
            => readbytes(src);

        /// <summary>
        /// Presents fixed storage as a bytespan
        /// </summary>
        /// <param name="src">The storage block</param>
        [MethodImpl(Inline)]
        public static Span<byte> bytes(in Fixed256 src)
            => readbytes(src);

        /// <summary>
        /// Presents fixed storage as a bytespan
        /// </summary>
        /// <param name="src">The storage block</param>
        [MethodImpl(Inline)]
        public static Span<byte> bytes(in Fixed512 src)
            => readbytes(src);

        /// <summary>
        /// Presents fixed storage as a bytespan
        /// </summary>
        /// <param name="src">The storage block</param>
        [MethodImpl(Inline)]
        public static Span<byte> bytes(in Fixed1024 src)
            => readbytes(src);

        /// <summary>
        /// Presents fixed storage as a bytespan
        /// </summary>
        /// <param name="src">The storage block</param>
        [MethodImpl(Inline)]
        public static Span<byte> bytes(in Fixed2048 src)
            => readbytes(src);

        /// <summary>
        /// Presents fixed storage as a bytespan
        /// </summary>
        /// <param name="src">The storage block</param>
        [MethodImpl(Inline)]
        public static Span<byte> bytes(in Fixed4096 src)
            => readbytes(src);
    }
}