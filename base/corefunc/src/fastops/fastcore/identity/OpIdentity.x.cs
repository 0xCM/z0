//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static zfunc;

    public static class OpIdentityX
    {
        /// <summary>
        /// Specifies the operation name
        /// </summary>
        public static Moniker WithName(this Moniker src, string name)
            => OpIdentity.segmented(name, src.SegmentedWidth, src.PrimalKind, src.IsGeneric, src.IsAsm);

        /// <summary>
        /// Enables the assembly indicator
        /// </summary>
        public static Moniker WithAsm(this Moniker src)
            => src.IsAsm ? src : OpIdentity.segmented(src.Name, src.SegmentedWidth, src.PrimalKind, src.IsGeneric, true);
        
        /// <summary>
        /// Enables the generic indicator
        /// </summary>
        public static Moniker WithGeneric(this Moniker src)
            => OpIdentity.segmented(src.Name, src.SegmentedWidth, src.PrimalKind, true, src.IsAsm);

        /// <summary>
        /// Disables the generic indicator if enabled
        /// </summary>
        public static Moniker WithoutGeneric(this Moniker src)
            => OpIdentity.segmented(src.Name, src.SegmentedWidth, src.PrimalKind, false, src.IsAsm);

        /// <summary>
        /// Specifies the segmented width
        /// </summary>
        public static Moniker WithSegmentedWidth(this Moniker src, int w)
            => OpIdentity.define(src.Name, w, src.PrimalKind, src.IsGeneric, src.IsAsm);

        /// <summary>
        /// Specifies the primal kind
        /// </summary>
        public static Moniker WithKind(this Moniker src, PrimalKind k)
            => OpIdentity.segmented(src.Name, src.SegmentedWidth, k, src.IsGeneric, src.IsAsm);

        /// <summary>
        /// Clears the immediate attached to the moniker, if any
        /// </summary>
        public static Moniker WithoutImm(this Moniker src)
        {
            if(src.HasImm)
            {
                var immval = src.Text.RightOfLast(Moniker.ImmIndicator);
                var cleared = src.Text.Remove($"{Moniker.SuffixSep}{Moniker.ImmIndicator}{immval}");
                return OpIdentity.define(cleared);                
            }
            else
                return src;
        }

        public static Moniker WithImm(this Moniker src, byte imm)
            => OpIdentity.define(concat(src.WithoutImm().Text, $"{Moniker.SuffixSep}{Moniker.ImmIndicator}{imm}"));
    }
}