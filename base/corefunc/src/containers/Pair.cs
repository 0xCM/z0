//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines api surface for pair
    /// </summary>
    public static class Pair
    {
        [MethodImpl(Inline)]
        public static Pair<T> Alloc<T>()
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Pair<T> Define<T>(T left, T right)
            where T : unmanaged
                => new Pair<T>(left,right);
    }

    /// <summary>
    /// A pair. That's it.
    /// </summary>
    public struct Pair<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public Pair(T left, T right)
        {
            this.A = left;
            this.B = right;
        }
                
        public T A;
        
        public T B;

        [MethodImpl(Inline)]
        public void Deconstruct(out T left, out T right)
        {
            left = this.A;
            right = this.B;
        }

        public string Format()
            => $"({A},{B})";
    }

}