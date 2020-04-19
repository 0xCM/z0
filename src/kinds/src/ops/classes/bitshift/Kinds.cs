//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using K = BitShiftKind;
    using I = IBitShiftKind;

    partial class Kinds
    {
        public readonly struct Sll : I { public K Kind { [MethodImpl(Inline)] get => K.Sll; } }

        public readonly struct Sllv : I { public K Kind { [MethodImpl(Inline)] get => K.Sllv; } }

        public readonly struct Srl : I { public K Kind { [MethodImpl(Inline)] get => K.Srl; } }

        public readonly struct Srlv : I { public K Kind { [MethodImpl(Inline)] get => K.Srlv; } }

        public readonly struct Rotl : I { public K Kind { [MethodImpl(Inline)] get => K.Rotl; } }

        public readonly struct Rotr : I { public K Kind { [MethodImpl(Inline)] get => K.Rotr; } }
    }
}