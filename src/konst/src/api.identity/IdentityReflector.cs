//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Intrinsics;

    using static Konst;

    using AC = ArityKind;
    using OC = ApiOperatorClass;
    using PC = ApiPredicateClass;

    [ApiHost(ApiNames.ApiIdentityReflector, true)]
    public readonly struct IdentityReflector
    {

        /// <summary>
        /// Determines whether a type is classified as an intrinsic vector
        /// </summary>
        /// <param name="t">The type to test</param>
        [Op]
        public static bool IsVector(Type t)
        {
            var eff = t.EffectiveType();
            var def = eff.IsGenericType ? eff.GetGenericTypeDefinition() : (eff.IsGenericTypeDefinition ? eff : null);
            if(def == null)
                return false;

            return def == typeof(Vector128<>) || def == typeof(Vector256<>) || def.Tagged<VectorAttribute>();
        }

        /// <summary>
        /// Determines whether a method accepts an intrinsic vector in some parameter slot
        /// </summary>
        /// <param name="src">The method to test</param>
        [Op]
        public static bool AcceptsVector(MethodInfo src)
            => src.Parameters(p => p.IsVector()).Any();

        /// <summary>
        /// Determines whether a method accepts an intrinsic vector at an index-identified parameter
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="index">THe parameter index to match</param>
        [Op]
        public static bool AcceptsVector(MethodInfo src, int index)
            => src.Parameters(p => p.Position == index && p.IsVector()).Any();

        /// <summary>
        /// Determines whether a method accepts a 128-bit intrinsic vector at an index-identified parameter
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="index">THe parameter index to match</param>
        /// <param name="w">The width to match</param>
        [Op]
        public static bool AcceptsVector(MethodInfo src, int index, W512 w)
            => src.Parameters(p => p.Position == index && p.IsVector(w)).Any();

        /// <summary>
        /// Determines whether a method accepts a 128-bit intrinsic vector at an index-identified parameter of specified cell type
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="index">THe parameter index to match</param>
        /// <param name="w">The width to match</param>
        /// <param name="tCell">The cell type to match</param>
        [Op]
        public static bool AcceptsVector(MethodInfo src, int index, W128 w, Type tCell)
            => src.Parameters(p => p.Position == index && p.IsVector(w,tCell)).Any();

        /// <summary>
        /// Determines whether a method accepts a 128-bit intrinsic vector at an index-identified parameter
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="index">THe parameter index to match</param>
        /// <param name="w">The width to match</param>
        [Op]
        public static bool AcceptsVector(MethodInfo src, int index, W128 w)
            => src.Parameters(p => p.Position == index && p.IsVector(w)).Any();

        /// <summary>
        /// Determines whether a method accepts a 128-bit intrinsic vector at an index-identified parameter
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="index">THe parameter index to match</param>
        /// <param name="w">The width to match</param>
        [Op]
        public static bool AcceptsVector(MethodInfo src, int index, W256 w)
            => src.Parameters(p => p.Position == index && p.IsVector(w)).Any();

        /// <summary>
        /// Determines whether a method accepts a 256-bit intrinsic vector at an index-identified parameter of specified cell type
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="index">THe parameter index to match</param>
        /// <param name="w">The width to match</param>
        /// <param name="tCell">The cell type to match</param>
        [Op]
        public static bool AcceptsVector(MethodInfo src, int index, W256 w, Type tCell)
            => src.Parameters(p => p.Position == index && p.IsVector(w,tCell)).Any();

        /// <summary>
        /// Determines whether a method accepts a 512-bit intrinsic vector at an index-identified parameter of specified cell type
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="index">The parameter index to match</param>
        /// <param name="w">The width to match</param>
        /// <param name="tCell">The cell type to match</param>
        [Op]
        public static bool AcceptsVector(MethodInfo src, int index, W512 w, Type tCell)
            => src.Parameters(p => p.Position == index && p.IsVector(w,tCell)).Any();

        /// <summary>
        /// Determines whether a method returns a 128-bit intrinsic vector
        /// </summary>
        /// <param name="src">The method to test</param>
        [Op]
        public static bool ReturnsVector(MethodInfo src, W128 w)
            => src.ReturnType.IsVector(w);

        /// <summary>
        /// Determines whether a method returns a 256-bit intrinsic vector
        /// </summary>
        /// <param name="src">The method to test</param>
        [Op]
        public static bool ReturnsVector(MethodInfo src, W256 w)
            => src.ReturnType.IsVector(w);

        /// <summary>
        /// Determines whether a method returns a 256-bit intrinsic vector
        /// </summary>
        /// <param name="src">The method to test</param>
        [Op]
        public static bool ReturnsVector(MethodInfo src, W512 w)
            => src.ReturnType.IsVector(w);

        /// <summary>
        /// Determines whether a method returns a 128-bit intrinsic vector of specified cell type
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="w">The width to match</param>
        /// <param name="tCell">The cell type to match</param>
        [Op]
        public static bool ReturnsVector(MethodInfo src, W128 w, Type tCell)
            => src.ReturnType.IsVector(w, tCell);

        /// <summary>
        /// Determines whether a method returns a 256-bit intrinsic vector of specified cell type
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="w">The width to match</param>
        /// <param name="tCell">The cell type to match</param>
        [Op]
        public static bool ReturnsVector(MethodInfo src, W256 w, Type tCell)
            => src.ReturnType.IsVector(w, tCell);

        /// <summary>
        /// Determines whether a method returns a 512-bit intrinsic vector with of specified cell type
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="w">The width to match</param>
        /// <param name="tCell">The cell type to match</param>
        [Op]
        public static bool ReturnsVector(MethodInfo src, W512 w, Type tCell)
            => src.ReturnType.IsVector(w, tCell);

        /// <summary>
        /// Determines whether a method is an emitter, i.e. a method that returns a value but accepts no input
        /// </summary>
        /// <param name="m">The method to classify</param>
        [Op]
        public static bool IsSource(MethodInfo m)
            => m.IsFunction() && m.HasArityValue(0);

        /// <summary>
        /// Determines whether a method has void return and has arity = 1
        /// </summary>
        /// <param name="m">The method to classify</param>
        [Op]
        public static bool IsSink(MethodInfo m)
            => m.HasVoidReturn() && m.ArityValue() == 1;

        /// <summary>
        /// Queries the stream for methods with a nonempty arity classification
        /// </summary>
        /// <param name="src">The source stream</param>
        [Op]
        public static MethodInfo[] WithArityClass(MethodInfo[] src)
            => from m in src where ArityClass(m) != 0 select m;

        /// <summary>
        /// Queries the stream for methods with a specified arity classification
        /// </summary>
        /// <param name="src">The source stream</param>
        [Op]
        public static MethodInfo[] WithArityClass(MethodInfo[] src, ArityKind @class)
            => from m in src where ArityClass(m) == @class select m;

        /// <summary>
        /// Determines whether a method is a function with numeric operands (if any) and return type
        /// </summary>
        /// <param name="m">The method to examine</param>
        [Op]
        public static bool IsNumericFunction(MethodInfo m)
            => m.IsFunction()
            && NumericKinds.test(m.ReturnType)
            && Enumerable.All<Type>(m.ParameterTypes(), t => t.NumericKind() != NumericKind.None);

        /// <summary>
        /// Queries the stream for methods that are functions
        /// </summary>
        /// <param name="src">The source stream</param>
        [Op]
        public static MethodInfo[] Functions(MethodInfo[] src)
            => src.Where(m => m.IsFunction());

        /// <summary>
        /// Queries the stream for methods that are actions
        /// </summary>
        /// <param name="src">The source stream</param>
        [Op]
        public static MethodInfo[] Actions(MethodInfo[] src)
            => src.Where(m => m.IsAction());

        /// <summary>
        /// Queries the stream for methods with a specified predicate classification
        /// </summary>
        /// <param name="src">The source stream</param>
        [Op]
        public static MethodInfo[] WithPredicateClass(MethodInfo[] src, ApiPredicateClass @class)
            => from m in src where ClassifyPredicate(m) == @class select m;

        /// <summary>
        /// Queries the stream for methods with a nonempty predicate classification
        /// </summary>
        /// <param name="src">The source stream</param>
        [Op]
        public static MethodInfo[] WithPredicateClass(MethodInfo[] src)
            => from m in src where ClassifyPredicate(m) != 0 select m;

        /// <summary>
        /// Queries the stream for methods with a nonempty operator classification
        /// </summary>
        /// <param name="src">The source stream</param>
        [Op]
        public static MethodInfo[] WithOperatorClass(MethodInfo[] src)
            => from m in src where m.ClassifyOperator() != 0 select m;

        /// <summary>
        /// Queries the stream for methods with a specified operator classification
        /// </summary>
        /// <param name="src">The source stream</param>
        [Op]
        public static MethodInfo[] WithOperatorClass(MethodInfo[] src, ApiOperatorClass @class)
            => from m in src where m.ClassifyOperator() == @class select m;

        /// <summary>
        /// Determines whether a method defines a predicate that returns a bit or bool value
        /// </summary>
        /// <param name="m">The method to examine</param>
        [Op]
        public static bool IsPredicate(MethodInfo m)
            => m.ParameterTypes().Distinct().Count() == 1
            && (m.ReturnType.Name =="bit" || m.ReturnType == typeof(bool));

        /// <summary>
        /// Classifies a methods that is an operator and has arity between 1 and 3; otherwise, returns None
        /// </summary>
        /// <param name="m">The method to examine</param>
        [Op]
        public static ApiPredicateClass ClassifyPredicate(MethodInfo m)
        {
            if(IsPredicate(m))
            {
                return m.ArityValue() switch {
                    1 => PC.UnaryPredicate,
                    2 => PC.BinaryPredicate,
                    3 => PC.TernaryPredicate,
                    _ => PC.None

                };
            }
            return 0;
        }

        /// <summary>
        /// Assigns an arity classification, if any, to a method
        /// </summary>
        /// <param name="m">The method to examine</param>
        [Op]
        public static ArityKind ArityClass(MethodInfo m)
            => m.ArityValue() switch{
                0 => AC.Nullary,
                1 => AC.Unary,
                2 => AC.Binary,
                3 => AC.Ternary,
                _ => AC.None
            };

        [Op]
        public static int ArityValue(ApiOperatorClass src)
            => src switch{
               OC.UnaryOp => 1,
               OC.BinaryOp => 2,
               OC.TernaryOp => 3,
                _  => 0,
            };


        /// <summary>
        /// Classifies a methods that is an operator and has arity between 1 and 3; otherwise, returns None
        /// </summary>
        /// <param name="src">The method to examine</param>
        [Op]
        public static OC ClassifyOperator(MethodInfo src)
        {
            if(src.IsOperator())
            {
                return src.ArityValue() switch {
                    1 => OC.UnaryOp,
                    2 => OC.BinaryOp,
                    3 => OC.TernaryOp,
                    _ => OC.None

                };
            }
            return 0;
        }

        /// <summary>
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        [Op]
        public static bool IsVectorized(MethodInfo src, int? width, bool total)
            => total ? (VectorKinds.test(src.ReturnType,width) && src.ParameterTypes().All(t => VectorKinds.test(t,width)))
                     : (VectorKinds.test(src.ReturnType,width) || src.ParameterTypes().Any(t => VectorKinds.test(t,width)));

        /// <summary>
        /// Determines whether a method has intrinsic parameters or return type
        /// </summary>
        /// <param name="src">The method to test</param>
        [Op]
        public static bool IsVectorized(MethodInfo src)
            => src.ReturnType.IsVector() || src.ParameterTypes().Any(VectorKinds.test);

        /// <summary>
        /// Determines whether a method has at least one 128-bit intrinsic vector parameter
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        [Op]
        public static bool IsVectorized(MethodInfo m, W128 w)
            => IsVectorized(m) && m.Parameters(p => p.ParameterType.IsVector(w)).Count() != 0;

        /// <summary>
        /// Determines whether a method has at least one 128-bit intrinsic vector parameter
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        [Op]
        public static bool IsVectorized(MethodInfo m, W256 w)
            => IsVectorized(m) && m.Parameters(p => p.ParameterType.IsVector(w)).Count() != 0;

        /// <summary>
        /// Determines whether a method has at least one 128-bit intrinsic vector parameter
        /// </summary>
        /// <param name="src">The method to examine</param>
        /// <param name="w">The width to match</param>
        [Op]
        public static bool IsVectorized(MethodInfo src, W512 w)
            => IsVectorized(src) && src.Parameters(p => p.ParameterType.IsVector(w)).Count() != 0;

        /// <summary>
        /// Determines whether a method has at least one 128-bit intrinsic vector parameter closed over a specified type
        /// </summary>
        /// <param name="src">The method to examine</param>
        /// <param name="w">The width to match</param>
        [Op]
        public static bool IsVectorized(MethodInfo src, W128 w, Type tCell)
            => IsVectorized(src) && src.Parameters(p => p.ParameterType.IsVector(w,tCell)).Count() != 0;

        /// <summary>
        /// Determines whether a method has at least one 256-bit intrinsic vector parameter closed over a specified type
        /// </summary>
        /// <param name="src">The method to examine</param>
        /// <param name="w">The width to match</param>
        [Op]
        public static bool IsVectorized(MethodInfo src, W256 w, Type tCell)
            => IsVectorized(src) && src.Parameters(p => p.ParameterType.IsVector(w,tCell)).Count() != 0;

        /// <summary>
        /// Determines whether a method has at least one 512-bit intrinsic vector parameter closed over a specified type
        /// </summary>
        /// <param name="src">The method to examine</param>
        /// <param name="w">The width to match</param>
        [Op]
        public static bool IsVectorized(MethodInfo src, W512 w, Type tCell)
            => IsVectorized(src,w) && src.Parameters(p => p.ParameterType.IsVector(w,tCell)).Count() != 0;

        /// <summary>
        /// Selects vectorized methods from a source stream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="w">The vector width</param>
        /// <param name="g">The generic partition from which methods should be selected</param>
        [Op]
        public static bool IsVectorized(MethodInfo src, W128 w, GenericState g = default)
            => IsVectorized(src,w) && src.IsMemberOf(g);

        /// <summary>
        /// Selects vectorized methods from a source stream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="w">The vector width</param>
        /// <param name="g">The generic partition from which methods should be selected</param>
        [Op]
        public static bool IsVectorized(MethodInfo src, W256 w, GenericState g = default)
            => IsVectorized(src, w) && src.IsMemberOf(g);

        /// <summary>
        /// Selects vectorized methods from a source stream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="w">The vector width</param>
        /// <param name="g">The generic partition from which methods should be selected</param>
        [Op]
        public static bool IsVectorized(MethodInfo src, W512 w, GenericState g = default)
            => src.IsVectorized(w) && src.IsMemberOf(g);
    }
}