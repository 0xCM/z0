//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public class FastDirectOp : FastOpInfo
    {
        public static FastDirectOp Define(string name, MethodInfo method)
            => new FastDirectOp(name,method);        
        

        public FastDirectOp(string name, MethodInfo method)
            : base(name,method)
        {

        }

        public override bool IsGeneric => false;
    }
}