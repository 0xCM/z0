//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    /// <summary>
    /// Identifies a runtime symbol
    /// </summary>
    public readonly struct SymToken
    {
        public uint Id {get;}

        [MethodImpl(Inline), Op]
        public SymToken(uint locator)
        {
            Id = locator;
        }
    }
}