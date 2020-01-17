//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;


    [AttributeUsage(AttributeTargets.Parameter)]
    public class ImmAttribute : Attribute
    {


    }

    /// <summary>
    /// Applies to a generic type/method to advertise the primal types over which the type parameter(s) may be closed
    /// </summary>
    public class PrimalClosuresAttribute : Attribute
    {
        public PrimalClosuresAttribute(PrimalKind closures)
        {
            this.Closures = closures;
        }

        public PrimalKind Closures {get;}

    }

}