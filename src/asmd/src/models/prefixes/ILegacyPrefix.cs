//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public interface ILegacyPrefix<H>
        where H : unmanaged, IHexCode
    {
        LegacyPrefixKind Group {get;}

        H Code => default;
    }
}