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

    public readonly struct Sink<T> : ISink<T>
    {
        [MethodImpl(Inline)]
        public static Sink<T> from(StreamWriter dst)
        {
            void Target(in T src) => dst.WriteLine(src);
            return new Sink<T>(Target);
        }

        readonly Receiver<T> Target;
        
        [MethodImpl(Inline)]
        public Sink(Receiver<T> dst)
        {
            Target = dst;
        }
        
        [MethodImpl(Inline)]
        public void Deposit(T src)
        {
            Target(src);
        }
    }    
}