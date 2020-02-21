//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Root;

    public enum NatParameterIndex
    {
        Param0 = 0,
        
        Param1 = 1,

        Param2 = 2,
    }

    /// <summary>
    /// Identifies operations that have one or more natural selectors
    /// </summary>
    public class NatOpAttribute : OpAttribute
    {
        public NatOpAttribute(params ulong[] closures)
        {
            this.Closures = closures;
        }

        public NatOpAttribute(NatParameterIndex parameter, params ulong[] closures)
        {
            this.Closures = closures;
            this.ParameterIndex = parameter;
        }

        public ulong[] Closures{get;}                 

        public NatParameterIndex ParameterIndex {get;}
            = 0;

    }
}