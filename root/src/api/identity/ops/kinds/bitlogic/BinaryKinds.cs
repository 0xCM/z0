//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    using Id = OpKindId;

    public interface IBinaryBitlogicKind : IBitLogicKind, IOpKind<BinaryBitLogicOpKind>
    {
        BinaryBitLogicOpKind IKind<BinaryBitLogicOpKind>.Class 
            => Enums.parse<BinaryBitLogicOpKind>(KindId.ToString()).ValueOrDefault();
    }    

    partial class OpKinds
    {
        public readonly struct And : IBinaryBitlogicKind { public Id KindId { [MethodImpl(Inline)] get => Id.And;}}

        public readonly struct Or : IBinaryBitlogicKind { public Id KindId { [MethodImpl(Inline)] get => Id.Or;}}

        public readonly struct Xor : IBinaryBitlogicKind { public Id KindId { [MethodImpl(Inline)] get => Id.Xor;}}

        public readonly struct Nand : IBinaryBitlogicKind { public Id KindId { [MethodImpl(Inline)] get => Id.Nand;}}

        public readonly struct Nor : IBinaryBitlogicKind { public Id KindId { [MethodImpl(Inline)] get => Id.Nor;}}

        public readonly struct Xnor : IBinaryBitlogicKind { public Id KindId { [MethodImpl(Inline)] get => Id.Xnor;}}

        public readonly struct Impl : IBinaryBitlogicKind { public Id KindId { [MethodImpl(Inline)] get => Id.Impl;}}

        public readonly struct NonImpl : IBinaryBitlogicKind { public Id KindId { [MethodImpl(Inline)] get => Id.NonImpl;}}

        public readonly struct CImpl : IBinaryBitlogicKind { public Id KindId { [MethodImpl(Inline)] get => Id.CImpl;}}

        public readonly struct CNonImpl : IBinaryBitlogicKind { public Id KindId { [MethodImpl(Inline)] get => Id.CNonImpl;}}
    }
}