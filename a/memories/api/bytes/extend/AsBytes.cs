//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static Memories;
    
    public static partial class XMem
    {
        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this short src)
            => Bytes.from(src);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this ushort src)
            => Bytes.from(src);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this int src)
            => Bytes.from(src);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this uint src)
            => Bytes.from(src);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this long src)
            => Bytes.from(src);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this ulong src)
            => Bytes.from(src);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this double src)
            => Bytes.from(src);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this float src)
            => Bytes.from(src);
    }
}