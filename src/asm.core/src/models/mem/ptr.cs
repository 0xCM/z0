//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct AsmOperands
    {
        public readonly struct ptr<T> : ISizedTarget<ptr<T>>
            where T : unmanaged, ISizedTarget<T>
        {
            public readonly T Source;

            [MethodImpl(Inline)]
            public ptr(T src)
            {
                Source = src;
            }

            public AsmAddress Target
            {
                [MethodImpl(Inline)]
                get => Source.Target;
            }

            public AsmSizeKind SizeKind
            {
                [MethodImpl(Inline)]
                get => Source.SizeKind;
            }

            [MethodImpl(Inline)]
            public static implicit operator ptr<T>(T src)
                => new ptr<T>(src);
        }
    }
}