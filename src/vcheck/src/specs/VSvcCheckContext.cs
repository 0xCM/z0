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
        ICheckSFCells Decomposer {get;}
    }

    public readonly struct VSvcCheckContext : IVSvcCheckContext
    {
        [MethodImpl(Inline)]
        public static IVSvcCheckContext Create(ICheckSFCells decomposer)
            => new VSvcCheckContext(decomposer);

        [MethodImpl(Inline)]
        VSvcCheckContext(ICheckSFCells decomposer)
        {
            this.Decomposer = decomposer;
        }

        public ICheckSFCells Decomposer {get;}
    }
}