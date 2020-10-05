//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    public readonly struct DocIndex<D,I,C>
        where D : struct, IArchiveDoc<D,I,C>
    {

        readonly TableSpan<D> Data;
    }

}