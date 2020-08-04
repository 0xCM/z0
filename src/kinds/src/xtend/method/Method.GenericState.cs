//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using GS = GenericKind;

    partial class XTend
    {  
        public static GenericKind GenericState(this MethodInfo src, bool effective)
            =>   src.IsOpenGeneric() ? GS.Open 
               : src.IsClosedGeneric() ? GS.Closed 
               : src.IsGenericMethodDefinition ? GS.Definition 
               : 0;
    }
}