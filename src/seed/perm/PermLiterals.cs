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

     [ApiHost]
     public class PermLiterals : IApiHost<PermLiterals>
     {
          [MethodImpl(Inline), Op]
          public static Perm8L identity(N8 n)
               => Perm8Identity; 

          [MethodImpl(Inline), Op]
          public static Perm8L reversed(N8 n)
               => Perm8Reversed; 

          [MethodImpl(Inline), Op]
          public static Perm16L identity(N16 n)
               => Perm16Identity; 

          [MethodImpl(Inline), Op]
          public static Perm4L perm(A a, B b, C c, D d)
               => Perm4L.ABCD;

          [MethodImpl(Inline), Op]
          public static Perm4L perm(A a, B b,  D d, C c)
               => Perm4L.ABDC;

          [MethodImpl(Inline), Op]
          public static Perm4L perm(A a, C c, B b,  D d)
               => Perm4L.ACBD;

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

    partial class XTend
    {
        /// <summary>
        /// Determines whether a permutation literal is a symbol
        /// </summary>
        /// <param name="src">The value to inspect</param>
        [MethodImpl(Inline)]
        public static bit IsSymbol(this Perm4L src)
            => PermLiterals.test(src);

        /// <summary>
        /// Determines whether a permutation literal is a symbol
        /// </summary>
        /// <param name="src">The value to inspect</param>
        [MethodImpl(Inline)]
        public static bit IsSymbol(this Perm8L src)
            => PermLiterals.test(src);

        /// <summary>
        /// Determines whether a permutation literal is a symbol
        /// </summary>
        /// <param name="src">The value to inspect</param>
        [MethodImpl(Inline)]
        public static bit IsSymbol(this Perm16L src)
            => PermLiterals.test(src);        
    }
}