//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;

    using static Seed;
        
    partial class XTend
    {
        [MethodImpl(Inline)]
        public static OpIdentity Generialize(this GenericOpIdentity src)
            => Identify.Op(src.Identifier);
    }
}