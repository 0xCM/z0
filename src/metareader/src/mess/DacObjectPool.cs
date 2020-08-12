//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;
    using System.Collections.Generic;

    public sealed class DacObjectPool<T>
        where T : new()
    {
        private readonly Queue<T> _bag = new Queue<T>();
        private readonly Action<DacObjectPool<T>, T> _setOwner;

        public DacObjectPool(Action<DacObjectPool<T>, T> setOwner)
        {
            _setOwner = setOwner;
        }

        public T Rent()
        {
            lock (_bag)
                if (_bag.Count > 0)
                    return _bag.Dequeue();

            T result = new T();
            _setOwner(this, result);
            return result;
        }

        public void Return(T t)
        {
            lock (_bag)
                _bag.Enqueue(t);
        }
    }
}