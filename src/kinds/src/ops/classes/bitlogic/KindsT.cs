//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class Kinds
    {
       public readonly struct And<T> : IBitLogicKind<And,T> where T : unmanaged { }

        public readonly struct Or<T> : IBitLogicKind<Or,T> where T : unmanaged { }

        public readonly struct Xor<T> : IBitLogicKind<Xor,T> where T : unmanaged { }

        public readonly struct Nand<T> : IBitLogicKind<Nand,T> where T : unmanaged { }

        public readonly struct Nor<T> : IBitLogicKind<Nor,T> where T : unmanaged { }

        public readonly struct Xnor<T> : IBitLogicKind<Xnor,T> where T : unmanaged { }

        public readonly struct Impl<T> : IBitLogicKind<Impl,T> where T : unmanaged { }

        public readonly struct NonImpl<T> : IBitLogicKind<NonImpl,T> where T : unmanaged { }

        public readonly struct CImpl<T> : IBitLogicKind<CImpl,T> where T : unmanaged { }

        public readonly struct CNonImpl<T> : IBitLogicKind<CNonImpl,T> where T : unmanaged { }

        public readonly struct Not<T> : IBitLogicKind<Not,T> where T : unmanaged { }

        public readonly struct Select<T> : IBitLogicKind<Select,T> where T : unmanaged { } 
    }
}