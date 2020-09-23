//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Kinds
    {
        public readonly struct And<T> : IBitLogicKindHost<And,T> {}

        public readonly struct Nand<T> : IBitLogicKindHost<Nand,T> {}

        public readonly struct Or<T> : IBitLogicKindHost<Or,T> {}

        public readonly struct Nor<T> : IBitLogicKindHost<Nor,T> {}

        public readonly struct Xor<T> : IBitLogicKindHost<Xor,T> {}

        public readonly struct Xnor<T> : IBitLogicKindHost<Xnor,T> {}

        public readonly struct Impl<T> : IBitLogicKindHost<Impl,T> {}

        public readonly struct NonImpl<T> : IBitLogicKindHost<NonImpl,T> {}

        public readonly struct CImpl<T> : IBitLogicKindHost<CImpl,T> {}

        public readonly struct CNonImpl<T> : IBitLogicKindHost<CNonImpl,T> {}

        public readonly struct Not<T> : IBitLogicKindHost<Not,T> {}

        public readonly struct Select<T> : IBitLogicKindHost<Select,T> {}
    }
}