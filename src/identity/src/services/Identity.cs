//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    public static partial class Identity
    {
        /// <summary>
        /// Assigns host-independent api member identity to a generic method; if the
        /// source method is nongeneric, returns <see cref='GenericOpIdentity.Empty' />
        /// </summary>
        /// <param name="src">The source method</param>
        public static GenericOpIdentity GenericIdentity(MethodInfo src)
        {
            if(!src.IsGenericMethod)
                return GenericOpIdentity.Empty;

            var id = Identify.ApiMemberName(src);
            id += IDI.PartSep;
            id += IDI.Generic;

            var args = src.GetParameters();
            var argtypes = src.ParameterTypes(true);
            var last = string.Empty;
            for(var i=0; i<argtypes.Length; i++)
            {
                var argtype = argtypes[i];
                if(i != 0 && last.IsNotBlank())
                    id += IDI.PartSep;

                last = EmptyString;

                if(args[i].IsParametric())
                    last = Identity.ParameterTypeIdentity(args[i]);
                else if(argtype.IsOpenGeneric())
                {
                    if(argtype.IsVector())
                        last = text.concat(IDI.Vector, BitWidth(argtype).FormatValue());
                    else if(argtype.IsBlocked())
                        last = text.concat(IDI.Block, BitWidth(argtype).FormatValue());
                    else if(SpanTypes.IsSystemSpan(argtype))
                        last = SpanTypes.kind(argtype).Format();
                }

                id += last;
            }

            return GenericOpIdentity.Define(id);
        }

        /// <summary>
        /// Assigns host-independent identity to an api member
        /// </summary>
        /// <param name="src">The source method</param>
        public static OpIdentity identify(MethodInfo src)
        {
            if(src.IsOpenGeneric())
                return GenericIdentity(src).Generalize();
            else if(src.IsConstructedGenericMethod)
                return ConstructedIdentity(src);
            else
                return NonGenericIdentity(src);
        }

        /// <summary>
        /// Assigns identity to a delegate
        /// </summary>
        /// <param name="src">The source delegate</param>
        public static OpIdentity identify(Delegate src)
            => identify(src.Method);

        /// <summary>
        /// Assigns identity to a type
        /// </summary>
        /// <param name="src">The source type</param>
        public static TypeIdentity identify(Type src)
            => TypeIdentityDiviner.IdentityProvider(src).Identify(src);

        static OpIdentity identify(MethodInfo src, NumericKind k)
        {
            var t = k.SystemType();
            if(src.IsOpenGeneric() && t.IsNonEmpty())
                return identify(src.MakeGenericMethod(t));
            else
                return identify(src);
        }

        /// <summary>
        /// Divines the bit-width of a specified type, if possible
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static TypeWidth BitWidth(Type t)
            => Widths.divine(t);


        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        public static IEnumerable<ClosedApiMethod> Closures(GenericApiMethod op)
             => from k in op.Kinds
                let pt = k.SystemType().ToOption() where pt.IsSome()
                let id = Identity.identify(op.Method, k) where !id.IsEmpty
                select new ClosedApiMethod(op.Host, id, k, op.Method.MakeGenericMethod(pt.Value));


        /// <summary>
        /// Assigns host-independent api identity to a constructed generic method
        /// </summary>
        /// <param name="src">The constructed method</param>
        static OpIdentity ConstructedIdentity(MethodInfo src)
        {
            RequireConstructed(src);

            var id = EmptyString;
            id += Identify.ApiMemberName(src);
            id += IDI.PartSep;
            id += IDI.Generic;
            id += TypeArgIdentity(src);
            id += ValueParamIdentity(src);
            return OpIdentityParser.parse(id);
        }

        /// <summary>
        /// Assigns host-independent api member identity to a nongeneric method
        /// </summary>
        /// <param name="src">The source method</param>
        static OpIdentity NonGenericIdentity(MethodInfo src)
        {
            RequireNonGeneric(src);

            var id = EmptyString;
            id += Identify.ApiMemberName(src);
            id += IDI.PartSep;
            id += SequenceIdentity(IDI.ArgsOpen, IDI.ArgsClose, IDI.ArgSep, ValueParamIdentities(src));

            return OpIdentityParser.parse(id);
        }

        /// <summary>
        /// Assigns identity a nongeneric value parameter
        /// </summary>
        /// <param name="src">The source parameter</param>
        public static string ParameterTypeIdentity(ParameterInfo src)
        {
            if(!src.IsParametric())
            {
                var id = src.ParameterType.IsEnum
                    ? identify(src.ParameterType)
                    : identify(src.ParameterType.EffectiveType());

                if(!id.IsEmpty)
                    return text.concat(id.Identifier, src.RefKind().Format());
            }

            return EmptyString;
        }


        /// <summary>
        /// Assigns identity to each value parameter (not to be confused with type parametricity) declared by a method
        /// </summary>
        /// <param name="src">The source method</param>
        static IEnumerable<string> ValueParamIdentities(MethodInfo src)
        {
            var args = src.GetParameters();
            var argtypes = src.ParameterTypes(true);
            for(var i=0; i<argtypes.Length; i++)
            {
                var argtext = Identity.ParameterTypeIdentity(args[i]);
                if(argtext.IsNotBlank())
                    yield return argtext;
            }
        }

        /// <summary>
        /// Assigns identity to each type argument supplied to close a generic method
        /// </summary>
        /// <param name="src">The constructed generic method</param>
        static IEnumerable<string> TypeArgIdentities(MethodInfo src)
            => src.GenericArguments().Select(arg => Identity.identify(arg).Identifier);

        /// <summary>
        /// Assigns aggregate identity to the type argument sequence that closes a generic method
        /// </summary>
        /// <param name="src">The constructed generic method</param>
        static string TypeArgIdentity(MethodInfo src)
            => SequenceIdentity(IDI.TypeArgsOpen, IDI.TypeArgsClose, IDI.ArgSep, TypeArgIdentities(src));

        /// <summary>
        /// Assigns aggregate identity to a method's value parameter sequence
        /// </summary>
        /// <param name="src">The source method</param>
        static string ValueParamIdentity(MethodInfo src)
            => SequenceIdentity(IDI.ArgsOpen, IDI.ArgsClose, IDI.ArgSep, ValueParamIdentities(src));

        /// <summary>
        /// Assigns aggregate identity to an identity sequence
        /// </summary>
        /// <param name="open">The left fence</param>
        /// <param name="close">The right fence</param>
        /// <param name="sep">The sequence element delimiter</param>
        /// <param name="src">The source sequence</param>
        static string SequenceIdentity(char open, char close, char sep, IEnumerable<string> src)
            => text.concat(open, string.Join(sep,src), close);

         /// <summary>
        /// Raises an error if the source method is any flavor of generic
        /// </summary>
        /// <param name="src">The method to examine</param>
        static void RequireNonGeneric(MethodInfo src)
        {
            if(src.IsGenericMethod || src.IsConstructedGenericMethod || src.IsGenericMethodDefinition)
                throw AppErrors.GenericMethod(src);
        }

        /// <summary>
        /// Raises an error if the source method is not a constructed generic method
        /// </summary>
        /// <param name="src">The method to examine</param>
        static void RequireConstructed(MethodInfo src)
        {
            if(!src.IsConstructedGenericMethod)
                throw AppErrors.NonGenericMethod(src);
        }
    }
}