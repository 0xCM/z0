//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Identify)]

namespace Z0.Parts
{        
    public sealed class Identify : Part<Identify>
    {

    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static partial class Identify
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        [MethodImpl(Inline)]
        public static Option<TypeIdentity> ToOption(this TypeIdentity src)
            => src.IsEmpty ? Option.none<TypeIdentity>() : Option.some(src);
    }

    public static partial class XIdentify
    {

        
    }
}
