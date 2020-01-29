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

        public static string hostname(Type t)
            => t.CustomAttribute<OpHostAttribute>().MapValueOrDefault(a => a.Name, t.Name.ToLower());
                
        /// <summary>
        /// Gets the name of a method to which an Op attribute is applied
        /// </summary>
        /// <param name="m">The source method</param>
        public static string opname(MethodInfo m)
        {
            var attrib = m.CustomAttribute<OpAttribute>();
            if(attrib.IsNone())
                return m.Name;
        
            var sep = AsciSym.Tilde;
            var attribVal = attrib.Value;  
            var customName = attribVal.Name;
            var modifier = attribVal.FacetModifier;
            var combine = (modifier & OpFacetModifier.CombineNames) != 0;
            
            var name = string.Empty;

            if(customName.IsNotBlank())
            {
                name += customName;

                if(combine)
                {
                    name += sep;
                    name += m.Name;
                }
            }
            else
                name += m.Name;
                
            return name;            
        }

        /// <summary>
        /// Defines a moniker in accordance with the supplied parameters
        /// </summary>
        /// <param name="opname">The base operator name/operator classifier</param>
        /// <param name="w">For segmented types, the total bit-width; otherwise 0</param>
        /// <param name="k">The primal kind</param>
        public static Moniker define(string opname, int w, NumericKind k, bool generic, bool asm)
        {
            var g = generic ? $"{GenericIndicator}" : string.Empty;
            var asmPart = asm ? $"{SuffixSep}{AsmIndicator}" : string.Empty;

            if(generic && k == NumericKind.None)
                return Moniker.Parse(concat(opname, PartSep, GenericIndicator));            
            else if(w != 0)
                return Moniker.Parse($"{opname}{PartSep}{g}{w}{SegSep}{NumericType.signature(k)}{asmPart}");
            else
                return Moniker.Parse($"{opname}_{g}{NumericType.signature(k)}{asmPart}");
        }

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
        /// <param name="method">The source method</param>
        /// <param name="w">The total width of the type</param>
        /// <param name="k">The primal segment kind</param>
        [MethodImpl(Inline)]   
        public static Moniker segmented(MethodInfo method, FixedWidth w, NumericKind k)
            => segmented(method.OpName(), w, k, method.IsConstructedGenericMethod, false);

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
    }
}