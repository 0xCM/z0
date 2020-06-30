//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
     using System;
     using System.Runtime.CompilerServices;

     using static Konst;
     using static LetterTypes;
     using static PermLits;

    partial struct Symbolic
    {        
        [MethodImpl(Inline), Op]
        public static Perm4L perm(A a, B b, C c, D d)
            => Perm4L.ABCD;

        [MethodImpl(Inline), Op]
        public static Perm4L perm(A a, B b,  D d, C c)
            => Perm4L.ABDC;

        [MethodImpl(Inline), Op]
        public static Perm4L perm(A a, C c, B b,  D d)
            => Perm4L.ACBD;

        [MethodImpl(Inline), Op]
        public static Perm8L permid(N8 n)
            => Perm8Identity; 

        [MethodImpl(Inline), Op]
        public static Perm16L permid(N16 n)
            => Perm16Identity; 

        /// <summary>
        /// Determines whether a permutation literal is a symbol
        /// </summary>
        /// <param name="src">The value to inspect</param>
        [MethodImpl(Inline), Op]
        public static bool test(Perm4L src)
            => (byte)src <= 3;

        /// <summary>
        /// Determines whether a permutation literal is a symbol
        /// </summary>
        /// <param name="src">The value to inspect</param>
        [MethodImpl(Inline), Op]
        public static bool test(Perm8L src)
            => (uint)src <= 7;

        /// <summary>
        /// Determines whether a permutation literal is a symbol
        /// </summary>
        /// <param name="src">The value to inspect</param>
        [MethodImpl(Inline), Op]
        public static bool test(Perm16L src)
            => (ulong)src <= 15;            
    }
}