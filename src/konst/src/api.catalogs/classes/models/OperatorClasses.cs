//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct EmitterOpClass : IOperatorClassHost<EmitterOpClass,ApiOperatorClass>
    {
        public ApiOperatorClass Kind
            => ApiOperatorClass.Emitter;

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass(EmitterOpClass src)
            => src.Classifier;

        public OperatorClass Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass(Kind);
        }
    }

    public readonly struct UnaryOpClass : IOperatorClassHost<UnaryOpClass,ApiOperatorClass>
    {
        [MethodImpl(Inline)]
        public static implicit operator OperatorClass(UnaryOpClass src)
            => src.Classifier;

        public ApiOperatorClass Kind
            => ApiOperatorClass.UnaryOp;

        public OperatorClass Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass(Kind);
        }
    }

    public readonly struct TernaryOpClass : IOperatorClassHost<TernaryOpClass,ApiOperatorClass>
    {
        public static implicit operator OperatorClass(TernaryOpClass src)
            => src.Classifier;

        public ApiOperatorClass Kind
            => ApiOperatorClass.TernaryOp;

        public OperatorClass Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass(Kind);
        }
    }
}