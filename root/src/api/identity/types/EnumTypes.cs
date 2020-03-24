//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;

    using static Root;

    public static class EnumTypes
    {
        public static TypeIdentity identify(Type t)        
            => EnumIdentity.From(t).AsTypeIdentity();
    }

}