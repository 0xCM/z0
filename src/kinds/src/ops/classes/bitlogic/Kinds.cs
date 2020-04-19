//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using K = BitLogicKind;
    using I = IBitLogicKind;

    partial class Kinds
    {
        public readonly struct And : I { public K Kind { [MethodImpl(Inline)] get => K.And;}}

        public readonly struct Or : I { public K Kind { [MethodImpl(Inline)] get => K.Or;}}

        public readonly struct Xor : I { public K Kind { [MethodImpl(Inline)] get => K.Xor;}}

        public readonly struct Nand : I { public K Kind { [MethodImpl(Inline)] get => K.Nand;}}

        public readonly struct Nor : I { public K Kind { [MethodImpl(Inline)] get => K.Nor;}}

        public readonly struct Xnor : I { public K Kind { [MethodImpl(Inline)] get => K.Xnor;}}

        public readonly struct Impl : I { public K Kind { [MethodImpl(Inline)] get => K.Impl;}}

        public readonly struct NonImpl : I { public K Kind { [MethodImpl(Inline)] get => K.NonImpl;}}

        public readonly struct CImpl : I { public K Kind { [MethodImpl(Inline)] get => K.CImpl;}}

        public readonly struct CNonImpl : I { public K Kind { [MethodImpl(Inline)] get => K.CNonImpl;}}         

        public readonly struct Not : I { public K Kind { [MethodImpl(Inline)] get => K.Not;}}

        public readonly struct Select : I { public K Kind { [MethodImpl(Inline)] get => K.Select;}}
    }
}