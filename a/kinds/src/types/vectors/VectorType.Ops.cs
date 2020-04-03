//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;
 
    public static class VectorTypesOps
    {
        /// <summary>
        /// Determines whether a type is an intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this Type t)
            => VectorType.test(t);

        /// <summary>
        /// Determines whether a method returns an intrinsic vector
        /// </summary>
        /// <param name="src">The method to test</param>
        public static bool ReturnsVector(this MethodInfo src)
            => src.ReturnType.IsVector();

        public static TypeWidth NumericWidth(this Type t)
        {
            var k = NumericKinds.kind(t);
            if(k != 0)
                return (TypeWidth)(ushort)k;
            else
                return TypeWidth.None;            
        }         

        /// <summary>
        /// Determines whether a type is a 128-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this Type t, W128 w)
            => VectorType.width(t) == TypeWidth.W128;

        /// <summary>
        /// Determines whether a type is a 256-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this Type t, W256 w)
            => VectorType.width(t) == TypeWidth.W256;

        /// <summary>
        /// Determines whether a type is a 512-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this Type t, W512 w)
            => VectorType.width(t) == TypeWidth.W512;

        /// <summary>
        /// Determines whether a parameter is of intrinsic vector type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this ParameterInfo t)
            => VectorType.test(t.ParameterType);

        /// <summary>
        /// Determines whether a parameter is of type 128-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this ParameterInfo t, W128 w)
            => VectorType.width(t.ParameterType) == TypeWidth.W128;

        /// <summary>
        /// Determines whether a parameter is of type 256-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this ParameterInfo t, W256 w)
            => VectorType.width(t.ParameterType) == TypeWidth.W256;

        /// <summary>
        /// Determines whether a parameter is of type 512-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this ParameterInfo t, W512 w)
            => VectorType.width(t.ParameterType) == TypeWidth.W512;

        /// <summary>
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsVectorized(this MethodInfo src, int? width, bool total)        
            => total ? (VectorType.test(src.ReturnType,width) && src.ParameterTypes().All(t => VectorType.test(t,width))) 
                     : (VectorType.test(src.ReturnType,width) || src.ParameterTypes().Any(t => VectorType.test(t,width)));

        /// <summary>
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsKind(this MethodInfo m, Vec128Kind hk, bool total)        
            => m.IsVectorized(128,total);

        /// <summary>
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsKind(this MethodInfo m, Vec256Kind hk, bool total)        
            => m.IsVectorized(256, total);

        /// <summary>
        /// Selects methods from a stream that accept and/or return intrinsic vectors
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> OfKind(this IEnumerable<MethodInfo> src, Vec128Kind hk, bool total = false)
            => src.Where(m => m.IsKind(hk,total));

        /// <summary>
        /// Selects methods from a stream that accept and/or return intrinsic vectors
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> OfKind(this IEnumerable<MethodInfo> src, Vec256Kind hk, bool total = false)
            => src.Where(m => m.IsKind(hk,total));

        /// <summary>
        /// Determines whether a method returns a 128-bit intrinsic vector
        /// </summary>
        /// <param name="src">The method to test</param>
        public static bool ReturnsVector(this MethodInfo src, W128 w)
            => src.ReturnType.IsVector(w);

        /// <summary>
        /// Determines whether a method returns a 256-bit intrinsic vector
        /// </summary>
        /// <param name="src">The method to test</param>
        public static bool ReturnsVector(this MethodInfo src, W256 w)
            => src.ReturnType.IsVector(w);

        /// <summary>
        /// Determines whether a method returns a 256-bit intrinsic vector
        /// </summary>
        /// <param name="src">The method to test</param>
        public static bool ReturnsVector(this MethodInfo src, W512 w)
            => src.ReturnType.IsVector(w);

        /// <summary>
        /// Determines whether a type is a 128-bit intrinsic vector closed over a specified type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this Type t, W128 w, Type tCell)
            => t.IsVector(w)
            && t.IsClosedGeneric()
            && t.GenericParameters().Single() == tCell;

        /// <summary>
        /// Determines whether a type is a 256-bit intrinsic vector closed over a specified type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this Type t, W256 w, Type tCell)
            => t.IsVector(w)
            && t.IsClosedGeneric()
            && t.GenericParameters().Single() == tCell;

        /// <summary>
        /// Determines whether a type is a 512-bit intrinsic vector closed over a specified type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this Type t, W512 w, Type tCell)
            => t.IsVector(w)
            && t.IsClosedGeneric()
            && t.GenericParameters().Single() == tCell;

        /// <summary>
        /// Determines whether a method returns a 128-bit intrinsic vector of specified cell type
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="w">The width to match</param>
        /// <param name="tCell">The cell type to match</param>
        public static bool ReturnsVector(this MethodInfo src, W128 w, Type tCell)
            => src.ReturnType.IsVector(w, tCell);

        /// <summary>
        /// Determines whether a method returns a 256-bit intrinsic vector of specified cell type
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="w">The width to match</param>
        /// <param name="tCell">The cell type to match</param>
        public static bool ReturnsVector(this MethodInfo src, W256 w, Type tCell)
            => src.ReturnType.IsVector(w, tCell);

        /// <summary>
        /// Determines whether a method returns a 512-bit intrinsic vector with of specified cell type
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="w">The width to match</param>
        /// <param name="tCell">The cell type to match</param>
        public static bool ReturnsVector(this MethodInfo src, W512 w, Type tCell)
            => src.ReturnType.IsVector(w, tCell);


        /// <summary>
        /// Returns true if a method parameter is a 128-bit intrinsic vector closed over a specified argument type
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        /// <param name="arg">The argument type to match</param>
        public static bool IsVector(this ParameterInfo param, W128 w, Type arg)
            => param.ParameterType.IsVector(w,arg);

        /// <summary>
        /// Returns true if a method parameter is a 256-bit intrinsic vector closed over a specified argument type
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        /// <param name="arg">The argument type to match</param>
        public static bool IsVector(this ParameterInfo param, W256 w, Type arg)
            => param.ParameterType.IsVector(w,arg);

        /// <summary>
        /// Returns true if a method parameter is a 512-bit intrinsic vector closed over a specified argument type
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        /// <param name="arg">The argument type to match</param>
        public static bool IsVector(this ParameterInfo param, W512 w, Type arg)
            => param.ParameterType.IsVector(w,arg);

        /// <summary>
        /// Returns true if a type is an open generic 128-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsOpenVector(this Type t, W128 w)
            => t.IsOpenGeneric() && t.IsVector(w);

        /// <summary>
        /// Returns true if a type is an open generic 256-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsOpenVector(this Type t, W256 w)
            => t.IsOpenGeneric() && t.IsVector(w);

        /// <summary>
        /// Returns true if a type is an open generic 512-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsOpenVector(this Type t, W512 w)
            => t.IsOpenGeneric() && t.IsVector(w);

        /// <summary>
        /// Returns true if a type is a closed 128-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this Type t, W128 w)
            => t.IsClosedGeneric() && t.IsVector(w);

        /// <summary>
        /// Returns true if a type is a closed 256-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this Type t, W256 w)
            => t.IsClosedGeneric() && t.IsVector(w);

        /// <summary>
        /// Returns true if a type is a closed 512-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this Type t, W512 w)
            => t.IsClosedGeneric() && t.IsVector(w);

        /// <summary>
        /// Returns true if a method parameter is a closed 128-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this ParameterInfo param, W128 w)
            => param.ParameterType.IsClosedGeneric() && param.ParameterType.IsVector(w);

        /// <summary>
        /// Returns true if a method parameter is a closed 256-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this ParameterInfo param, W256 w)
            => param.ParameterType.IsClosedGeneric() && param.ParameterType.IsVector(w);

        /// <summary>
        /// Returns true if a method parameter is a closed 512-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this ParameterInfo param, W512 w)
            => param.ParameterType.IsClosedGeneric() && param.ParameterType.IsVector(w); 

        /// <summary>
        /// Determines whether a method accepts an intrinsic vector in some parameter slot
        /// </summary>
        /// <param name="src">The method to test</param>
        public static bool AcceptsVector(this MethodInfo src)
            => src.Parameters(p => p.IsVector()).Any();

        /// <summary>
        /// Determines whether a method accepts an intrinsic vector at an index-identified parameter
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="index">THe parameter index to match</param>
        public static bool AcceptsVector(this MethodInfo src, int index)
            => src.Parameters(p => p.Position == index && p.IsVector()).Any();

        /// <summary>
        /// Determines whether a method accepts a 128-bit intrinsic vector at an index-identified parameter
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="index">THe parameter index to match</param>
        /// <param name="w">The width to match</param>
        public static bool AcceptsVector(this MethodInfo src, int index, W128 w)
            => src.Parameters(p => p.Position == index && p.IsVector(w)).Any();

        /// <summary>
        /// Determines whether a method accepts a 128-bit intrinsic vector at an index-identified parameter
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="index">THe parameter index to match</param>
        /// <param name="w">The width to match</param>
        public static bool AcceptsVector(this MethodInfo src, int index, W256 w)
            => src.Parameters(p => p.Position == index && p.IsVector(w)).Any();

        /// <summary>
        /// Determines whether a method accepts a 128-bit intrinsic vector at an index-identified parameter
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="index">THe parameter index to match</param>
        /// <param name="w">The width to match</param>
        public static bool AcceptsVector(this MethodInfo src, int index, W512 w)
            => src.Parameters(p => p.Position == index && p.IsVector(w)).Any();

        /// <summary>
        /// Determines whether a method accepts a 128-bit intrinsic vector at an index-identified parameter of specified cell type
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="index">THe parameter index to match</param>
        /// <param name="w">The width to match</param>
        /// <param name="tCell">The cell type to match</param>
        public static bool AcceptsVector(this MethodInfo src, int index, W128 w, Type tCell)
            => src.Parameters(p => p.Position == index && p.IsVector(w,tCell)).Any();

        /// <summary>
        /// Determines whether a method accepts a 256-bit intrinsic vector at an index-identified parameter of specified cell type
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="index">THe parameter index to match</param>
        /// <param name="w">The width to match</param>
        /// <param name="tCell">The cell type to match</param>
        public static bool AcceptsVector(this MethodInfo src, int index, W256 w, Type tCell)
            => src.Parameters(p => p.Position == index && p.IsVector(w,tCell)).Any();

        /// <summary>
        /// Determines whether a method accepts a 512-bit intrinsic vector at an index-identified parameter of specified cell type
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="index">The parameter index to match</param>
        /// <param name="w">The width to match</param>
        /// <param name="tCell">The cell type to match</param>
        public static bool AcceptsVector(this MethodInfo src, int index, W512 w, Type tCell)
            => src.Parameters(p => p.Position == index && p.IsVector(w,tCell)).Any();            

        /// <summary>
        /// Determines whether a method has intrinsic parameters or return type
        /// </summary>
        /// <param name="src">The method to test</param>
        public static bool IsFullyVectorized(this MethodInfo src)        
            => VectorType.test(src.ReturnType) && src.ParameterTypes().All(VectorType.test);

        /// <summary>
        /// Determines whether all parameters of a method are 128-bit intrinsic vectors
        /// </summary>
        /// <param name="src">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsFullyVectorized(this MethodInfo src, W128 w)        
            => src.IsFullyVectorized() && src.EffectiveParameterTypes().All(t => t.IsVector(w));

        /// <summary>
        /// Determines whether all parameters of a method are 256-bit intrinsic vectors
        /// </summary>
        /// <param name="src">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsFullyVectorized(this MethodInfo src, W256 w)        
            => src.IsFullyVectorized() && src.EffectiveParameterTypes().All(t => t.IsVector(w));

        /// <summary>
        /// Determines whether all parameters of a method are 256-bit intrinsic vectors
        /// </summary>
        /// <param name="src">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsFullyVectorized(this MethodInfo src, W512 w)        
            => src.IsFullyVectorized() && src.EffectiveParameterTypes().All(t => t.IsVector(w));

        /// <summary>
        /// Determines whether all parameters of a method are 128-bit intrinsic vectors with a specified cell type
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="w">The width to match</param>
        /// <param name="tCell">The cell type to match</param>
        public static bool IsFullyVectorized(this MethodInfo src, W128 w, Type tCell)        
            => src.IsFullyVectorized(w) && src.ReturnType.IsVector(w,tCell);

        /// <summary>
        /// Determines whether all parameters of a method are 256-bit intrinsic vectors with a specified cell type
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="w">The width to match</param>
        /// <param name="tCell">The cell type to match</param>
        public static bool IsFullyVectorized(this MethodInfo src, W256 w, Type tCell)        
            => src.IsFullyVectorized(w) && src.ReturnType.IsVector(w,tCell);

        /// <summary>
        /// Determines whether all parameters of a method are 512-bit intrinsic vectors with a specified cell type
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="w">The width to match</param>
        /// <param name="tCell">The cell type to match</param>
        public static bool IsFullyVectorized(this MethodInfo src, W512 w, Type tCell)        
            => src.IsFullyVectorized(w) && src.ReturnType.IsVector(w,tCell);

        /// <summary>
        /// Determines whether a method produces, but does not accept, vector values
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsVectorFactory(this MethodInfo m)        
            => m.ParameterTypes(true).Where(t => t.IsVector()).Count() == 0 && m.ReturnType.IsVector();

        /// <summary>
        /// Determines whether a method has intrinsic parameters or return type
        /// </summary>
        /// <param name="src">The method to test</param>
        public static bool IsVectorized(this MethodInfo src)        
            => src.ReturnsVector() || src.ParameterTypes().Any(VectorType.test);

        /// <summary>
        /// Determines whether a method has at least one 128-bit intrinsic vector parameter 
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo m, W512 w)        
            => m.IsVectorized() && m.Parameters(p => p.ParameterType.IsVector(w)).Count() != 0;

        /// <summary>
        /// Determines whether a method has at least one 128-bit intrinsic vector parameter closed over a specified type
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo m, W128 w, Type tCell)        
            => m.IsVectorized() && m.Parameters(p => p.ParameterType.IsVector(w,tCell)).Count() != 0;

        /// <summary>
        /// Determines whether a method has at least one 256-bit intrinsic vector parameter closed over a specified type
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo m, W256 w, Type tCell)        
            => m.IsVectorized() && m.Parameters(p => p.ParameterType.IsVector(w,tCell)).Count() != 0;

        /// <summary>
        /// Determines whether a method has at least one 512-bit intrinsic vector parameter closed over a specified type
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo m, W512 w, Type tCell)        
            => m.IsVectorized() && m.Parameters(p => p.ParameterType.IsVector(w,tCell)).Count() != 0;


        /// <summary>
        /// Determines whether a method is (partially) vectorized and accepts an immediate value
        /// </summary>
        /// <param name="src">The method to query</param>
        public static bool IsVectorizedImm(this MethodInfo src)
            => src.IsVectorized() && src.AcceptsImmediate();
        

        /// <summary>
        /// Determines whether a method is a vectorized unary operator that accepts an immediate value
        /// </summary>
        /// <param name="src">The method to query</param>
        public static bool IsVectorizedUnaryImm(this MethodInfo src)
        {
            var parameters = src.GetParameters().ToArray();
            return parameters.Length == 2 
                && parameters[0].ParameterType.IsVector() 
                && parameters[1].IsImmediate();
        }

        /// <summary>
        /// Determines whether a method is a vectorized binary operator that accepts an immediate value
        /// </summary>
        /// <param name="src">The method to query</param>
        public static bool IsVectorizedBinaryImm(this MethodInfo src)
        {
            var parameters = src.GetParameters().ToArray();
            return parameters.Length == 3 
                && parameters[0].ParameterType.IsVector() 
                && parameters[1].ParameterType.IsVector() 
                && parameters[2].IsImmediate();
        }

        /// <summary>
        /// Determines whether a method has at least one 128-bit intrinsic vector parameter 
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo m, W128 w)        
            => m.IsVectorized() && m.Parameters(p => p.ParameterType.IsVector(w)).Count() != 0;

        /// <summary>
        /// Determines whether a method has at least one 128-bit intrinsic vector parameter 
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo m, W256 w)        
            => m.IsVectorized() && m.Parameters(p => p.ParameterType.IsVector(w)).Count() != 0;

        /// <summary>
        /// Selects nongeneric source methods that have at least one 128-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, W128 w)
            => src.NonGeneric().Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 256-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, W256 w)
            => src.NonGeneric().Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 512-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, W512 w)
            => src.NonGeneric().Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 128-bit vector parameter closed over a specified type
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, W128 w, Type tCell)
            => src.NonGeneric().WithParameter(p => p.IsVector(w,tCell));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 256-bit vector parameter closed over a specified type
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, W256 w, Type tCell)
            => src.NonGeneric().WithParameter(p => p.IsVector(w,tCell));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 512-bit vector parameter closed over a specified type
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, W512 w, Type tCell)
            => src.NonGeneric().WithParameter(p => p.IsVector(w,tCell));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 128-bit vector parameter closed over a specified parametric type
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        /// <typeparam name="T">The type to match</typeparam>
        public static IEnumerable<MethodInfo> VectorizedDirect<T>(this IEnumerable<MethodInfo> src, W128 w)
            where T : unmanaged
                => src.VectorizedDirect(w,typeof(T));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 256-bit vector parameter closed over a specified parametric type
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        /// <typeparam name="T">The type to match</typeparam>
        public static IEnumerable<MethodInfo> VectorizedDirect<T>(this IEnumerable<MethodInfo> src, W256 w)
            where T : unmanaged
                => src.VectorizedDirect(w,typeof(T));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 512-bit vector parameter closed over a specified parametric type
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        /// <typeparam name="T">The type to match</typeparam>
        public static IEnumerable<MethodInfo> VectorizedDirect<T>(this IEnumerable<MethodInfo> src, W512 w)
            where T : unmanaged
                => src.VectorizedDirect(w,typeof(T));

        /// <summary>
        /// Selects nongeneric source methods with a specified name that have at least one 128-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, W128 w, string name)
            => src.NonGeneric().WithName(name).WithParameter(p => p.IsClosedVector(w));

        /// <summary>
        /// Selects nongeneric source methods with a specified name that have at least one 256-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, W256 w, string name)
            => src.NonGeneric().WithName(name).WithParameter(p => p.IsClosedVector(w));

        /// <summary>
        /// Selects nongeneric source methods with a specified name that have at least one 512-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, W512 w, string name)
            => src.NonGeneric().WithName(name).WithParameter(p => p.IsClosedVector(w));

        /// <summary>
        /// Selects open generic source methods that have at least one 128-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedGeneric(this IEnumerable<MethodInfo> src, W128 w)
            => src.OpenGeneric().Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects open generic source methods that have at least one 256-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedGeneric(this IEnumerable<MethodInfo> src, W256 w)
            => src.OpenGeneric().Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects open generic source methods that have at least one 512-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedGeneric(this IEnumerable<MethodInfo> src, W512 w)
            => src.OpenGeneric().Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects open generic source methods with a specified name that have at least one 128-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedGeneric(this IEnumerable<MethodInfo> src, W128 w, string name)
            => src.OpenGeneric().WithName(name).Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects open generic source methods with a specified name that have at least one 256-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedGeneric(this IEnumerable<MethodInfo> src, W256 w, string name)
            => src.OpenGeneric().WithName(name).Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects open generic source methods with a specified name that have at least one 512-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedGeneric(this IEnumerable<MethodInfo> src, W512 w, string name)
            => src.OpenGeneric().WithName(name).Where(m => m.IsVectorized(w));         
    }
}