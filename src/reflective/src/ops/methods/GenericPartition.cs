//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    
    partial class Reflective
    {
    
        public static GenericPartition GenericPartition(this MethodInfo src)
            => src.IsNonGeneric() ? Z0.GenericPartition.NonGeneric : Z0.GenericPartition.Generic;

        public static bool IsMemberOf(this MethodInfo src, GenericPartition g)
            => src.GenericPartition().State == g.State;
    }
}