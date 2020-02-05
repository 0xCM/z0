//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Linq;
    using System.Reflection;

    [Ignore]
    sealed class EmptyDesignator : AssemblyDesignator<EmptyDesignator>
    {

        public EmptyDesignator()
        {

        }

        public override AssemblyId Id => AssemblyId.Empty;

    }
}