//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Captures a delegate that is exposed as an emitter
    /// </summary>
    public readonly struct EmitterSurrogate<T> : IEmitter<T>
    {
        public readonly string Name;

        readonly Emitter<T> f;

        [MethodImpl(Inline)]
        public EmitterSurrogate(Emitter<T> f, string name)            
        {
            this.f = f;
            this.Name = name;
        }
        
        public OpIdentity Id => OpIdentity.contracted<T>(Name);

        [MethodImpl(Inline)]
        public T Invoke() => f();
    }

    /// <summary>
    /// Captures a delegate that is exposed as an emitter
    /// </summary>
    public readonly struct FixedEmitterSurrogate<F> : IFixedEmitter<F>
        where F : unmanaged, IFixed
    {
        public readonly string Name;

        readonly Func<F> f;

        [MethodImpl(Inline)]
        public FixedEmitterSurrogate(Func<F> f, string name)            
        {
            this.f = f;
            this.Name = name;
        }
        
        public OpIdentity Id => OpIdentity.contracted<F>(Name);

        [MethodImpl(Inline)]
        public F Invoke() => f();
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
        public FixedEmitterSurrogate(Func<F> f, string name)            
        {
            this.f = f;
            this.Name = name;
        }
        
        public OpIdentity Id => OpIdentity.contracted<T>(Name);

        [MethodImpl(Inline)]
        public F Invoke() => f();
    }

    /// <summary>
    /// Captures a delegate that is exposed as an emitter
    /// </summary>
    public readonly struct FixedSpanEmitterSurrogate<F> : IFixedSpanEmitter<F>
        where F : unmanaged, IFixed
    {
        public readonly string Name;

        readonly FixedSpanEmitter<F> f;

        [MethodImpl(Inline)]
        public FixedSpanEmitterSurrogate(FixedSpanEmitter<F> f, string name)            
        {
            this.f = f;
            this.Name = name;
        }
        
        public OpIdentity Id => OpIdentity.contracted<F>(Name);

        [MethodImpl(Inline)]
        public Span<F> Invoke() => f();
    }
    
    /// <summary>
    /// Captures a delegate that is exposed as an emitter
    /// </summary>
    public readonly struct FixedSpanEmitterSurrogate<F,T> : IFixedSpanEmitter<F,T>
        where F : unmanaged, IFixed
        where T : unmanaged
    {
        public readonly string Name;

        readonly FixedSpanEmitter<F,T> f;

        [MethodImpl(Inline)]
        public FixedSpanEmitterSurrogate(FixedSpanEmitter<F,T> f, string name)            
        {
            this.f = f;
            this.Name = name;
        }
        
        public OpIdentity Id => OpIdentity.contracted<T>(Name);

        [MethodImpl(Inline)]
        public Span<F> Invoke() => f();
    }
}