//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = BitShiftOpId;
    using I = IBitShiftKind;

    partial class Kinds
    {
        public readonly struct Sll : I { K I.Kind => K.Sll; }

        public readonly struct Sllv : I { K I.Kind => K.Sllv; }

        public readonly struct Srl : I { K I.Kind => K.Srl; }

        public readonly struct Srlv : I { K I.Kind => K.Srlv; }

        public readonly struct Rotl : I { K I.Kind => K.Rotl; }

        public readonly struct Rotr : I { K I.Kind => K.Rotr; }


        //~ Parametric
        //~ -------------------------------------------------------------------

        public readonly struct Sll<T> : IBitShiftKind<Sll,T> {}

        public readonly struct Sllv<T> : IBitShiftKind<Sllv,T> {}

        public readonly struct Srl<T> : IBitShiftKind<Srl,T> {}

        public readonly struct Srlv<T> : IBitShiftKind<Srlv,T> {}

        public readonly struct Rotl<T> : IBitShiftKind<Rotl,T> {}

        public readonly struct Rotr<T> : IBitShiftKind<Rotr,T> {}
    }
}