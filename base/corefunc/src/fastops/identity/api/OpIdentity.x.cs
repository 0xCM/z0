//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.ComponentModel;

    using static zfunc;

    public static class OpIdentityX
    {
        /// <summary>
        /// Identifies the method
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity Identify(this MethodInfo m)
            => Identity.identify(m);

        /// <summary>
        /// Gets the name of a method to which to Op attribute is applied
        /// </summary>
        /// <param name="m">The source method</param>
        public static string OpName(this MethodInfo m)
            => Identity.name(m);

        /// <summary>
        /// Identifies the delegate
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity Identify(this Delegate m)
            => Identity.identify(m);

        /// <summary>
        /// Defines the identity of a generic method
        /// </summary>
        /// <param name="src">The source method</param>
        public static OpIdentity GenericIdentity(this MethodInfo src)
            => Identity.generic(src);

        /// <summary>
        /// Transforms a nonspecific identity part into a specialized scalar part, if the source part is indeed a scalar identity
        /// </summary>
        /// <param name="part">The source part</param>
        public static Option<ScalarIdentity> Scalar(this IdentityPart part)
            => Identity.scalar(part);

        /// <summary>
        /// Extracts an index-identified operation identity part from an operation identity
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="partidx">The 0-based part index</param>
        public static Option<IdentityPart> Part(this OpIdentity src, int partidx)
            => Identity.part(src,partidx);

        /// <summary>
        /// Transforms a nonspecific identity part into a specialized segment part, if the source part is indeed a segment identity
        /// </summary>
        /// <param name="part">The source part</param>
        public static Option<SegmentedIdentity> Segment(this IdentityPart part)
            => Identity.segment(part);

        /// <summary>
        /// Extracts an index-identified segmented identity part from an operation identity
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="partidx">The 0-based part index</param>
        public static Option<SegmentedIdentity> Segment(this OpIdentity src, int partidx)
            => Identity.segment(src,partidx);

        /// <summary>
        /// Extracts an 8-bit immediate value from an identity if it contains an immediate suffix; otherwise, returns none
        /// </summary>
        /// <param name="src">The source identity</param>
        public static Option<byte> Imm8(this OpIdentity src)            
            => Identity.imm8(src);

        /// <summary>        
        /// Clears an attached immediate suffix from an identity, if any
        /// </summary>
        /// <param name="src">The source identity</param>
        public static OpIdentity WithoutImm8(this OpIdentity src)
            => Identity.imm8Remove(src);
    
        /// <summary>        
        /// Attaches an immediate suffix to an identity, removing an existing immediate suffix if necessary
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="immval">The immediate value to attach</param>
        public static OpIdentity WithImm8(this OpIdentity src, byte immval)
            => Identity.imm8Add(src,immval);


        /// <summary>
        /// Derives a signature from reflected method metadata
        /// </summary>
        /// <param name="src">The source method</param>
        [MethodImpl(Inline)]
        public static MethodSig Signature(this MethodInfo src)
            => MethodSig.Define(src);

        /// <summary>
        /// Determines whether a method defines a unary function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsUnaryFunc(this MethodInfo m)
            => FunctionType.unary(m);

        /// <summary>
        /// Determines whether a method defines a binary function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBinaryFunc(this MethodInfo m)
            => FunctionType.binary(m);

        /// <summary>
        /// Determines whether a method defines a binary function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsTernaryFunc(this MethodInfo m)
            => FunctionType.ternary(m);

        /// <summary>
        /// Determines whether a method is a unary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsUnaryOp(this MethodInfo m)
            => FunctionType.unaryop(m);

        /// <summary>
        /// Determines whether a method is a binary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBinaryOp(this MethodInfo m)
            => FunctionType.binaryop(m);

        /// <summary>
        /// Determines whether a method is a ternary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsTernaryOp(this MethodInfo m)
            => FunctionType.ternaryop(m);

        /// <summary>
        /// Determines whether a method is an action
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsAction(this MethodInfo m)
            => m.ReturnType == typeof(void);

        /// <summary>
        /// Determines whether a method is a function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsFunction(this MethodInfo m)
            => FunctionType.function(m);

        /// <summary>
        /// Determines whether a method is an emitter, i.e. a method that returns a value but accepts no input
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsEmitter(this MethodInfo m)
            => FunctionType.emitter(m);

        /// <summary>
        /// Determines whether a method defines an operator over a (common) domain
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsOperator(this MethodInfo m)
            => FunctionType.isoperator(m);

        /// <summary>
        /// Determines whether a method accepts and/or returns at least one memory block parameter
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBlocked(this MethodInfo m)
            => FunctionType.blocked(m);        

        /// <summary>
        /// Determines whether a method is segmentation-centric
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsSegmented(this MethodInfo m)
            => m.IsVectorized() || m.IsBlocked();

        /// <summary>
        /// Determines whether a method is classified as a span op
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsSpanOp(this MethodInfo m)
            => FunctionType.spanned(m);

        /// <summary>
        /// Determines whether a method defines a predicate that returns a bit or bool value
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsPredicate(this MethodInfo m)        
            => FunctionType.predicate(m);

        /// <summary>
        /// Determines whether a method is a primal shift operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsPrimalShift(this MethodInfo m)        
            => FunctionType.primalshift(m);

        /// <summary>
        /// Determines whether a parameters is an immediate
        /// </summary>
        /// <param name="param">The parameter to examine</param>
        public static bool IsImmediate(this ParameterInfo param)
            => FunctionType.immneeds(param);

        /// <summary>
        /// Selects unary operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> UnaryOps(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.IsUnaryOp());

        /// <summary>
        /// Selects binary operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> BinaryOps(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.IsBinaryOp());

        /// <summary>
        /// Selects ternary operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> TernaryOps(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.IsTernaryOp());             

        /// <summary>
        /// Describes a method's type parameters, if any
        /// </summary>
        /// <param name="method">The method to examine</param>
        public static TypeParameter[] TypeParameters(this MethodInfo method)
            => method.GenericParameters(false).Mapi((i,t) => TypeParameter.Define(t.DisplayName(), i, t.IsGenericType));

        /// <summary>
        /// Retrives the primal kind of the first type parameter, if any
        /// </summary>
        /// <param name="method">The method to test</param>
        /// <param name="n">The generic parameter selector</param>
        [MethodImpl(Inline)]
        public static NumericKind TypeParameterKind(this MethodInfo method, N1 n)
            => (method.IsGenericMethod ? method.GetGenericArguments() : array<Type>()).FirstOrDefault()?.NumericKind() ?? Z0.NumericKind.None;

        [MethodImpl(Inline)]
        public static ParamVariance Variance(this ParameterInfo src)        
            => src.IsIn 
            ? Z0.ParamVariance.In  : src.IsOut 
            ? Z0.ParamVariance.Out : src.ParameterType.IsByRef 
            ? Z0.ParamVariance.Ref : Z0.ParamVariance.None;

        [MethodImpl(Inline)]
        public static bool IsSome(this ParamVariance src)        
            => src != ParamVariance.None;

        [MethodImpl(Inline)]
        public static bool IsSome<E>(this E src)        
            where E : unmanaged, Enum            
                => !Enums.zero<E>().Equals(src);

        [MethodImpl(Inline)]
        public static bool IsNone<E>(this E src)        
            where E : unmanaged, Enum            
                => Enums.zero<E>().Equals(src);

        [MethodImpl(Inline)]
        public static T MapSomeOrElse<E,T>(this E kind, Func<E,T> ifSome, Func<T> ifNone)
            where E : unmanaged, Enum
                => kind.IsSome() ? ifSome(kind) : ifNone();

        public static string Keyword(this ParamVariance src)        
            => src switch{
                ParamVariance.In => "in",
                ParamVariance.Out => "out",
                ParamVariance.Ref => "ref",    
                _ => string.Empty
            };

        static string FormatParam(this Pair<ParameterInfo,int> src)
        {
            var t = src.A.ParameterType;
            if(t.IsSegmented())
            {
                var typewidth = (int)t.Width();
                var segkind = t.SegmentType().Require().NumericKind();
                var segwidth = segkind.Width();
                var indicator = segkind.Indicator().Format();
                return $"{typewidth}x{segwidth}{indicator}".PadLeft(7);
            }
            else
                return $"{src.B}{t.NumericKind().Indicator().Format()}";
        }

        static string Format(this IEnumerable<Pair<ParameterInfo,int>> src)
        {
            var pairs = src.ToArray();
            if(pairs.Length == 1)
                return pairs[0].FormatParam();

            var dst = text();
            for(var i=0; i<pairs.Length; i++)
            {
                var pair = pairs[i];
                dst.Append(pairs[i].FormatParam());
                if(i != pairs.Length - 1)
                {
                    dst.Append(AsciSym.Comma);
                    dst.Append(AsciSym.Space);
                }
            }
            return parenthetical(dst.ToString());            
        }

        /// <summary>
        /// Constructs a display name for a method
        /// </summary>
        /// <param name="src">The source method</param>
        public static string DisplayName(this MethodInfo src)
        {
            static string GenericMemberDisplayName(string memberName, IReadOnlyList<Type> args)
            {                
                var argFmt = args.Count != 0 ? args.Select(t => t.DisplayName()).Concat(", ") : string.Empty;            
                var typeName = memberName.Replace($"`{args.Count}", string.Empty);
                return typeName + (args.Count != 0 ? angled(argFmt) : string.Empty);
            }

            var attrib = src.GetCustomAttribute<DisplayNameAttribute>();
            if(attrib != null)
                return attrib.DisplayName;
            var slots = src.GenericParameters(false);
            return slots.Length == 0 ? src.Name : GenericMemberDisplayName(src.Name, slots);            
        }

        /// <summary>
        /// Constructs a display name for a generic method specialized for a specified type
        /// </summary>
        /// <typeparam name="T">The relative type</typeparam>
        /// <param name="src">The source method</param> 
        [MethodImpl(Inline)]
        public static string SpecializeName<T>(this MethodBase src)
            => src.DeclaringType.DisplayName() + "/" + src.Name + "<" + typeof(T).DisplayName() + ">";
                
        /// <summary>
        /// Constructs a display name for a method
        /// </summary>
        /// <param name="src">The source method</param>
        [MethodImpl(Inline)]
        public static string FullDisplayName(this MethodInfo src)
            => $"{src.DeclaringType.DisplayName()}/{src.DisplayName()}";
    }
}
