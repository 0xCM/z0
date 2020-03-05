//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    public readonly struct P2Kind<T> : IP2Kind<T>
        where T : IP2Kind<T>
    {
        [MethodImpl(Inline)]
        public static implicit operator P2Kind<T>(T src)
            => new P2Kind<T>(src);

        readonly T p2k;
        
        [MethodImpl(Inline)]
        P2Kind(T p2k)
        {
            this.p2k = p2k;
            this.Exponent = p2k.Exponent;
            this.Value = p2k.Value - 1ul;
        }
        
        public byte Exponent {get;}

        public ulong Value {get;}
    }

    public readonly struct P2m1Kind<T> : IP2m1Kind<T>
        where T : IP2Kind<T>
    {
        [MethodImpl(Inline)]
        public static implicit operator P2m1Kind<T>(T src)
            => new P2m1Kind<T>(src);

        readonly T p2k;
        
        [MethodImpl(Inline)]
        P2m1Kind(T p2k)
        {
            this.p2k = p2k;
            this.Exponent = p2k.Exponent;
            this.Value = p2k.Value - 1ul;
        }
        
        public byte Exponent {get;}

        public ulong Value {get;}
    }
}