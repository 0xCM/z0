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
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    public static class OpApiX
    {
        [MethodImpl(Inline)]
        public static bool IsSigned(this PrimalKind k)
            => (k & PrimalKind.Signed) != 0;

        [MethodImpl(Inline)]
        public static bool IsUnsigned(this PrimalKind k)
            => (k & PrimalKind.Unsigned) != 0;

        [MethodImpl(Inline)]
        public static bool IsFractional(this PrimalKind k)
            => (k & PrimalKind.Fractional) != 0;

        [MethodImpl(Inline)]
        public static bool IsSome(this PrimalKind k)
            => k != PrimalKind.None;

        /// <summary>
        /// Specifies the keyword used to designate a kind-identified primal type, if possible; throws an exception otherwise
        /// </summary>
        [MethodImpl(Inline)]
        public static string Keyword(this PrimalKind k)
            => Classified.keyword(k);

        /// <summary>
        /// Returns a kind-identified system type if possible; throws an exception otherwise
        /// </summary>
        /// <param name="k">The identifying kind</param>
        [MethodImpl(Inline)]
        public static Type ToPrimalType(this PrimalKind k)
            => PrimalType.fromkind(k);

        /// <summary>
        /// Returns the keyword used to designate a kind-identified primal type, if possible; throws an exception otherwise
        /// </summary>
        /// <param name="k">The identifying kind</param>
        [MethodImpl(Inline)]
        public static string TypeKeyword(this PrimalKind k)
            => Classified.keyword(k);

        /// <summary>
        /// Specifies the bit-width of a classified primitive
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static int BitWidth(this PrimalKind k)
            => Classified.width(k);

        /// <summary>
        /// Specifies the bit-width of a classified cpu vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static int BitWidth(this VectorKind k)
            => Classified.width(k);

        /// <summary>
        /// Determines the kind identifier
        /// </summary>
        /// <param name="k">The primal classifier</param>
        [MethodImpl(Inline)]
        public static PrimalId Id(this PrimalKind kind)
            => Classified.id(kind);

        /// <summary>
        /// Determines a sub-classification c := {'u' | 'i' | 'f'} according to whether a classified primal type
        /// is unsigned integral, signed integral or floating-point
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static char Indicator(this PrimalKind k)
            => Classified.indicator(k);

        /// <summary>
        /// Determines whether a specified kind is included within a classification
        /// </summary>
        /// <param name="k">The classification</param>
        /// <param name="match">The kind to check</param>
        [MethodImpl(Inline)]
        public static bit Is(this PrimalKind k, PrimalKind match)        
            => (k & match) != 0;


        /// <summary>
        /// Selects the distinct primal kinds represented by a classifier
        /// </summary>
        /// <param name="k">The primal classifier</param>
        public static IEnumerable<PrimalKind> DistinctKinds(this PrimalKind k)       
        {
            if(k.Is(PrimalKind.U8))
                yield return PrimalKind.U8;

            if(k.Is(PrimalKind.I8))
                yield return PrimalKind.I8;

            if(k.Is(PrimalKind.U16))
                yield return PrimalKind.U16;

            if(k.Is(PrimalKind.I16))
                yield return PrimalKind.I16;

            if(k.Is(PrimalKind.U32))
                yield return PrimalKind.U32;

            if(k.Is(PrimalKind.I32))
                yield return PrimalKind.I32;

            if(k.Is(PrimalKind.U64))
                yield return PrimalKind.U64;

            if(k.Is(PrimalKind.I64))
                yield return PrimalKind.I64;

            if(k.Is(PrimalKind.F32))
                yield return PrimalKind.F32;

            if(k.Is(PrimalKind.F64))
                yield return PrimalKind.F64;
        }

        public static PrimalKind ToKind(this PrimalId id)
            => Classified.kind(id);

        /// <summary>
        /// Computes the primal types identified by a specified kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        public static IEnumerable<Type> PrimalTypes(this PrimalKind k)
            => k.DistinctKinds().Select(x => x.ToPrimalType());         

        /// <summary>
        /// Computes the primal identifies of the classified kinds
        /// </summary>
        /// <param name="k"></param>
        public static IEnumerable<PrimalId> Identities(this PrimalKind k)       
        {
            if(k.Is(PrimalKind.U8))
                yield return PrimalId.U8;

            if(k.Is(PrimalKind.I8))
                yield return PrimalId.I8;

            if(k.Is(PrimalKind.U16))
                yield return PrimalId.U16;

            if(k.Is(PrimalKind.I16))
                yield return PrimalId.I16;

            if(k.Is(PrimalKind.U32))
                yield return PrimalId.U32;

            if(k.Is(PrimalKind.I32))
                yield return PrimalId.I32;

            if(k.Is(PrimalKind.U64))
                yield return PrimalId.U64;

            if(k.Is(PrimalKind.I64))
                yield return PrimalId.I64;

            if(k.Is(PrimalKind.F32))
                yield return PrimalId.F32;

            if(k.Is(PrimalKind.F64))
                yield return PrimalId.F64;
        }

        [MethodImpl(Inline)]
        public static bool IsSome(this VectorKind k)
            => k != VectorKind.None;

        [MethodImpl(Inline)]
        public static bool IsSome(this BlockKind k)
            => k != BlockKind.None;

        [MethodImpl(Inline)]
        public static VectorWidth Width(this VectorKind kind)
            => (VectorWidth)((ushort)kind);

        [MethodImpl(Inline)]
        public static BlockWidth Width(this BlockKind kind)
            => (BlockWidth)((ushort)kind);

        /// <summary>
        /// Derives a signature from reflected method metadata
        /// </summary>
        /// <param name="src">The source method</param>
        [MethodImpl(Inline)]
        public static MethodSig Signature(this MethodInfo src)
            => MethodSig.Define(src);

        /// <summary>
        /// Derives an operation descriptor from reflected method metadata and supplied type argments, if applicable
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="args">The arguments over which to close the method, if generic</param>
        [MethodImpl(Inline)]
        public static FastOp FastOp(this MethodInfo src)
            => Z0.FastOp.Define(src);

        [MethodImpl(Inline)]
        public static FastOp FastOp(this MethodInfo src, Moniker m, Span<byte> buffer)
            => Z0.FastOp.Define(src, m, buffer);

        /// <summary>
        /// Determines the primal kind of a type, possibly none
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static PrimalKind Kind(this Type t)
            => PrimalType.kind(t);

        [MethodImpl(Inline)]
        public static bool IsPrimal(this Type t)
            => PrimalType.kind(t) != PrimalKind.None;

        /// <summary>
        /// Determines whether a type is an intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsVector(this Type t)
            => VectorType.test(t);

        /// <summary>
        /// Determines whether a type is an intrinsic vector of specified width
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsVector(this Type t, int? width)        
            => VectorType.vector(t,width);

        /// <summary>
        /// Returns true if the source type is intrinsic or blocked
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSegmented(this Type t)
            => Classified.segmented(t);

        /// <summary>
        /// If the source type is primal or intrinsic, returns the bit-width; otherwise, returns 0
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static int BitWidth(this Type t)
            => Classified.width(t);

        /// <summary>
        /// If the source type is primal or intrinsic, returns the bit-width; otherwise, returns 0
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static FixedWidth SegmentedWidth(this Type t)
            => (FixedWidth)Classified.width(t);

        /// <summary>
        /// Determines whether a method is an action
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsAction(this MethodInfo m)
            => m.ReturnType == typeof(void);

        /// <summary>
        /// Determines whether a method is an action with specified arity
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="arity">The arity to match</param>
        public static bool IsAction(this MethodInfo m, int arity)
            => m.IsAction() && m.Arity() == arity;

        /// <summary>
        /// Determines whether a method is a function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsFunction(this MethodInfo m)
            => FunctionType.function(m);

        /// <summary>
        /// Determines whether a method is a function with specified arity
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="arity">The arith to match</param>
        public static bool IsFunction(this MethodInfo m, int arity)
            => FunctionType.function(m,arity);

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
        /// Determines whether a method defines an operator over a domain of specified kind
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsOperator(this MethodInfo m, PrimalKind kind)
            => FunctionType.isoperator(m, kind);

        /// <summary>
        /// Determines whether a method is homogenous with respect to input/output values
        /// </summary>
        /// <param name="src">The source stream</param>
        public static bool IsHomogenous(this MethodInfo m)
            => FunctionType.homogenous(m);

        /// <summary>
        /// Determines whether a method accepts natural number type values as arguments
        /// </summary>
        /// <param name="m">The method to test</param>
        public static bool AcceptsNatValues(this MethodInfo m)
            => TypeNatType.accepts(m);

        /// <summary>
        /// Determines whether a method has intrinsic parameters or return type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsVectorized(this MethodInfo m, bool total = false)        
            => FunctionType.vectorized(m,total);

        /// <summary>
        /// Determines whether a method defines a vectorized operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsVectorOp(this MethodInfo m)        
            => FunctionType.vectorized(m) && FunctionType.isoperator(m);

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
            => FunctionType.immediate(param);

        /// <summary>
        /// Determines whether a method defines a parameter that requires an immediate
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool RequiresImmediate(this MethodInfo m)        
            => FunctionType.immrequired(m);

        /// <summary>
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsVectorized(this MethodInfo m, int? width, bool total)        
            => FunctionType.vectorized(m,width,total);

        public static bool IsUnaryImmVectorOp(this MethodInfo method)
        {
            var parameters = method.GetParameters().ToArray();
            return parameters.Length == 2 
                && parameters[0].ParameterType.IsVector() 
                && parameters[1].IsImmediate();
        }

        public static bool IsBinaryImmVectorOp(this MethodInfo method)
        {
            var parameters = method.GetParameters().ToArray();
            return parameters.Length == 3 
                && parameters[0].ParameterType.IsVector() 
                && parameters[1].ParameterType.IsVector() 
                && parameters[2].IsImmediate();
        }

        /// <summary>
        /// Determines whether a type is blocked memory store
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsBlocked(this Type t)
            => BlockedType.test(t);

        /// <summary>
        /// Selects the parameters for a method, if any, that accept an intrinsic vector
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static IEnumerable<ParameterInfo> VectorParams(this MethodInfo m, int? width = null)
            => m.GetParameters().Where(p => p.ParameterType.IsVector(width));
            
        /// <summary>
        /// Determines the bit-width of each intrinsic or primal method parameter
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static IEnumerable<Pair<ParameterInfo,int>> InputWidths(this MethodInfo m)
            => FunctionType.inputwidths(m);

        /// <summary>
        /// Determines the bit-width of an intrinsic or primal return type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static Pair<ParameterInfo,int> OutputWidth(this MethodInfo m)
            => FunctionType.outputwidth(m);

        /// <summary>
        /// Returns the number of bytes occupied by a type if it is primal and 0 otherwise
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static int Size(this Type t)
            => Classified.size(t);

        /// <summary>
        /// Determines whether all operands are primal
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool HasPrimalOperands(this MethodInfo m)
            => FunctionType.primaloperands(m);

        /// <summary>
        /// Determines whether all operands are of the same type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool HasHomogenousOperands(this MethodInfo m)
            => FunctionType.homogenousoperands(m);

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
        /// Determines whether a method is a unary operator over a domain of specified kind
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsUnaryOp(this MethodInfo m, PrimalKind k)
            => FunctionType.unaryop(m,k);

        /// <summary>
        /// Determines whether a method is a binary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBinaryOp(this MethodInfo m)
            => FunctionType.binaryop(m);

        /// <summary>
        /// Determines whether a method is a binary operator over a domain of specified kind
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBinaryOp(this MethodInfo m, PrimalKind k)
            => FunctionType.binaryop(m,k);

        /// <summary>
        /// Determines whether a method is a ternary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsTernaryOp(this MethodInfo m)
            => FunctionType.ternaryop(m);

        /// <summary>
        /// Determines whether a method is a ternary operator over a domain of specified kind
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsTernaryOp(this MethodInfo m, PrimalKind k)
            => FunctionType.ternaryop(m,k);

        /// <summary>
        /// Selects operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> Operators(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.IsOperator());

        /// <summary>
        /// Selects unary operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> UnaryOps(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.IsUnaryOp());

        /// <summary>
        /// Selects kind-specific unary operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> UnaryOps(this IEnumerable<MethodInfo> src, PrimalKind k)
            => src.Where(x => x.IsUnaryOp(k));

        /// <summary>
        /// Selects binary operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> BinaryOps(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.IsBinaryOp());

        /// <summary>
        /// Selects kind-specific binary operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> BinaryOps(this IEnumerable<MethodInfo> src, PrimalKind k)
            => src.Where(x => x.IsBinaryOp(k));

        /// <summary>
        /// Selects ternary operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> TernaryOps(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.IsTernaryOp());

        /// <summary>
        /// Selects kind-specific ternary operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> TernaryOps(this IEnumerable<MethodInfo> src, PrimalKind k)
            => src.Where(x => x.IsTernaryOp(k));

        /// <summary>
        /// Selects methods from a stream that accept and/or return intrinsic vectors
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> Vectorized(this IEnumerable<MethodInfo> src, int? width = null, bool total = false)
            => src.Where(m => m.IsVectorized(width,total));

        /// <summary>
        /// Selects methods from a stream that accept and/or return intrinsic vectors
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> Vectorized(this IEnumerable<MethodInfo> src, IEnumerable<int> widths, bool total = false)
        {
            foreach(var w in widths)
            foreach(var m in src.Vectorized(w,total))
                yield return m;
        }            

        /// <summary>
        /// Selects methods from a stream that accept and/or return intrinsic vectors
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> Vectorized(this IEnumerable<MethodInfo> src, Pair<int> widths, bool total = false)
            => src.Vectorized(items(widths.A, widths.B), total);

        /// <summary>
        /// Selects methods from a stream that neither accept nor return any instrinsic vector parameters
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> NonVectorized(this IEnumerable<MethodInfo> src)
            => src.Where(m => !m.IsVectorized());

        /// <summary>
        /// Selects methods from a stream that accept and/or return at least one memory block  parameter
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> Blocked(this IEnumerable<MethodInfo> src)
            => src.Where(m => m.IsBlocked());

        /// <summary>
        /// Selects unblocked operations from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> Unblocked(this IEnumerable<MethodInfo> src)
            => src.Where(x => !x.IsBlocked());

        /// <summary>
        /// Selects the methods that define parameters that require immediate values
        /// </summary>
        /// <param name="src">The methods to examine</param>
        /// <param name="required">Whether an immediate is required</param>
        public static IEnumerable<MethodInfo> RequiresImmediate(this IEnumerable<MethodInfo> src)
            => src.Where(RequiresImmediate);

        /// <summary>
        /// Returns an identified unary operator if it exists
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="name">The name of the operator</param>
        /// <param name="k">The primal kind over which the operator is defined</param>
        public static Option<MethodInfo> UnaryOp(this Type t, string name, PrimalKind k)
            => t.DeclaredMethods().WithName(name).UnaryOps(k).FirstOrDefault();

        /// <summary>
        /// Returns an identified binary operator if it exists
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="name">The name of the operator</param>
        /// <param name="k">The primal kind over which the operator is defined</param>
        public static Option<MethodInfo> BinaryOp(this Type t, string name, PrimalKind k)
            => t.DeclaredMethods().WithName(name).BinaryOps(k).FirstOrDefault();

        /// <summary>
        /// Returns an identified binary operator if it exists
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="name">The name of the operator</param>
        /// <param name="k">The primal kind over which the operator is defined</param>
        public static Option<MethodInfo> TernaryOp(this Type t, string name, PrimalKind k)
            => t.DeclaredMethods().WithName(name).TernaryOps(k).FirstOrDefault();

        /// <summary>
        /// Selects the binary literals declared by a type that are of a specified parametric primal type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <typeparam name="T">The primal literal type</typeparam>
        public static IEnumerable<BinaryLiteral<T>> BinaryLiterals<T>(this Type src)
            where T : unmanaged
            => from f in src.Literals()
                where f.FieldType == typeof(T) && f.Attributed<BinaryLiteralAttribute>()
               let a = f.CustomAttribute<BinaryLiteralAttribute>().Require()
                select BinaryLiteral.Define(f.Name, (T)f.GetValue(null), a.Text);

        /// <summary>
        /// Selects the binary literals declared by a type
        /// </summary>
        /// <param name="src">The source type</param>
        public static IEnumerable<BinaryLiteral> BinaryLiterals(this Type src)
            => from f in src.Literals()
                where f.Attributed<BinaryLiteralAttribute>()
               let a = f.CustomAttribute<BinaryLiteralAttribute>().Require()
                select BinaryLiteral.Define(f.Name, f.GetValue(null), a.Text);



        [MethodImpl(Inline)]
        public static T[] Clear<T>(this T[] src)
        {
            src?.Fill(default(T));
            return src;
        }
        
        /// <summary>
        /// Retrives the primal kind of the first type parameter, if any
        /// </summary>
        /// <param name="method">The method to test</param>
        /// <param name="n">The generic parameter selector</param>
        [MethodImpl(Inline)]
        public static PrimalKind TypeParamKind(this MethodInfo method, N1 n)
            => (method.IsGenericMethod ? method.GetGenericArguments() : array<Type>()).FirstOrDefault()?.Kind() ?? PrimalKind.None;
    }
}
