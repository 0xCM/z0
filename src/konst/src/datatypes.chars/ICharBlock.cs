//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;

    public interface ICharBlock<T> : ITextual
        where T : unmanaged, ICharBlock<T>
    {
        Span<char> Data {get;}

        string ITextual.Format()
            => Data.ToString();
        ref char First
            => ref first(Data);

        int Length
            => Data.Length;

        uint Count
            => (uint)Data.Length;
    }
}