//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public readonly struct RowKey<I,T>
        where T : struct, IRecord<T>
        where I : unmanaged
    {
        public I Value {get;}

        public RowKey(I value)
            => Value = value;

        public static implicit operator RowKey<I,T>(I value)
            => new RowKey<I,T>(value);
    }
}