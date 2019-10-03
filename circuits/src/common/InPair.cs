//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.IO;
    using System.IO.Pipes;
    using System.Buffers;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public interface IInput<in T>
        where T : unmanaged
    {

    }

    public readonly struct InPair<T> : IInput<T>
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