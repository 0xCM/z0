//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    public static class ZKindX
    {
        /// <summary>
        /// Specifies the bit-width of a classified primitive
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static int BitWidth(this PrimalKind k)
            => Classified.width(k);

        /// <summary>
        /// Specifies the bit-width of a classified cpu vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static int BitWidth(this CpuVectorKind k)
            => Classified.width(k);

        /// <summary>
        /// Determines a sub-classification c := {'u' | 'i' | 'f'} according to whether a classified primal type
        /// is unsigned integral, signed integral or floating-point
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static char Sign(this PrimalKind k)
            => Classified.sign(k);

        /// <summary>
        /// Determines a sub-classification c := {'u' | 'i' | 'f'} according to whether a classified vector
        /// is defined over unsigned integral, signed integral or floating-point primal components
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static char Sign(this CpuVectorKind k)
            => Classified.sign(k);

        /// <summary>
        /// Determines whether a specified kind is included within a classification
        /// </summary>
        /// <param name="k">The classification</param>
        /// <param name="match">The kind to check</param>
        [MethodImpl(Inline)]
        public static bit Is(this PrimalKind k, PrimalKind match)        
            => (k & match) != 0;

        public static IEnumerable<PrimalKind> Distinct(this PrimalKind k)       
        {
            if(k.Is(PrimalKind.U8))
                yield return PrimalKind.U8;

            if(k.Is(PrimalKind.I8))
                yield return PrimalKind.I8;

            if(k.Is(PrimalKind.U16))
                yield return PrimalKind.U16;

            if(k.Is(PrimalKind.I16))
                yield return PrimalKind.I16;

            if(k.Is(PrimalKind.U32))
                yield return PrimalKind.U32;

            if(k.Is(PrimalKind.I32))
                yield return PrimalKind.I32;

            if(k.Is(PrimalKind.U64))
                yield return PrimalKind.U64;

            if(k.Is(PrimalKind.I64))
                yield return PrimalKind.I64;

            if(k.Is(PrimalKind.F32))
                yield return PrimalKind.F32;

            if(k.Is(PrimalKind.F64))
                yield return PrimalKind.F64;
        }
            
        [MethodImpl(Inline)]
        public static bool IsZFunc(this MethodInfo m)
            => Attribute.IsDefined(m,typeof(ZFuncAttribute));

        public static IEnumerable<PrimalKind> SupportedPrimals(this MethodInfo m)
        {
            if(m.IsZFunc() && m.IsOpenGeneric())
            {
                var a = m.GetCustomAttribute<ZFuncAttribute>();
                foreach(var k in a.Closures.Distinct())
                    yield return k;
            }
        }            
    }
}