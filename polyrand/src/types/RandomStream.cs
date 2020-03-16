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

    using static Root;

    /// <summary>
    /// Captures a random stream along with the generator classification
    /// </summary>
    public readonly struct RandomStream<T> : IRngStream<T>
        where T : struct
    {

        [MethodImpl(Inline)]
        public RandomStream(RngKind rng, IEnumerable<T> src)
        {
            this.src = src;
            this.RngKind = rng;
        }

        readonly IEnumerable<T> src;

        public RngKind RngKind {get;}

        [MethodImpl(Inline)]
        public IEnumerator<T> GetEnumerator()
            => src.GetEnumerator();

        public IEnumerable<T> Next(int count)
            => src.Take(count);

        [MethodImpl(Inline)]
        public T Next()
            => src.First();
            
        IEnumerator IEnumerable.GetEnumerator()
            => src.GetEnumerator();
    }
}