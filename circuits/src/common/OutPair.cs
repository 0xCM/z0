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

    public interface IOutput<out T>
        where T : unmanaged
    {

    }

    public readonly struct OutPair<T> : IOutput<T>
        where T : unmanaged
    {
        public readonly T x;

        public readonly T y; 

        [MethodImpl(Inline)]
        public static implicit operator (T x, T y)(OutPair<T> src)
            => (src.x, src.y);

        [MethodImpl(Inline)]
        public static implicit operator OutPair<T> ((T x, T y) src)
            => new OutPair<T>(src.x, src.y);

        [MethodImpl(Inline)]
        public static implicit operator OutPair<T>(InPair<T> src)
            => new OutPair<T>(src.x,src.y);


        [MethodImpl(Inline)]
        public OutPair(T x, T y)
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