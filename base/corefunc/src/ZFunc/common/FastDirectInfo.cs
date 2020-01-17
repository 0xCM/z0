//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public class FastDirectInfo : FastOpInfo
    {
        public static FastDirectInfo Define(string name, MethodInfo method)
            => new FastDirectInfo(name,method);        
        

        public FastDirectInfo(string name, MethodInfo method)
            : base(name,method)
        {

        }

        public override bool IsGeneric => false;
    }
}