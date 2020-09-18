//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using K = OperatorClassKind;

    partial class Kinds
    {
        public readonly struct EmitterOpClass : IOperatorClass<EmitterOpClass,K>
        {
            public K Kind
                => K.Emitter;

            [MethodImpl(Inline)]
            public static implicit operator OperatorClass(EmitterOpClass src)
                => src.Generalized;

            public OperatorClass Generalized
                => new OperatorClass(Kind);
        }

        public readonly struct UnaryOpClass : IOperatorClass<UnaryOpClass,K>
        {
            [MethodImpl(Inline)]
            public static implicit operator OperatorClass(UnaryOpClass src)
                => src.Generalized;

            public K Kind
                => K.UnaryOp;

            public OperatorClass Generalized
                => new OperatorClass(Kind);
        }

        // public readonly struct BinaryOpClass : IOperatorClass<BinaryOpClass,K>
        // {
        //     public static implicit operator OperatorClass(BinaryOpClass src)
        //         => src.Generalized;

        //     public K Kind
        //         => K.BinaryOp;

        //     public OperatorClass Generalized
        //         => new OperatorClass(Kind);
        // }

        public readonly struct TernaryOpClass : IOperatorClass<TernaryOpClass,K>
        {
            public static implicit operator OperatorClass(TernaryOpClass src)
                => src.Generalized;

            public K Kind
                => K.TernaryOp;

            public OperatorClass Generalized
                => new OperatorClass(Kind);
        }
    }
}