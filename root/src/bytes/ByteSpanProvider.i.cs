//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Root;

    public interface IByteSpanProvider
    {
        ReadOnlySpan<byte> Bytes {get;}
    }

    public interface IByteSpanProvider<T> : IByteSpanProvider
        where T : IByteSpanProvider<T>
    {

    }

}