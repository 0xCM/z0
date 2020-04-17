//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static LocatedBits WithIdentity(this LocatedBits src, OpIdentity id)
            => LocatedBits.Define(id, src.Encoded);

        [MethodImpl(Inline)]
        public static int ParameterCount(this LocatedBits src)
            => src.Id.TextComponents.Count() - 1;
                    
        public static IEnumerable<LocatedBits> HasParameterCount(this IEnumerable<LocatedBits> src, int count)
            => from code in src
                where code.ParameterCount() == count
                select code;
    }
}