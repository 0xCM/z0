//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface ILegacyPrefix
    {
        LegacyPrefixKind Kind {get;}

        LegacyPrefixGroup Group {get;}
    }
}