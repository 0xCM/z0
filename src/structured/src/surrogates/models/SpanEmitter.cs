//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Surrogates
    {
        /// <summary>
        /// Captures a delegate that is exposed as an emitter
        /// </summary>
        public readonly struct SpanEmitter<T> : ISpanEmitter<T>
        {
            public OpIdentity Id {get;}

            readonly Z0.SpanEmitter<T> F;

            [MethodImpl(Inline)]
            public SpanEmitter(Z0.SpanEmitter<T> f, OpIdentity id)            
            {
                this.F = f;
                this.Id = id;
            }            

            [MethodImpl(Inline)]
            public Span<T> Invoke() => F();

            public Z0.SpanEmitter<T> Subject
            {
                [MethodImpl(Inline)]
                get => F;
            }

        }        
    }
}