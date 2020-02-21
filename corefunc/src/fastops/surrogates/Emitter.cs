//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Captures a delegate that is exposed as an emitter
    /// </summary>
    public readonly struct EmitterSurrogate<T> : IEmitter<T>
    {
        public readonly string Name;

        readonly Func<T> f;

        [MethodImpl(Inline)]
        internal EmitterSurrogate(Func<T> f, string name)            
        {
            this.f = f;
            this.Name = name;
        }
        
        public OpIdentity Id => Identity.contracted<T>(Name);

        [MethodImpl(Inline)]
        public T Invoke() => f();
    }

    /// <summary>
    /// Captures a delegate that is exposed as an emitter
    /// </summary>
    public readonly struct FixedEmitterSurrogate<F,T> : IFixedEmitter<F,T>
        where F : unmanaged, IFixed
        where T : unmanaged
    {
        public readonly string Name;

        readonly Func<F> f;

        [MethodImpl(Inline)]
        internal FixedEmitterSurrogate(Func<F> f, string name)            
        {
            this.f = f;
            this.Name = name;
        }
        
        public OpIdentity Id => Identity.contracted<T>(Name);

        [MethodImpl(Inline)]
        public F Invoke() => f();
    }
}