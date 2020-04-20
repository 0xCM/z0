//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
      using System;
      using System.Runtime.CompilerServices;
      using System.Collections.Generic;
      using System.Linq;
      using System.Reflection;

      using static Seed;

      public readonly struct NaturalNumericClosure
      {
            [MethodImpl(Inline)]
            public static NaturalNumericClosure Define(MethodInfo generic,Type natural, Type numeric)
                  => new NaturalNumericClosure(generic, natural, numeric);

            [MethodImpl(Inline)]
            NaturalNumericClosure(MethodInfo method, Type natural, Type numeric)
            {
                  this.ClosedMethod = method.MakeGenericMethod(natural,numeric);
                  this.NaturalType = natural;
                  this.NumericType = numeric;
            }

            public readonly MethodInfo ClosedMethod;
            
            public readonly Type NaturalType;

            public readonly Type NumericType;
      }
}