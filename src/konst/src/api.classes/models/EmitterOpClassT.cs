//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct EmitterOpClass<T> : IOperatorClassHost<EmitterOpClass<T>,ApiOperatorClass,T>
    {
        public ApiOperatorClass Kind
            => ApiOperatorClass.Emitter;

        public OperatorClass<T> Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass<T>(Kind);
        }

        public EmitterOpClass Untyped
            => default;

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<T>(EmitterOpClass<T> src)
            => src.Classifier;

        [MethodImpl(Inline)]
        public static implicit operator EmitterOpClass(EmitterOpClass<T> src)
            => src.Untyped;
    }
}