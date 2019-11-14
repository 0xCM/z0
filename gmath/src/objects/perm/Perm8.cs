//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    

    /// <summary>
    /// Defines canonical literals for representing terms of permutations on 8 symbols
    /// </summary>
    [Flags]
    public enum Perm8 : uint
    {
        /// <summary>
        /// Identifies the first permutation symbol
        /// </summary>
        A = 0b000,

        /// <summary>
        /// Identifies the second permutation symbol
        /// </summary>
        B = 0b001,

        /// <summary>
        /// Identifies the third permutation symbol
        /// </summary>
        C = 0b010,

        /// <summary>
        /// Identifies the fourth permutation symbol
        /// </summary>
        D = 0b011, 

        /// <summary>
        /// Identifies the fifth permutation symbol
        /// </summary>
        E = 0b100, 

        /// <summary>
        /// Identifies the sixth permutation symbol
        /// </summary>
        F = 0b101, 

        /// <summary>
        /// Identifies the seventh permutation symbol
        /// </summary>
        G = 0b110, 

        /// <summary>
        /// Identifies the eighth permutation symbol
        /// </summary>
        H = 0b111, 

        /// <summary>
        /// Represents the 8 symbol identity permutation
        /// </summary>
        ABCDEFGH = A | B << 3 | C << 6 | D << 9 | E << 12 | F << 15 | G << 18 | H << 21,

        /// <summary>
        /// Represents the reversed 8 symbol identity permutation
        /// </summary>
        HFGEDCBA =  H | G << 3 | F << 6 | E << 9 | D << 12 | C << 15 | B << 18 | A << 21,
    }

    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public struct Perm8Spec
    {
        Perm8[] terms;

        public static readonly Perm8Spec Identity = new Perm8Spec(
            Perm8.A, Perm8.B, Perm8.C, Perm8.D, 
            Perm8.E, Perm8.F, Perm8.G, Perm8.H);

        Perm8Spec(params Perm8[] terms)
            => this.terms = terms;

        public Perm8 this[Perm8 index]
        {
            [MethodImpl(Inline)]
            get => terms[(int)index];
            [MethodImpl(Inline)]
            set => terms[(int)index] = value;
        }

        [MethodImpl(Inline)]
        public Perm8Spec Replicate()
        {
            var dst = new Perm8[8];
            terms.CopyTo(dst);
            return new Perm8Spec(dst);
        }

        [MethodImpl(Inline)]        
        public Span<T> ToSpan<T>()
            where T : unmanaged
                => terms.AsSpan().As<Perm8, T>();
    }
}