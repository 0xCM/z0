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
     }    
}