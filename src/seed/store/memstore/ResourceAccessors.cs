//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public readonly struct ResourceAccessors
    {
        public readonly Type DeclaringType;

        public readonly ResourceAccessor[] Accessors;

        public ResourceAccessors(Type declaring, ResourceAccessor[] accessors)
        {
            DeclaringType = declaring;
            Accessors = accessors;
        }
    }    
}