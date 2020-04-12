//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using GS = GenericStateKind;

    partial class XTend
    {  
        public static GenericStateKind GenericState(this Type src, bool effective)
            =>   src.IsOpenGeneric(false) ? GS.Open 
               : src.IsClosedGeneric(false) ? GS.Closed 
               : src.IsGenericTypeDefinition ? GS.Definition 
               : 0;

    }
}