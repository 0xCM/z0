//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    
    using static Konst;

    partial class XTend
    {    
        public static GenericState GenericPartition(this MethodInfo src)
            => src.IsNonGeneric() ? Z0.GenericState.NonGeneric : Z0.GenericState.Generic;

        public static bool IsMemberOf(this MethodInfo src, GenericState g)
            => src.GenericPartition().State == g.State;
    }
}