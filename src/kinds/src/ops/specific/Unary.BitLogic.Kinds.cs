//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using Id = OpKindId;

    partial class OpKinds
    {
        public readonly struct Not : IUnaryBitlogicKind { public Id KindId { [MethodImpl(Inline)] get => Id.Not;}}
    }
}