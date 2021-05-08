//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct CpuVector
    {
        public VectorKind Kind {get;}

        public Identifier Name => Kind.ToString();

        [MethodImpl(Inline)]
        public CpuVector(VectorKind kind)
        {
            Kind = kind;
        }
    }
}