//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class DelegateSurrogates
    {                
        /// <summary>
        /// Captures a delegate that is exposed as an emitter
        /// </summary>
        public readonly struct Emitter<T> : IEmitter<T>
        {
            public readonly string Name;

            readonly Func<T> f;

            [MethodImpl(Inline)]
            internal Emitter(Func<T> f, string name)            
            {
                this.f = f;
                this.Name = name;
            }
            
            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke() => f();
        }
    }

}