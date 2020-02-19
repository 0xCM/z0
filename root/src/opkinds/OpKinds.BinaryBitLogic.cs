//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static RootShare;

    using K = BinaryBitLogicKind;

    partial class OpKinds
    {
        public readonly struct And : IOpKind<And,K> { public K Kind { [MethodImpl(Inline)] get => K.And;}}

        public readonly struct Or : IOpKind<Or,K> { public K Kind { [MethodImpl(Inline)] get => K.Or;}}

        public readonly struct Xor : IOpKind<Xor,K> { public K Kind { [MethodImpl(Inline)] get => K.Xor;}}

        public readonly struct Nand : IOpKind<Nand,K> { public K Kind { [MethodImpl(Inline)] get => K.Nand;}}

        public readonly struct Nor : IOpKind<Nor,K> { public K Kind { [MethodImpl(Inline)] get => K.Nor;}}

        public readonly struct Xnor : IOpKind<Xnor,K> { public K Kind { [MethodImpl(Inline)] get => K.Xnor;}}

        public readonly struct Impl : IOpKind<Impl,K> { public K Kind { [MethodImpl(Inline)] get => K.Impl;}}

        public readonly struct NonImpl : IOpKind<NonImpl,K> { public K Kind { [MethodImpl(Inline)] get => K.NonImpl;}}

        public readonly struct CImpl : IOpKind<CImpl,K> { public K Kind { [MethodImpl(Inline)] get => K.CImpl;}}

        public readonly struct CNonImpl : IOpKind<CNonImpl,K> { public K Kind { [MethodImpl(Inline)] get => K.CNonImpl;}}
    }
}