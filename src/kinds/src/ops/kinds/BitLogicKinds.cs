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

    partial class Kinds
    {
        public readonly struct And : IBitLogicKind { public Id KindId { [MethodImpl(Inline)] get => Id.And;}}

        public readonly struct Or : IBitLogicKind { public Id KindId { [MethodImpl(Inline)] get => Id.Or;}}

        public readonly struct Xor : IBitLogicKind { public Id KindId { [MethodImpl(Inline)] get => Id.Xor;}}

        public readonly struct Nand : IBitLogicKind { public Id KindId { [MethodImpl(Inline)] get => Id.Nand;}}

        public readonly struct Nor : IBitLogicKind { public Id KindId { [MethodImpl(Inline)] get => Id.Nor;}}

        public readonly struct Xnor : IBitLogicKind { public Id KindId { [MethodImpl(Inline)] get => Id.Xnor;}}

        public readonly struct Impl : IBitLogicKind { public Id KindId { [MethodImpl(Inline)] get => Id.Impl;}}

        public readonly struct NonImpl : IBitLogicKind { public Id KindId { [MethodImpl(Inline)] get => Id.NonImpl;}}

        public readonly struct CImpl : IBitLogicKind { public Id KindId { [MethodImpl(Inline)] get => Id.CImpl;}}

        public readonly struct CNonImpl : IBitLogicKind { public Id KindId { [MethodImpl(Inline)] get => Id.CNonImpl;}}         

        public readonly struct Not : IBitLogicKind { public Id KindId { [MethodImpl(Inline)] get => Id.Not;}}

        public readonly struct Reverse : IBitLogicKind { public Id KindId { [MethodImpl(Inline)] get => Id.Reverse;}}
    }
}