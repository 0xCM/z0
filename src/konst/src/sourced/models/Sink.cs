//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static z;

    /// <summary>
    /// Defines a receiver-predicated sink
    /// </summary>
    public readonly struct Sink<T> : ISink<T>
    {
        readonly Receiver<T> Target;
        
        [MethodImpl(Inline)]
        public Sink(Receiver<T> dst)
            => Target = dst;
        
        [MethodImpl(Inline)]
        public void Deposit(T src)
            => Target(src);
    }    
}