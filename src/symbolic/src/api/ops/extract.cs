//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
 
    partial class Symbolic
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> extract(in ResIdentity<byte> id)
            => Symbolic.resource<byte>(id.Location, id.CellCount);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> extract(in ResIdentity<char> id)
            => Symbolic.resource<char>(id.Location, id.CellCount);
    }
}