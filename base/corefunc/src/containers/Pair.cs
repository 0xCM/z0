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
        public static Pair<T> alloc<T>()
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Pair<T> define<T>(T left, T right)
            where T : unmanaged
                => new Pair<T>(left,right);
    }

    /// <summary>
    /// An homogenous pair. That's it.
    /// </summary>
    public struct Pair<T>
        where T : unmanaged
    {
        /// <summary>
        /// The first/left/lo member of the pair
        /// </summary>
        public T A;
        
        /// <summary>
        /// The second/right/hi member of the pair
        /// </summary>
        public T B;

        [MethodImpl(Inline)]
        public static implicit operator Pair<T>((T left, T right) src)
            => Pair.define(src.left, src.right);
        
        [MethodImpl(Inline)]
        public Pair(T left, T right)
        {
            this.A = left;
            this.B = right;
        }                

        [MethodImpl(Inline)]
        public void Deconstruct(out T left, out T right)
        {
            left = this.A;
            right = this.B;
        }

        /// <summary>
        /// Interprets the pair over an alternate domain
        /// </summary>
        /// <typeparam name="D">The alternate type</typeparam>
        [MethodImpl(Inline)]
        public Pair<D> As<D>()
            where D : unmanaged
                => new Pair<D>(Unsafe.As<T,D>(ref A), Unsafe.As<T,D>(ref B));

        public string Format()
            => $"({A},{B})";
    }

}