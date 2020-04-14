//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static Seed;

    public interface IVSvcCheckContext : IContext
    {
        ISVFDecomposer Decomposer {get;}
    }

    public readonly struct VSvcCheckContext : IVSvcCheckContext
    {
        [MethodImpl(Inline)]
        public static IVSvcCheckContext Create(ISVFDecomposer decomposer)
            => new VSvcCheckContext(decomposer);

        [MethodImpl(Inline)]
        VSvcCheckContext(ISVFDecomposer decomposer)
        {
            this.Decomposer = decomposer;
        }

        public ISVFDecomposer Decomposer {get;}
    }
}