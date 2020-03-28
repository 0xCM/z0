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

    using static Core;
    
    readonly struct MethodIdentityDiviner : IMethodIdentityDiviner
    {        
        public OpIdentity DivineIdentity(MethodInfo src)
            => Identity.identify(src);        
    }

    public static partial class Identity
    {
        /// <summary>
        /// Identifies the method
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity identify(MethodInfo src)
        {            
            if(src.IsOpenGeneric())
                return generic(src).Generialize();
            else if(src.IsConstructedGenericMethod)
                return constructed(src);
            else
                return nongeneric(src);
        }            
        
        /// <summary>
        /// Identifies the delegate
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity identify(Delegate m)
            => identify(m.Method);

        [MethodImpl(Inline)]
        public static TypeIdentity identify(Type t)
            => TypeIdentityDiviner.IdentityProvider(t).DefineIdentity(t);

        /// <summary>
        /// Extracts an index-identified segmented identity part from an operation identity
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="partidx">The 0-based part index</param>
        public static Option<SegmentedIdentity> segment(OpIdentity src, int partidx)
            => from p in part(src, partidx)
                from s in segmented(p)
                select s;

        static OpIdentity identify(MethodInfo src, NumericKind k)
        {
            var t = k.SystemType();
            if(src.IsOpenGeneric() && t.IsSome())
                return identify(src.MakeGenericMethod(t));
            else
                return identify(src);
        }

        /// <summary>
        /// Transforms a nonspecific identity part into a specialized segment part, if the source part is indeed a segment identity
        /// </summary>
        /// <param name="part">The source part</param>
        static Option<SegmentedIdentity> segmented(IdentityPart part)
        {
            if(part.PartKind == IdentityPartKind.Segment)
            {
                if(Z0.SegmentedIdentity.TryParse(part.Identifier, out var seg))
                    return seg;                
            }

            return Option.none<SegmentedIdentity>();                
        }

        /// <summary>
        /// Divines the bit-width of a specified type, if possible
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static TypeWidth width(Type t)
        {
            if(t.IsVector())
                return VectorType.width(t);
            else if(t.IsBlocked())
                return BK.width(t);
            if(t.IsNumeric())
                return t.NumericWidth();
            else if(t == typeof(bit))
                return TypeWidth.W1;
            else
                return TypeWidth.None;
        }

        public static string identify(ParameterInfo p)
        {
            if(!p.IsParametric())
            {
                var id = Identity.identify(p.ParameterType.EffectiveType());
                if(!id.IsEmpty)
                    return text.concat(id.Identifier, p.ClassifyVariance().Format());                
            }
            return string.Empty;                        
        }

        /// <summary>
        /// Extracts an index-identified operation identity part from an operation identity
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="partidx">The 0-based part index</param>
        static Option<IdentityPart> part(OpIdentity src, int partidx)
        {
            var parts = Identify.Parts(src).ToArray();
            if(partidx <= parts.Length - 1)
                return parts[partidx];
            else
                return Option.none<IdentityPart>();
        }


        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        public static IEnumerable<ClosedApiOp> close(GenericApiOp op)
             => from k in op.Kinds
                let pt = k.SystemType().ToOption() where pt.IsSome()
                let id = Identity.identify(op.Method, k) where !id.IsEmpty
                select ClosedApiOp.Define(op.Host, id, k, op.Method.MakeGenericMethod(pt.Value)); 

        static string name(MethodInfo m)
            => OpIdentities.name(m);

        static OpIdentity constructed(MethodInfo src)
        {
            src.RequireConstructed();

            var id = string.Empty;
            
            id += name(src);
            id += IDI.PartSep;   

            id += IDI.Generic;                           
            id += src.FormatTypeArgIdentity();
            id += src.FormatParameterIdentity();
            return Identify.Op(id);
        }        

        static IEnumerable<string> ParameterIdentities(this MethodInfo method)
        {
            var args = method.GetParameters();
            var argtypes = method.ParameterTypes(true).ToArray();
            for(var i=0; i<argtypes.Length; i++)
            {                                
                var argtext = identify(args[i]);
                if(argtext.IsNotBlank())
                    yield return argtext;
            }
        }

        static OpIdentity nongeneric(MethodInfo src)
        {
            src.RequireNonGeneric();
            var id = string.Empty;
            
            id += name(src);
            id += IDI.PartSep;
            id += formatargs(IDI.ValueArgsOpen, IDI.ValueArgsClose, IDI.ArgSep, src.ParameterIdentities());

            return Identify.Op(id);
        }        

        static IEnumerable<string> TypeArgIdentities(this MethodInfo src)
            => src.GenericArguments().Select(targ => identify(targ).Identifier);

        static string formatargs(char open, char close, char sep, IEnumerable<string> args)
            => text.concat(open, string.Join(sep,args), close);

        static string FormatParameterIdentity(this MethodInfo src)
            => formatargs(IDI.ValueArgsOpen, IDI.ValueArgsClose, IDI.ArgSep, ParameterIdentities(src));

        static string FormatTypeArgIdentity(this MethodInfo src)
            => formatargs(IDI.TypeArgsOpen, IDI.TypeArgsClose, IDI.ArgSep, TypeArgIdentities(src));                
    }
}