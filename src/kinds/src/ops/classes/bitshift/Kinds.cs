//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using Id = BitShiftKind;

    partial class Kinds
    {
        public readonly struct Sll : IBitShiftKind { public Id Kind { [MethodImpl(Inline)] get => Id.Sll; } }

        public readonly struct Srl : IBitShiftKind { public Id Kind { [MethodImpl(Inline)] get => Id.Srl; } }

        public readonly struct Rotl : IBitShiftKind { public Id Kind { [MethodImpl(Inline)] get => Id.Rotl; } }

        public readonly struct Rotr : IBitShiftKind { public Id Kind { [MethodImpl(Inline)] get => Id.Rotr; } }


        public readonly struct Sll<T> : IBitShiftKind<Sll,T> where T : unmanaged {}

        public readonly struct Srl<T> : IBitShiftKind<Srl,T> where T : unmanaged {}

        public readonly struct Rotl<T> : IBitShiftKind<Rotl,T> where T : unmanaged {}

        public readonly struct Rotr<T> : IBitShiftKind<Rotr,T> where T : unmanaged {}

    }
}