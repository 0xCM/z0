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

    public readonly struct ResourceAccessor
    {
        public readonly ResourceFormat Format;
        
        public readonly MethodInfo Member;

        [MethodImpl(Inline)]
        public ResourceAccessor(MethodInfo member, ResourceFormat format)
        {
            Member = member;
            Format = format;;
        }       
    }
}