//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static core;

    public interface ICharBlock<T> : ITextual
        where T : unmanaged, ICharBlock<T>
    {
        Span<char> Data {get;}

        ReadOnlySpan<char> String {get;}

        int Length {get;}

        uint Capacity {get;}

        ref char First
            => ref first(Data);
    }
}