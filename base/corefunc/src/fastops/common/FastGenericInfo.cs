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

    using static zfunc;

    public class FastGenericInfo : FastOpInfo
    {
        public static FastGenericInfo Define(string name, MethodInfo method, IEnumerable<PrimalKind> kinds)
            => new FastGenericInfo(name, method,kinds);

        public FastGenericInfo(string name, MethodInfo method, IEnumerable<PrimalKind> kinds)
            : base(name,method)
        {
            this.Kinds= kinds.ToArray();
        }
    
        public PrimalKind[] Kinds {get;}

        // public IEnumerable<MethodInfo> Reifications
        //     =>  Kinds.Select(k => Method.MakeGenericMethod(k.ToPrimalType()));
        public override bool IsGeneric => true;        
    }
}