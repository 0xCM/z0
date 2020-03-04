//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public sealed class EmptyCatalog : OpCatalog<EmptyCatalog>
    {
        public EmptyCatalog()
            : base(AssemblyId.None)
        {

        }               
    }
}