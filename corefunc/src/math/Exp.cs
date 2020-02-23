//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public interface IExp<R,B> : IFormattable<R>
        where B : unmanaged, ITypeNat
        where R : IExp<R,B>
    {
        
    }

    /// <summary>
    /// Defines a natural base raised to a nonnegative integral power
    /// </summary>
    public readonly struct Exp<B> : IExp<Exp<B>, B>
        where B : unmanaged, ITypeNat
    {
        public readonly uint Power;

        public uint Base => (uint)nateval<B>();

        [MethodImpl(Inline)]
        public static Exp<B> operator *(Exp<B> a, Exp<B> b)
            => new Exp<B>(a.Power + b.Power);

        [MethodImpl(Inline)]
        public Exp(uint exp)
        {
            this.Power = exp;
        }
        
        public string Format()
            => $"{Base}^{Power}";

        public override string ToString()
            => Format();
    }

}