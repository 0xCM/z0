//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    /// <summary>
    /// Captures a random stream along with the generator classification
    /// </summary>
    readonly struct RngStream<T> : IRngStream<T>
        where T : struct
    {
        readonly IEnumerable<T> Src;

        public RngKind RngKind {get;}

        [MethodImpl(Inline)]
        public RngStream(RngKind kind, IEnumerable<T> src)
        {
            Src = src;
            RngKind = kind;
        }

        [MethodImpl(Inline)]
        public IEnumerator<T> GetEnumerator()
            => Src.GetEnumerator();

        public IEnumerable<T> Next(int count)
            => Src.Take(count);

        [MethodImpl(Inline)]
        public T Next()
            => Src.First();
            
        IEnumerator IEnumerable.GetEnumerator()
            => Src.GetEnumerator();
    }
}
