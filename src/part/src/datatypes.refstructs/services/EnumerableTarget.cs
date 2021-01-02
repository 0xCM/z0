//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Collections;

    using static Part;
    using static memory;

    public interface IEnumerableTarget<T>
    {

    }

    public struct EnumerableTarget<T> : IEnumerable<T>, IEnumerator<T>, IEnumerableTarget<T>
    {
        IteratorRelay<T> Relay;

        public T Current => Relay.Current;

        object IEnumerator.Current
            => Current;

        [MethodImpl(Inline)]
        public EnumerableTarget(IteratorRelay<T> relay)
        {
            Relay = relay;
        }

        [MethodImpl(Inline)]
        public bool MoveNext()
        {
            return true;
        }

        public void Reset()
        {

        }

        public void Dispose()
        {

        }

        public IEnumerator<T> GetEnumerator()
            => this;

        IEnumerator IEnumerable.GetEnumerator()
            => this;
    }
}