//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class Surrogates
    {
        /// <summary>
        /// Captures a delegate that is exposed as an emitter
        /// </summary>
        public readonly struct Emitter<T> : IEmitter<Emitter<T>,T>
        {
            public OpIdentity Id {get;}

            readonly Z0.Emitter<T> F;

            [MethodImpl(Inline)]
            public static implicit operator Func<T>(Emitter<T> src)
                => src.ToFunc();

            [MethodImpl(Inline)]
            public static implicit operator Emitter<T>(Func<T> src)
                => src.ToEmitter();

            [MethodImpl(Inline)]
            public Emitter(Z0.Emitter<T> f, OpIdentity id)            
            {
                this.F = f;
                this.Id = id;
            }
            
            [MethodImpl(Inline)]
            public T Invoke() => F();

            public Z0.Emitter<T> Subject
            {
                [MethodImpl(Inline)]
                get => F;
            }

            [MethodImpl(Inline)]
            public Func<T> AsFunc()
                => this.ToFunc();
        }

        public readonly struct Emitter<T,C> : IEmitter<Emitter<T,C>,T,C>
            where T : unmanaged
            where C : unmanaged
        {
            public OpIdentity Id {get;}

            readonly Z0.Emitter<T,C> F;

            [MethodImpl(Inline)]
            public static implicit operator Func<T>(Emitter<T,C> src)
                => src.ToFunc();

            [MethodImpl(Inline)]
            public static implicit operator Emitter<T,C>(Func<T> src)
                => src.ToEmitter<T,C>();

            [MethodImpl(Inline)]
            public Emitter(Z0.Emitter<T,C> f, OpIdentity id)            
            {
                this.F = f;
                this.Id = id;
            }        

            [MethodImpl(Inline)]
            public Emitter(Z0.Emitter<T> f, OpIdentity id)            
            {
                this.F = new Z0.Emitter<T,C>(f);
                this.Id = id;
            }        

            [MethodImpl(Inline)]
            public T Invoke() => F();

            public Z0.Emitter<T,C> Subject
            {
                [MethodImpl(Inline)]
                get => F;
            }

            [MethodImpl(Inline)]
            public Func<T> AsFunc()
                => this.ToFunc();
        }        
    }
}