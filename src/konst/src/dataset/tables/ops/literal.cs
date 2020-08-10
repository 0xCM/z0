//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Table
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Literal<T> literal<T>(string declarer, string name, uint index, T value, LiteralKind kind, bool refinement)
            => new Literal<T>(declarer, name, index, value, kind, refinement);
    }
}