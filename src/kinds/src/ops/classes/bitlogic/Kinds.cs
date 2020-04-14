//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using Id = BitLogicKind;

    partial class Kinds
    {
        public readonly struct And : IBitLogicKind { public Id Kind { [MethodImpl(Inline)] get => Id.And;}}

        public readonly struct Or : IBitLogicKind { public Id Kind { [MethodImpl(Inline)] get => Id.Or;}}

        public readonly struct Xor : IBitLogicKind { public Id Kind { [MethodImpl(Inline)] get => Id.Xor;}}

        public readonly struct Nand : IBitLogicKind { public Id Kind { [MethodImpl(Inline)] get => Id.Nand;}}

        public readonly struct Nor : IBitLogicKind { public Id Kind { [MethodImpl(Inline)] get => Id.Nor;}}

        public readonly struct Xnor : IBitLogicKind { public Id Kind { [MethodImpl(Inline)] get => Id.Xnor;}}

        public readonly struct Impl : IBitLogicKind { public Id Kind { [MethodImpl(Inline)] get => Id.Impl;}}

        public readonly struct NonImpl : IBitLogicKind { public Id Kind { [MethodImpl(Inline)] get => Id.NonImpl;}}

        public readonly struct CImpl : IBitLogicKind { public Id Kind { [MethodImpl(Inline)] get => Id.CImpl;}}

        public readonly struct CNonImpl : IBitLogicKind { public Id Kind { [MethodImpl(Inline)] get => Id.CNonImpl;}}         

        public readonly struct Not : IBitLogicKind { public Id Kind { [MethodImpl(Inline)] get => Id.Not;}}

        public readonly struct Select : IBitLogicKind { public Id Kind { [MethodImpl(Inline)] get => Id.Select;}}

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

        public readonly struct And<W,T> : IBitLogicKind<And,W,T> where W : unmanaged, ITypeWidth where T : unmanaged { }

        public readonly struct Or<W,T> : IBitLogicKind<Or,W,T> where W : unmanaged, ITypeWidth where T : unmanaged { }

        public readonly struct Xor<W,T> : IBitLogicKind<Xor,W,T> where W : unmanaged, ITypeWidth where T : unmanaged { }

        public readonly struct Nand<W,T> : IBitLogicKind<Nand,W,T> where W : unmanaged, ITypeWidth where T : unmanaged { }

        public readonly struct Nor<W,T> : IBitLogicKind<Nor,W,T> where W : unmanaged, ITypeWidth where T : unmanaged { }
        
        public readonly struct Xnor<W,T> : IBitLogicKind<Xnor,W,T> where W : unmanaged, ITypeWidth where T : unmanaged { }
    }
}