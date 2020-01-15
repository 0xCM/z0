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

    public class GenericOpInfo : FastOpInfo
    {
        public static GenericOpInfo Define(string name, MethodInfo method, IEnumerable<Moniker> reifications)
            => new GenericOpInfo(name, method,reifications);

        public GenericOpInfo(string name, MethodInfo method, IEnumerable<Moniker> reifications)
            : base(name,method)
        {
            this.Reifications = reifications;
        }

        public IEnumerable<Moniker> Reifications {get;}

        public override bool IsGeneric => true;        
    }
}