//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static Stacked;

    partial class Stacks
    {
        [MethodImpl(Inline)]
        public static Span<char> charspan(ref CharStack2 src)
            => MemoryMarshal.CreateSpan(ref chead(ref src), 2);

        [MethodImpl(Inline)]
        public static Span<char> charspan(ref CharStack4 src)
            => MemoryMarshal.CreateSpan(ref chead(ref src), 4);

        [MethodImpl(Inline)]
        public static Span<char> charspan(ref CharStack8 src)
            => MemoryMarshal.CreateSpan(ref chead(ref src), 8);

        [MethodImpl(Inline)]
        public static Span<char> charspan(ref CharStack16 src)
            => MemoryMarshal.CreateSpan(ref chead(ref src), 16);

        [MethodImpl(Inline)]
        public static Span<char> charspan(ref CharStack32 src)
            => MemoryMarshal.CreateSpan(ref chead(ref src), 32);

        [MethodImpl(Inline)]
        public static Span<char> charspan(ref CharStack64 src)
            => MemoryMarshal.CreateSpan(ref chead(ref src), 64);
    }
}