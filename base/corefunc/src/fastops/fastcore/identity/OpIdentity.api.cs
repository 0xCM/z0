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
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    using static Moniker;

    public static class OpIdentity
    {
       public static IOpIdentityProvider Provider
            => default(OpIdentityProvider);

        [MethodImpl(Inline)]   
        public static Moniker define(string text)
            => new Moniker(text);

        /// <summary>
        /// Defines a moniker in accordance with the supplied parameters
        /// </summary>
        /// <param name="opname">The base operator name/operator classifier</param>
        /// <param name="w">For segmented types, the total bit-width; otherwise 0</param>
        /// <param name="k">The primal kind</param>
        public static Moniker define(string opname, int w, PrimalKind k, bool generic, bool asm)
        {
            var g = generic ? $"{GenericIndicator}" : string.Empty;
            var asmPart = asm ? $"{SuffixSep}{AsmIndicator}" : string.Empty;

            if(generic && k == PrimalKind.None)
                return new Moniker(concat(opname, PartSep, GenericIndicator));            
            else if(w != 0)
                return new Moniker($"{opname}{PartSep}{g}{w}{SegSep}{PrimalType.primalsig(k)}{asmPart}");
            else
                return new Moniker($"{opname}_{g}{PrimalType.primalsig(k)}{asmPart}");
        }

        /// <summary>
        /// Produces an identifier of the form {opname}_{g}{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static Moniker define(string opname, PrimalKind k, bool generic)
            => define(opname, 0, k, generic, false);

        /// <summary>
        /// Produces an identifier of the form {opname}_{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static Moniker define(string opname, PrimalKind k)
            => define(opname, 0, k, false, false);

        /// <summary>
        /// Defines an identifier of the form {opname}_{w}X{bitsize(k)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name/operator classifier</param>
        /// <param name="w">The bit width</param>
        /// <param name="k">The primal cell kind</param>
        [MethodImpl(Inline)]   
        public static Moniker segmented<W>(string opname, PrimalKind k, W w)
            where W : unmanaged, ITypeNat
                => new Moniker($"{opname}_{w}{SegSep}{PrimalType.primalsig(k)}");

        /// <summary>
        /// Defines a moniker of the form {opname}_{w}X{bitsize(k)}{u | i | f}{_asm} to identify 
        /// an operation over a segmented type of bitwidth w over a primal kind k
        /// </summary>
        /// <param name="method">The source method</param>
        /// <param name="w">The total width of the type</param>
        /// <param name="k">The primal segment kind</param>
        [MethodImpl(Inline)]   
        public static Moniker segmented(MethodInfo method, FixedWidth w, PrimalKind k)
            => segmented(method.FastOpName(), w, k, method.IsConstructedGenericMethod, false);

        /// <summary>
        /// Defines a moniker of the form {opname}_{w}X{bitsize(k)}{u | i | f}{_asm} to identify 
        /// an operation over a segmented type of bitwidth w over a primal kind k
        /// </summary>
        /// <param name="opname">The base operator name/operator classifier</param>
        /// <param name="w">The total bit-widht of the segmented type</param>
        /// <param name="k">The primal cell kind</param>
        /// <param name="generic">Whether a generic operation is identified</param>
        /// <param name="asm">Whether the moniker has an asm suffix</param>
        public static Moniker segmented(string opname, FixedWidth w, PrimalKind k, bool generic, bool asm = false)
            => define(opname, (int)w, k, generic,asm);
    }
}