//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using K = ApiOperatorClass;

    partial class Kinds
    {
        public readonly struct EmitterOpClass<T> : IOperatorClass<EmitterOpClass<T>,K,T>
        {
            [MethodImpl(Inline)]
            public static implicit operator OperatorClass<T>(EmitterOpClass<T> src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public static implicit operator EmitterOpClass(EmitterOpClass<T> src)
                => src.NonGeneric;

            public K Kind
                => K.Emitter;

            public OperatorClass<T> Generalized
                => new OperatorClass<T>(Kind);

            public EmitterOpClass NonGeneric
                => default;
        }

        public readonly struct UnaryOpClass<T> : IOperatorClass<UnaryOpClass<T>, K,T>
        {
            [MethodImpl(Inline)]
            public static implicit operator OperatorClass<T>(UnaryOpClass<T> src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public static implicit operator UnaryOpClass(UnaryOpClass<T> src)
                => src.NonGeneric;

            public K Kind
                => K.UnaryOp;

            public OperatorClass<T> Generalized
                => new OperatorClass<T>(Kind);

            public UnaryOpClass NonGeneric
                => default;
        }


        public readonly struct TernaryOpClass<T> : IOperatorClass<TernaryOpClass<T>,K,T>
        {
            public K Kind => K.TernaryOp;

            [MethodImpl(Inline)]
            public static implicit operator OperatorClass<T>(TernaryOpClass<T> src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public static implicit operator TernaryOpClass(TernaryOpClass<T> src)
                => src.NonGeneric;

            public OperatorClass<T> Generalized
                => new OperatorClass<T>(Kind);

            public TernaryOpClass NonGeneric
                => default;
        }

        public readonly struct ShiftOpClass<T> : IOperatorClass<ShiftOpClass<T>,K,T>
        {
            [MethodImpl(Inline)]
            public static implicit operator OperatorClass<T>(ShiftOpClass<T> src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public static implicit operator ShiftOpClass(ShiftOpClass<T> src)
                => src.NonGeneric;

            public K Kind
                => K.ShiftOp;

            public OperatorClass<T> Generalized
                => new OperatorClass<T>(Kind);

            public ShiftOpClass NonGeneric
                => default;
        }
    }
}