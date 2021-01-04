//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct EmptyRecord : IRecord<EmptyRecord>
    {

    }

    public readonly struct EmptyRecord<T> : IRecord<EmptyRecord<T>>
    {
        public static implicit operator EmptyRecord(EmptyRecord<T> src)
            => default;

        public static implicit operator EmptyRecord<T>(T src)
            => default;
    }
}