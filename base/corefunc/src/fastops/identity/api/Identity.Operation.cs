//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static OpIdentity;

    partial class Identity
    {
        /// <summary>
        /// Defines an operation identifier of the form {opname}_{w}X{bitsize(k)}{u | i | f}{_suffix} to identify 
        /// an operation over a segmented type of bitwidth w over a primal kind k
        /// </summary>
        /// <param name="opname">The base operator name/operator classifier</param>
        /// <param name="w">The total bit-widht of the segmented type</param>
        /// <param name="k">The primal cell kind</param>
        /// <param name="generic">Whether a generic operation is identified</param>
        /// <param name="asm">Whether the moniker has an asm suffix</param>
        public static OpIdentity operation(string opname, FixedWidth w, NumericKind k, bool generic, string suffix = null)
        {
            var g = generic ? $"{Generic}" : string.Empty;
            var suffixPart = string.IsNullOrWhiteSpace(suffix) ?  string.Empty : $"{SuffixSep}{suffix}";

            if(generic && k == NumericKind.None)
                return OpIdentity.Define(concat(opname, PartSep, Generic, suffixPart));            
            else if(w.IsSome())
                return OpIdentity.Define(concat(opname, PartSep, $"{g}{w.Format()}{TypeIdentity.SegSep}{NumericType.signature(k)}", suffixPart));
            else
                return OpIdentity.Define(concat($"{opname}_{g}{NumericType.signature(k)}{suffixPart}"));
        }

        /// <summary>
        /// Produces an identifier of the form {opname}_{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity operation(string opname, NumericKind k)
            => operation(opname, FixedWidth.None, k, false);

        /// <summary>
        /// Produces an identifier of the form {opname}_{g}{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity operation(string opname, NumericKind k, bool generic)
            => operation(opname, FixedWidth.None, k, generic);

        /// <summary>
        /// Defines a moniker with rendering {opname}_N{u | i | f} that identifies an
        /// operation over a primal type of bit width N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity operation<T>(string opname, HK.Numeric<T> hk)
            where T : unmanaged
                => operation(opname,typeof(T).NumericKind());

        /// <summary>
        /// Produces an identifier of the form {opname}_{w}{typesig(nk)}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity operation(string opname, FixedWidth w, NumericKind nk)
            => operation(opname,w,nk,false);
    }
}