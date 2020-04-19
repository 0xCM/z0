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
        public readonly struct Sll<T> : IBitShiftKind<Sll,T> where T : unmanaged {}

        public readonly struct Sllv<T> : IBitShiftKind<Sllv,T> where T : unmanaged {}

        public readonly struct Srl<T> : IBitShiftKind<Srl,T> where T : unmanaged {}

        public readonly struct Srlv<T> : IBitShiftKind<Srlv,T> where T : unmanaged {}

        public readonly struct Rotl<T> : IBitShiftKind<Rotl,T> where T : unmanaged {}

        public readonly struct Rotr<T> : IBitShiftKind<Rotr,T> where T : unmanaged {}
    }
}