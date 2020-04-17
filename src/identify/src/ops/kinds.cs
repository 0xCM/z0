//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Seed;    

    partial class Identify
    {
        [MethodImpl(Inline)]
        public static PrimalIdentity primal(Type t)
            => t.IsSystemDefined() ? 
               (NumericKinds.test(t)
               ? PrimalIdentity.Define(t.NumericKind(), t.SystemKeyword())
               : PrimalIdentity.Define(t.SystemKeyword())
               )
               : PrimalIdentity.Empty;

        /// <summary>
        /// Computes the primal types identified by a specified kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        [MethodImpl(Inline)]
        public static ISet<NumericKind> kinds(NumericKind k)
            => GetKindset(k);
   }    
}