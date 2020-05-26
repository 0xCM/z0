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

    public interface ILegacyPrefix
    {
        LegacyPrefixKind Group {get;}
    }

    public interface ILegacyPrefix<H> : ILegacyPrefix
        where H : unmanaged, IHexCode
    {
        H Code => default;
    }
}