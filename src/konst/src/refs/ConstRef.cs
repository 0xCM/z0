//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ConstRef<T>
    {
        readonly Ref R;
        
        /// <summary>
        /// Dereferences the reference
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> operator !(ConstRef<T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator Ref(ConstRef<T> src)
            => src.R;

        [MethodImpl(Inline)]
        public static implicit operator ConstRef<T>(Ref src)
            => new ConstRef<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator ConstRef<T>(Ref<T> src)
            => new ConstRef<T>(src.R);

        [MethodImpl(Inline)]
        public ConstRef(Ref src)
        {
            R = src;
        }

        public ReadOnlySpan<T> Data
        {
            [MethodImpl(Inline)]
            get => R.As<T>();
        }
        
        public ReadOnlySpan<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => R.Bytes;
        }

        [MethodImpl(Inline)]
        public Span<S> As<S>()
            => R.As<S>();
    }
}