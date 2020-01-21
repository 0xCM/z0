//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class SurrogateTypes
    {                
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
            
            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke() => f();
        }
    }

}