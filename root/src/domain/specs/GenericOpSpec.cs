//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    public class GenericOpSpec : RootedOpSpec
    {            
        public static GenericOpSpec Define(Moniker id, MethodInfo method, NumericKind[] kinds)            
            => new GenericOpSpec(id,method, kinds);

        GenericOpSpec(Moniker id, MethodInfo method, NumericKind[] kinds)
            : base(id, method)
        {
            this.Kinds = kinds;
        }
    
        public NumericKind[] Kinds {get;}       
    }
}