//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class GenericOpSpec : OpSpec
    {            
        public static GenericOpSpec Define(Moniker id, string name, MethodInfo method, NumericKind[] kinds)            
            => new GenericOpSpec(id,name,method, kinds);

        GenericOpSpec(Moniker id, string name, MethodInfo method, NumericKind[] kinds)
            : base(id, name,method)
        {
            this.Kinds = kinds;
        }
    
        public NumericKind[] Kinds {get;}       
    }
}