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

    using static Root;

    public static partial class Identity
    {
        /// <summary>
        /// Defines the identity of a generic method
        /// </summary>
        /// <param name="src">The source method</param>
        public static GenericOpIdentity generic(MethodInfo src)            
        {
            if(!src.IsGenericMethod)
                return GenericOpIdentity.Empty;
                        
            var id = name(src);
            id += IDI.PartSep; 
            id += IDI.Generic;

            var args = src.GetParameters();
            var argtypes = src.ParameterTypes(true).ToArray();
            var last = string.Empty;
            for(var i=0; i<argtypes.Length; i++)
            {
                var argtype = argtypes[i];
                if(i != 0 && last.IsNotBlank())
                    id += IDI.PartSep;

                last = string.Empty;                    

                if(args[i].IsParametric())
                    last = Identity.identify(args[i]);
                else if(argtype.IsOpenGeneric())
                {
                    if(argtype.IsVector())
                        last = text.concat(IDI.Vector, width(argtype).Format());
                    else if(argtype.IsBlocked())
                        last = text.concat(IDI.Block, width(argtype).Format());
                    else if(argtype.IsSpan())
                        last = argtype.SpanKind().Format();
                }
                
                id += last;
            }

            return GenericOpIdentity.Define(id);
        }

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

        public static OpIdentity identify(MethodInfo src, NumericKind k)
        {
            var t = k.SystemType();
            if(src.IsOpenGeneric() && t.IsSome())
                return identify(src.MakeGenericMethod(t));
            else
                return identify(src);
        }
        
        /// <summary>
        /// Identifies the delegate
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity identify(Delegate m)
            => identify(m.Method);

        [MethodImpl(Inline)]
        public static TypeIdentity identify(Type t)
            => provider(t).DefineIdentity(t);

        /// <summary>
        /// Extracts an index-identified segmented identity part from an operation identity
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="partidx">The 0-based part index</param>
        public static Option<SegmentedIdentity> segment(OpIdentity src, int partidx)
            => from p in part(src, partidx)
                from s in segmented(p)
                select s;

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
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        public static IEnumerable<ClosedApiOp> close(GenericApiOp op)
             => from k in op.Kinds
                let pt = k.SystemType().ToOption() where pt.IsSome()
                let id = Identity.identify(op.Method, k) where !id.IsEmpty
                select ClosedApiOp.Define(op.Host, id, k, op.Method.MakeGenericMethod(pt.Value)); 
    }

    public static class IdentityExtensions
    {        
        /// <summary>
        /// Identifies the method
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity Identify(this MethodInfo m)
            => Identity.identify(m);

        /// <summary>
        /// Identifies the delegate
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity Identify(this Delegate m)
            => Identity.identify(m);

        /// <summary>
        /// Extracts an index-identified segmented identity part from an operation identity
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="partidx">The 0-based part index</param>
        public static Option<SegmentedIdentity> Segment(this OpIdentity src, int partidx)
            => Identity.segment(src,partidx); 

        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        public static IEnumerable<ClosedApiOp> Close(this GenericApiOp op)
             => Identity.close(op);

        [MethodImpl(Inline)]
        public static IApiCollector OpCollector(this IContext context)
            => ApiOpCollector.Create(context);
    }    
}