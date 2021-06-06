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

    using static Part;

    /// <summary>
    /// Captures a random stream along with the generator classification
    /// </summary>
    public readonly struct DataStream<T> : IDataStream<T>
        where T : struct
    {
        readonly IEnumerable<T> Src;

        readonly ulong Classifier;

        [MethodImpl(Inline)]
        public DataStream(IEnumerable<T> src, ulong classifier = default)
        {
            Classifier = default;
            Src = src;
        }

        [MethodImpl(Inline)]
        public IEnumerator<T> GetEnumerator()
            => Src.GetEnumerator();

        [MethodImpl(Inline)]
        public IEnumerable<T> Next(int count)
            => Src.Take(count);

        [MethodImpl(Inline)]
        public T Next()
            => Src.First();

        IEnumerator IEnumerable.GetEnumerator()
            => Src.GetEnumerator();
    }
}