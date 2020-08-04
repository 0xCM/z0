//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using GS = GenericKind;

    partial class XTend
    {  
        public static GenericKind GenericState(this Type src, bool effective)
            =>   src.IsOpenGeneric(false) ? GS.Open 
               : src.IsClosedGeneric(false) ? GS.Closed 
               : src.IsGenericTypeDefinition ? GS.Definition 
               : 0;
    }
}