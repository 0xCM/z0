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

        readonly Func<T> f;

        [MethodImpl(Inline)]
        public EmitterSurrogate(Func<T> f, string name)            
        {
            this.f = f;
            this.Name = name;
        }
        
        public OpIdentity Id => OpIdentity.contracted<T>(Name);

        [MethodImpl(Inline)]
        public T Invoke() => f();
    }
}