//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public interface ICharBlock<T>
        where T : unmanaged, ICharBlock<T>
    {
        Span<char> Data {get;}

        ref char First => ref first(Data);

        uint Length => (uint)Data.Length;
    }
}