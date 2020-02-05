//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    public static partial class Identity
    {
        /// <summary>
        /// Extracts an index-identified operation identity part from an operation identity
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="partidx">The 0-based part index</param>
        public static Option<IdentityPart> part(OpIdentity src, int partidx)
        {
            var parts = src.Parts.ToArray();
            if(partidx <= parts.Length - 1)
                return parts[partidx];
            else
                return none<IdentityPart>();
        }

        /// <summary>
        /// Extracts an index-identified segmented identity part from an operation identity
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="partidx">The 0-based part index</param>
        public static Option<SegmentedIdentity> segment(OpIdentity src, int partidx)
            => from p in part(src, partidx)
                from s in segment(p)
                select s;

        /// <summary>
        /// Defines an 8-bit immediate suffix predicated on an immediate value
        /// </summary>
        /// <param name="immval">The source value</param>
        public static string imm8(byte immval)            
            => $"{OpIdentity.SuffixSep}{OpIdentity.Imm}{immval}";

        /// <summary>
        /// Extracts an 8-bit immediate value from an identity if it contains an immediate suffix; otherwise, returns none
        /// </summary>
        /// <param name="src">The source identity</param>
        public static Option<byte> imm8(OpIdentity src)            
        {
            if(src.HasImm && byte.TryParse(src.Identifier.RightOfLast(OpIdentity.Imm), out var immval))
                return immval;
            else
                return none<byte>();
        }

        /// <summary>        
        /// Clears an attached immediate suffix, if any
        /// </summary>
        public static OpIdentity imm8Remove(OpIdentity src)
            => imm8(src).MapValueOrDefault(immval => OpIdentity.Define(src.Identifier.Remove(imm8(immval))), src);

        /// <summary>        
        /// Attaches an immediate suffix to an identity, removing an existing immediate suffix if necessary
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="immval">The immediate value to attach</param>
        public static OpIdentity imm8Add(OpIdentity src, byte immval)
            => OpIdentity.Define(concat(imm8Remove(src).Identifier, imm8(immval)));

        /// <summary>
        /// Gets the name of a method to which to Op attribute is applied
        /// </summary>
        /// <param name="m">The source method</param>
        public static string host(Type t)
        {
            var defaultName = t.Name.ToLower();
            var query = from a in t.CustomAttribute<OpHostAttribute>()
                        where a.Name.IsNotBlank()
                        select a.Name;
            return query.ValueOrDefault(defaultName);            
        }

        public static OpIdentity subject(string opname, NumericKind kind)
            => Identity.operation($"{opname}_subject",kind);

        public static OpIdentity subject<T>(string opname, T t = default)
            where T : unmanaged
                => subject(opname, NumericType.kind<T>());
 
        public static Option<IOpIdentityProvider> provider(IdentityKind kind)
            => kind switch
            {
                IdentityKind.Operation => default(OpIdentityProvider),
                _ => default
            };

        public static ITypeIdentityProvider provider(Type t)
            => TypeIdentities.provider(t);


        readonly struct OpIdentityProvider : IOpIdentityProvider
        {
            public OpIdentity DefineIdentity(MethodInfo src, NumericKind k)
                => Identity.identify(src,k);

            public OpIdentity GroupIdentity(MethodInfo src)            
                => Identity.group(src);

            public OpIdentity GenericIdentity(MethodInfo src)            
                => Identity.generic(src);

            OpIdentity IOpIdentityProvider.DefineIdentity(MethodInfo src)
                => Identity.identify(src);
        } 
    }
}