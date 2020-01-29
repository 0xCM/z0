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
        /// Gets the name of a method to which to Op attribute is applied
        /// </summary>
        /// <param name="m">The source method</param>
        public static string HostName(this Type t)
            => OpIdentity.hostname(t);
        
        /// <summary>
        /// Gets the name of a method to which to Op attribute is applied
        /// </summary>
        /// <param name="m">The source method</param>
        public static string OpName(this MethodInfo m)
            => OpIdentity.opname(m);
        
        /// <summary>
        /// Clears the immediate attached to the moniker, if any
        /// </summary>
        public static Moniker WithoutImm(this Moniker src)
        {
            if(src.HasImm)
            {
                var immval = src.Text.RightOfLast(Moniker.ImmIndicator);
                var cleared = src.Text.Remove($"{Moniker.SuffixSep}{Moniker.ImmIndicator}{immval}");
                return Moniker.Parse(cleared);                
            }
            else
                return src;
        }

        public static Moniker WithImm(this Moniker src, byte imm)
            => Moniker.Parse(concat(src.WithoutImm().Text, $"{Moniker.SuffixSep}{Moniker.ImmIndicator}{imm}"));
    }
}