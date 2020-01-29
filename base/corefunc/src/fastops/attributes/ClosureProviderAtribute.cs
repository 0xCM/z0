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

    using static zfunc;

    public class ClosureProviderAttribute : Attribute
    {
        public ClosureProviderAttribute(Type host)
        {
            this.Host = host;
        }

        public Type Host;
    }    

}