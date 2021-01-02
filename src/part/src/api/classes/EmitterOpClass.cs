//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct EmitterOpClass : IOperatorClassHost<EmitterOpClass,ApiOperatorKind>
    {
        public ApiOperatorKind Kind
            => ApiOperatorKind.Emitter;

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass(EmitterOpClass src)
            => src.Classifier;

        public OperatorClass Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass(Kind);
        }
    }

    public readonly struct EmitterOpClass<T> : IOperatorClassHost<EmitterOpClass<T>,ApiOperatorKind,T>
    {
        public ApiOperatorKind Kind
            => ApiOperatorKind.Emitter;

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