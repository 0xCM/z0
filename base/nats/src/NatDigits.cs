//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static nfunc;
    using static constant;
    
    /// <summary>
    /// Defines a generic digit representation realtive to a natural base
    /// </summary>
    /// <typeparam name="N">The natural base type</typeparam>
    /// <typeparam name="T">The digit's primal type</typeparam>
    public readonly struct Digit<N,T> : IDigit<N,Digit<N,T>,T>
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {
        readonly T value;

        /// <summary>
        /// Specifies the integral value value of the natural base
        /// </summary>
        public static uint Base => (uint)natu<N>();

        [MethodImpl(Inline)]
        public static bool operator ==(Digit<N,T> lhs, Digit<N,T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(Digit<N,T> lhs, Digit<N,T> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static implicit operator uint(Digit<N,T> src)
            => src.ToUInt();

        [MethodImpl(Inline)]
        public static implicit operator T(Digit<N,T> src)
            => src.value;

        [MethodImpl(Inline)]
        public Digit(T src)
            => value = src;
        
        public uint ToUInt()
            => (uint)Convert.ChangeType(value, typeof(uint));

        public uint @base
        {
            [MethodImpl(Inline)]
            get => Base;
        }
        
        [MethodImpl(Inline)]
        public string format()
            => ToUInt().ToString();

        [MethodImpl(Inline)]
        public bool Equals(Digit<N,T> rhs)
            => value.Equals(rhs);

        [MethodImpl(Inline)]        
        public override bool Equals(object rhs)
            => rhs is Digit<N,T> ? Equals((Digit<N,T>)rhs) : false;
        
        [MethodImpl(Inline)]        
        public override int GetHashCode()
            => value.GetHashCode();
        
        public override string ToString()
            => format();
    }
}