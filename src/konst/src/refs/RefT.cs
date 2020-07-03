//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Ref<T>
    {
        internal readonly Ref R;
        
        /// <summary>
        /// Dereferences the reference
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline)]
        public static Span<T> operator !(Ref<T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator Ref(Ref<T> src)
            => src.R;

        [MethodImpl(Inline)]
        public static implicit operator Ref<T>(Ref src)
            => new Ref<T>(src);

        [MethodImpl(Inline)]
        public Ref(Ref src)
        {
            R = src;
        }

        public Span<T> Data
        {
            [MethodImpl(Inline)]
            get => R.As<T>();
        }
        
        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => R.Bytes;
        }

        [MethodImpl(Inline)]
        public Span<S> As<S>()
            => R.As<S>();
    }
}