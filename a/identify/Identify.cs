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
    using System.Collections.Generic;

    using static Core;

    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public static partial class Identify
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        [MethodImpl(Inline)]
        public static Option<TypeIdentity> ToOption(this TypeIdentity src)
            => src.IsEmpty ? none<TypeIdentity>() : some(src);


    }

    public static partial class XIdentify
    {

        
    }


    public static partial class XTend
    {

    }
}
