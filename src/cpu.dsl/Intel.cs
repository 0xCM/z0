//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Vdsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public interface ICheckContext
    {

    }

    [ApiHost]
    public readonly partial struct Intel
    {
        [ApiHost("intel.algorithms")]
        public readonly partial struct Algs
        {

        }

        [ApiHost("intel.checks")]
        public readonly struct Checks
        {

        }
    }
}

