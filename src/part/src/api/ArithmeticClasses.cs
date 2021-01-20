//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = ArithmeticApiClass;
    using I = IArithmeticApiKey;

    public readonly struct ArithmeticClasses
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

        //~ Parametric
        //~ -------------------------------------------------------------------

        public readonly struct Add<T> : IArithmeticKind<Add,T> {}

        public readonly struct Sub<T> : IArithmeticKind<Sub,T> {}

        public readonly struct Mul<T> : IArithmeticKind<Mul,T> {}

        public readonly struct Div<T> : IArithmeticKind<Div,T> {}

        public readonly struct Mod<T> : IArithmeticKind<Mod,T> {}

        public readonly struct Clamp<T> : IArithmeticKind<Clamp,T> {}

        public readonly struct Dot<T> : IArithmeticKind<Dot,T> {}

        public readonly struct Inc<T> : IArithmeticKind<Inc,T> {}

        public readonly struct Dec<T> : IArithmeticKind<Dec,T> {}

        public readonly struct Negate<T> : IArithmeticKind<Negate,T> {}

        public readonly struct Abs<T> : IArithmeticKind<Abs,T> {}

        public readonly struct Square<T> : IArithmeticKind<Square,T> {}

        public readonly struct Sqrt<T> : IArithmeticKind<Sqrt,T> {}
    }
}