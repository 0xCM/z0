//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static StackContainers;

    public static class StackStoreExtend
    {

        [MethodImpl(Inline)]
        public static Span<byte> AsBytes(this ref Stack128 src)
            => StackStore.bytes(ref src);

        [MethodImpl(Inline)]
        public static Span<byte> AsBytes(this ref Stack256 src)
            => StackStore.bytes(ref src);

        [MethodImpl(Inline)]
        public static Span<byte> AsBytes(this ref Stack512 src)
            => StackStore.bytes(ref src);

        [MethodImpl(Inline)]
        public static Span<byte> AsBytes(this ref Stack1024 src)
            => StackStore.bytes(ref src);

        [MethodImpl(Inline)]
        public static BitString ToBitString(this Stack128 src)
            => src.X1.ToBitString().Concat(src.X0.ToBitString());

        [MethodImpl(Inline)]
        public static Span<char> AsChars(this ref CharStack2 src)
            => StackStore.charspan(ref src);

        [MethodImpl(Inline)]
        public static Span<char> AsChars(this ref CharStack4 src)
            => StackStore.charspan(ref src);

        [MethodImpl(Inline)]
        public static Span<char> AsChars(this ref CharStack8 src)
            => StackStore.charspan(ref src);

        [MethodImpl(Inline)]
        public static Span<char> AsChars(this ref CharStack16 src)
            => StackStore.charspan(ref src);

        [MethodImpl(Inline)]
        public static string ToString(this CharStack2 src)
            => StackStore.charspan(ref src).ToString();

        [MethodImpl(Inline)]
        public static string ToString(this CharStack4 src)
            => StackStore.charspan(ref src).ToString();

        [MethodImpl(Inline)]
        public static string ToString(this CharStack8 src)
            => StackStore.charspan(ref src).ToString();

        [MethodImpl(Inline)]
        public static string ToString(this CharStack16 src)
            => StackStore.charspan(ref src).ToString();
    }

}