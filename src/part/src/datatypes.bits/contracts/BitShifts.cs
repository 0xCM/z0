//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using K = BitShiftApiClass;
    using I = IBitShiftApiKey;

    public readonly partial struct BitShifts
    {
        public readonly struct Sll : I { K I.Kind => K.Sll; }

        public readonly struct Sllv : I { K I.Kind => K.Sllv; }

        public readonly struct Srl : I { K I.Kind => K.Srl; }

        public readonly struct Srlv : I { K I.Kind => K.Srlv; }

        public readonly struct Rotl : I { K I.Kind => K.Rotl; }

        public readonly struct Rotr : I { K I.Kind => K.Rotr; }


        //~ Parametric
        //~ -------------------------------------------------------------------

        public readonly struct Sll<T> : IBitShiftApiKey<Sll,T> {}

        public readonly struct Sllv<T> : IBitShiftApiKey<Sllv,T> {}

        public readonly struct Srl<T> : IBitShiftApiKey<Srl,T> {}

        public readonly struct Srlv<T> : IBitShiftApiKey<Srlv,T> {}

        public readonly struct Rotl<T> : IBitShiftApiKey<Rotl,T> {}

        public readonly struct Rotr<T> : IBitShiftApiKey<Rotr,T> {}
    }
}