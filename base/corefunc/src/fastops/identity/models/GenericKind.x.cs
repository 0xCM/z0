//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    partial class FastOpX
    {
        public static GenericKind GetGenericKind(this Type src, bool effective)
            =>   src.IsOpenGeneric(false) ? GenericKind.Open 
               : src.IsClosedGeneric(false) ? GenericKind.Closed 
               : src.IsGenericTypeDefinition ? GenericKind.Definition 
               : GenericKind.None;

        public static GenericKind GetGenericKind(this MethodInfo src, bool effective)
            =>   src.IsOpenGeneric() ? GenericKind.Open 
               : src.IsClosedGeneric() ? GenericKind.Closed 
               : src.IsGenericMethodDefinition ? GenericKind.Definition 
               : GenericKind.None;

        [MethodImpl(Inline)]
        public static bool IsSome(this GenericKind kind)
            => kind != GenericKind.None;
    }

}