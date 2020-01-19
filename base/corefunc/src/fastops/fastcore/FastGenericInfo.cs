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
        public FastGenericInfo(string name, MethodInfo method, IEnumerable<PrimalKind> kinds)
            : base(name,method)
        {
            this.Kinds= kinds.ToArray();
        }
    
        public PrimalKind[] Kinds {get;}

        public override bool IsGeneric => true;        
    }
}