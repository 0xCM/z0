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

    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public static partial class Identify
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        [MethodImpl(Inline)]
        public static Option<TypeIdentity> ToOption(this TypeIdentity src)
            => src.IsEmpty ? Option.none<TypeIdentity>() : Option.some(src);

        internal static Exception DuplicateKeys(IEnumerable<object> keys, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new Exception(core.concat($"Duplicate keys were detected {keys.FormatList()}",  caller,file, line));

    }

    public static partial class XIdentify
    {

        
    }
}
