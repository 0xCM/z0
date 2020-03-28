//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static root;

    public readonly struct InPair<T>
        where T : unmanaged
    {
        public readonly T x;

        public readonly T y; 

        [MethodImpl(Inline)]
        public static implicit operator (T x, T y)(InPair<T> src)
            => (src.x, src.y);

        [MethodImpl(Inline)]
        public static implicit operator InPair<T>(OutPair<T> src)
            => new InPair<T>(src.x,src.y);

        [MethodImpl(Inline)]
        public static implicit operator InPair<T> ((T x, T y) src)
            => new InPair<T>(src.x, src.y);

        [MethodImpl(Inline)]
        public InPair(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out T x, out T y)
        {
            x = this.x;
            y = this.y;
        }
    }
}