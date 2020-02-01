//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    using static Moniker;

    public static class OpIdentities
    {
        public static IOpIdentityProvider Provider
            => default(OpIdentity);

        /// <summary>
        /// Produces an identifier of the form {opname}_{g}{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static Moniker define(string opname, NumericKind k, bool generic)
            => define(opname, 0, k, generic, false);

        /// <summary>
        /// Produces an identifier of the form {opname}_{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static Moniker define(string opname, NumericKind k)
            => define(opname, 0, k, false, false);

        /// <summary>
        /// Defines an identifier of the form {opname}_{w}X{bitsize(k)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name/operator classifier</param>
        /// <param name="w">The bit width</param>
        /// <param name="k">The primal cell kind</param>
        [MethodImpl(Inline)]   
        public static Moniker segmented<W>(string opname, NumericKind k, W w)
            where W : unmanaged, ITypeNat
                => Moniker.Parse($"{opname}_{w}{SegSep}{NumericType.signature(k)}");

        /// <summary>
        /// Defines a moniker of the form {opname}_{w}X{bitsize(k)}{u | i | f}{_asm} to identify 
        /// an operation over a segmented type of bitwidth w over a primal kind k
        /// </summary>
        /// <param name="opname">The base operator name/operator classifier</param>
        /// <param name="w">The total bit-widht of the segmented type</param>
        /// <param name="k">The primal cell kind</param>
        /// <param name="generic">Whether a generic operation is identified</param>
        /// <param name="asm">Whether the moniker has an asm suffix</param>
        public static Moniker segmented(string opname, FixedWidth w, NumericKind k, bool generic, bool asm = false) 
            => define(opname, (int)w, k, generic,asm);

        /// <summary>
        /// Defines a moniker in accordance with the supplied parameters
        /// </summary>
        /// <param name="opname">The base operator name/operator classifier</param>
        /// <param name="w">For segmented types, the total bit-width; otherwise 0</param>
        /// <param name="k">The primal kind</param>
        static Moniker define(string opname, int w, NumericKind k, bool generic, bool asm)
        {
            var g = generic ? $"{Generic}" : string.Empty;
            var asmPart = asm ? $"{SuffixSep}{Asm}" : string.Empty;

            if(generic && k == NumericKind.None)
                return Moniker.Parse(concat(opname, PartSep, Generic));            
            else if(w != 0)
                return Moniker.Parse($"{opname}{PartSep}{g}{w}{SegSep}{NumericType.signature(k)}{asmPart}");
            else
                return Moniker.Parse($"{opname}_{g}{NumericType.signature(k)}{asmPart}");
        }

    }
}