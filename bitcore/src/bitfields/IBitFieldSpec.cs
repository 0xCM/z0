//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    using static As;

    public interface IBitFieldSpec<E>
        where E : unmanaged, Enum
    {
        byte FieldCount {get;}

        ref readonly BitFieldSegment this[byte index] {get;}

        ReadOnlySpan<BitFieldSegment> Segments {get;}
    }
}