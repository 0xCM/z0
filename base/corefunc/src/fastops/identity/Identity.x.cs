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


    partial class FastOpX
    {
        /// <summary>
        /// Identifies the method
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity Identify(this MethodInfo m)
            => OpIdentities.Provider.DefineIdentity(m);

        /// <summary>
        /// Identifies the delegate
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity Identify(this Delegate m)
            => OpIdentities.Provider.DefineIdentity(m.Method);

        /// <summary>
        /// Gets the name of a method to which to Op attribute is applied
        /// </summary>
        /// <param name="m">The source method</param>
        public static string HostName(this Type t)
            => t.CustomAttribute<OpHostAttribute>().MapValueOrDefault(a => a.Name, t.Name.ToLower());
        
        /// <summary>
        /// Gets the name of a method to which to Op attribute is applied
        /// </summary>
        /// <param name="m">The source method</param>
        public static string OpName(this MethodInfo m)
        {
            var attrib = m.CustomAttribute<OpAttribute>();
            if(attrib.IsNone())
                return m.Name;
        
            var sep = AsciSym.Tilde;
            var attribVal = attrib.Value;  
            var customName = attribVal.Name;
            var combine = attribVal.CombineCustomName;
            
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

        public static Option<byte> ParseImm(this OpIdentity src)            
        {
            if(src.HasImm && byte.TryParse(src.Identifier.RightOfLast(OpIdentity.Imm), out var immval))
                return immval;
            else
                return none<byte>();
        }

        [MethodImpl(Inline)]   
        public static OpIdentity SegmentMoniker<W>(this NumericKind k, W w = default)
            where W : unmanaged, ITypeNat
                => OpIdentity.Define($"{w}{OpIdentity.SegSep}{NumericType.signature(k)}");

        [MethodImpl(Inline)]   
        public static OpIdentity SegmentMoniker(this NumericKind k, FixedWidth w)
            => OpIdentity.Define($"{w.Format()}{OpIdentity.SegSep}{NumericType.signature(k)}");

        public static Option<ScalarIdentity> ParseScalar(this OpIdentityPart part)
        {
            if(part.PartKind == OpIdentityPartKind.Scalar)
            {
                return from k in NumericType.ParseKind(part.PartText)
                    let scalar = ScalarIdentity.Define((FixedWidth)k.Width(), k.Indicator())
                    select scalar;
            }
            else
                return none<ScalarIdentity>();                
        }

        public static Option<OpIdentityPart> Part(this OpIdentity src, int partidx)
        {
            var parts = src.Parts.ToArray();
            if(partidx <= parts.Length - 1)
                return parts[partidx];
            else
                return none<OpIdentityPart>();
        }

        public static Option<OpIdentitySegment> ParseSegment(this OpIdentityPart part)
        {
            if(part.PartKind == OpIdentityPartKind.Segment)
            {
                if(OpIdentitySegment.TryParse(part.PartText, out var seg))
                    return seg;                
            }

            return none<OpIdentitySegment>();                
        }

        public static Option<OpIdentitySegment> ParseSegment(this OpIdentity src, int partidx)
            => from p in src.Part(partidx)
                from s in p.ParseSegment()
                select s;

        static string ImmSuffix(byte immval)            
            => $"{OpIdentity.SuffixSep}{OpIdentity.Imm}{immval}";

        /// <summary>        
        /// Clears the immediate attached to the moniker, if any
        /// </summary>
        public static OpIdentity WithoutImm(this OpIdentity src)
            => src.ParseImm().MapValueOrDefault(immval => OpIdentity.Define(src.Identifier.Remove(ImmSuffix(immval))), src);
    
        public static OpIdentity WithImm(this OpIdentity src, byte imm)
            => OpIdentity.Define(concat(src.WithoutImm().Identifier, ImmSuffix(imm)));

        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        public static IEnumerable<OpClosureInfo> Close(this GenericOpSpec op)
            => from k in op.Kinds
                let pt = k.ToClrType()
                where pt.IsSome()
                let id = OpIdentities.Provider.DefineIdentity(op.Root, k)
                where !id.IsEmpty
                select OpClosureInfo.Define(id, k, op.Root.MakeGenericMethod(pt.Value));                

    }
}