//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Ignore]
    sealed class EmptyDesignator : AssemblyDesignator<EmptyDesignator>
    {

        public EmptyDesignator()
        {

        }

        public override AssemblyId Id => AssemblyId.Empty;
    }
}