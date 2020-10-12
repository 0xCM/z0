//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using TC = System.TypeCode;

    readonly struct ClrTypeCodeCache
    {
        static internal readonly ClrTypeCodes Data = new ClrTypeCodes(0);
    }

}