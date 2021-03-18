//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using K = ApiBitShiftClass;
    using I = IApiBitShiftClass;

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

        public readonly struct Sll<T> : IApiBitShiftClass<Sll,T> {}

        public readonly struct Sllv<T> : IApiBitShiftClass<Sllv,T> {}

        public readonly struct Srl<T> : IApiBitShiftClass<Srl,T> {}

        public readonly struct Srlv<T> : IApiBitShiftClass<Srlv,T> {}

        public readonly struct Rotl<T> : IApiBitShiftClass<Rotl,T> {}

        public readonly struct Rotr<T> : IApiBitShiftClass<Rotr,T> {}
    }
}