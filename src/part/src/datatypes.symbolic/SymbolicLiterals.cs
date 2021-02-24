//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct SymbolicLiterals
    {
        public static Name identity(Name component, Name type, ushort position, Name name)
            => text.format(RP.SlotDot4, component, type, position, name);
    }
}