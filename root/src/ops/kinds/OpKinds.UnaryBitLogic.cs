//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using K = UnaryBitLogicKind;

    partial class OpKinds
    {
        public readonly struct Not : IOpKind<Not,K> { public K Kind { [MethodImpl(Inline)] get => K.Not;}}
    }

}