//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    partial class Kinds
    {
        public readonly struct And<T> : IBitLogicKind<And,T> {}

        public readonly struct Nand<T> : IBitLogicKind<Nand,T> {}

        public readonly struct Or<T> : IBitLogicKind<Or,T> {}

        public readonly struct Nor<T> : IBitLogicKind<Nor,T> {}

        public readonly struct Xor<T> : IBitLogicKind<Xor,T> {}
  
        public readonly struct Xnor<T> : IBitLogicKind<Xnor,T> {}

        public readonly struct Impl<T> : IBitLogicKind<Impl,T> {}

        public readonly struct NonImpl<T> : IBitLogicKind<NonImpl,T> {}

        public readonly struct CImpl<T> : IBitLogicKind<CImpl,T> {}

        public readonly struct CNonImpl<T> : IBitLogicKind<CNonImpl,T> {}

        public readonly struct Not<T> : IBitLogicKind<Not,T> {}

        public readonly struct Select<T> : IBitLogicKind<Select,T> {} 

        
    }
}