//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using K = ArithmeticKind;
    using I = IArithmeticKind;

    partial class Kinds
    {
        public readonly struct Add : I { K I.Kind => K.Add; }

        public readonly struct Sub : I { K I.Kind => K.Sub; }

        public readonly struct Mul : I { K I.Kind => K.Mul; }

        public readonly struct Div : I { K I.Kind => K.Div; }

        public readonly struct Mod : I { K I.Kind => K.Mod; }

        public readonly struct Clamp : I { K I.Kind => K.Clamp; }

        public readonly struct Dot : I { K I.Kind => K.Dot; }

        public readonly struct Inc : I { K I.Kind => K.Inc; }

        public readonly struct Dec : I { K I.Kind => K.Dec; }

        public readonly struct Negate  : I { K I.Kind => K.Negate; }

        public readonly struct Abs : I {  K I.Kind => K.Abs; }

        public readonly struct Square : I {  K I.Kind => K.Square; }

        public readonly struct Sqrt : I {  K I.Kind => K.Sqrt; }
    }
}