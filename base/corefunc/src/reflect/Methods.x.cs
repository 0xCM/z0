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
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;
    using static ReflectionFlags;

    partial class Reflections
    {        
        /// <summary>
        /// Attempts to determine whether a method is sporting the "new" keyword
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// Approach adapted from https://stackoverflow.com/questions/288357/how-does-reflection-tell-me-when-a-property-is-hiding-an-inherited-member-with-t
        /// </remarks>
        public static bool IsHidingBaseMember(this MethodInfo self)
        {
            Type baseType = self.DeclaringType.BaseType;
            var baseMethod = baseType.GetMethod(self.Name, self.GetParameters().Select(p => p.ParameterType).ToArray());

            if (baseMethod == null)
                return false;

            if (baseMethod.DeclaringType == self.DeclaringType)
                return false;

            var baseMethodDefinition = baseMethod.GetBaseDefinition();
            var thisMethodDefinition = self.GetBaseDefinition();

            return baseMethodDefinition.DeclaringType != thisMethodDefinition.DeclaringType;
        }

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
            => m.ReturnType != typeof(void);

        /// <summary>
        /// Determines whether a method is a unary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsUnaryOp(this MethodInfo m)
        {
            var args = m.ParameterTypes().ToArray();
            return args.Length == 1 && args[0] == m.ReturnType;
        }

        /// <summary>
        /// Determines whether a method is a unary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBinaryOp(this MethodInfo m)
        {
            var args = m.ParameterTypes().ToArray();
            return args.Length == 2 && args[0] == m.ReturnType && args[1] == m.ReturnType;
        }

        /// <summary>
        /// Determines whether the method is an implicit conversion operator
        /// </summary>
        /// <param name="m">The method to test</param>
        public static bool IsImplicitConverter(this MethodInfo m)
            => string.Equals(m.Name, "op_Implicit", StringComparison.InvariantCultureIgnoreCase);

        /// <summary>
        /// Determines whether the method is an explicit conversion operator
        /// </summary>
        /// <param name="m">The method to test</param>
        public static bool IsExplicitConverter(this MethodInfo m)
            => string.Equals(m.Name, "op_Explicit", StringComparison.InvariantCultureIgnoreCase);

        /// <summary>
        /// Returns a method's parameter types
        /// </summary>
        /// <param name="src">The source method</param>
        [MethodImpl(Inline)]
        public static IEnumerable<Type> ParameterTypes(this MethodInfo src)
            => src.GetParameters().Select(p => p.ParameterType);

        /// <summary>
        /// Searches a type for any method that matches the supplied signature
        /// </summary>
        /// <param name="declaringType">The type to search</param>
        /// <param name="name">The name of the method</param>
        /// <param name="argTypes">The method parameter types in ordinal position</param>
        [MethodImpl(Inline)]
        public static Option<MethodInfo> MatchMethod(this Type declaringType, string name, params Type[] argTypes)
            => argTypes.Length != 0
                ? declaringType.GetMethod(name, 
                        bindingAttr: AnyVisibilityOrInstanceType, 
                        binder: null, 
                        types: argTypes, 
                        modifiers: null
                        )
                : declaringType.GetMethod(name, AnyVisibilityOrInstanceType);

        /// <summary>
        /// Constructs a method signature from a source method
        /// </summary>
        /// <param name="src">The source method</param>
        public static MethodSig MethodSig(this MethodInfo src)
            => Z0.MethodSig.Define(src);

        /// <summary>
        /// If a method is non-generic, returns an emtpy list.
        /// If a method is open generic, returns a list describing the open parameters
        /// If a method is closed generic, returns a list describing the closed parameters
        /// </summary>
        /// <param name="src">The type from which to extract existing closed/open generic parameters</param>
        public static Type[] GenericSlots(this MethodInfo src)
            => !(src.IsGenericMethod && !src.IsGenericMethodDefinition) ? new Type[]{} 
               : src.IsConstructedGenericMethod
               ? src.GetGenericArguments()
               : src.GetGenericMethodDefinition().GetGenericArguments();

        /// <summary>
        /// Selects the concrete (not abstract) methods from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> Concrete(this IEnumerable<MethodInfo> src)
            => src.Where(t => !t.IsAbstract);

        /// <summary>
        /// Selects the methods from a stream where the name is NOT special
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> NonSpecial(this IEnumerable<MethodInfo> src)
            => src.Where(t => !t.IsSpecialName && !t.Name.Contains(AsciSym.Pipe) && !t.Name.Contains(AsciSym.Lt));

        /// <summary>
        /// Selects the abstract methods from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> Abstract(this IEnumerable<MethodInfo> src)
            => src.Where(t => t.IsAbstract);

        /// <summary>
        /// Selects the static methods from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> Static(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.IsStatic);

        /// <summary>
        /// Selects the instance methods from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> Instance(this IEnumerable<MethodInfo> src)
            => src.Where(t => !t.IsStatic);

        /// <summary>
        /// Selects the public methods from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> Public(this IEnumerable<MethodInfo> src)
            => src.Where(t => t.IsPublic);

        /// <summary>
        /// Selects the open generic methods from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> OpenGeneric(this IEnumerable<MethodInfo> src)
            => src.Where(t => t.ContainsGenericParameters);

        /// <summary>
        /// Selects the closed generic methods from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> ClosedGeneric(this IEnumerable<MethodInfo> src)
            => src.Where(t => t.IsConstructedGenericMethod);

        /// <summary>
        /// Selects the non-generic methods from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> NonGeneric(this IEnumerable<MethodInfo> src)
            => src.Where(t => !t.ContainsGenericParameters && !t.IsConstructedGenericMethod);

        /// <summary>
        /// Selects unary operators from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> UnaryOps(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.IsUnaryOp());

        /// <summary>
        /// Selects binary operators from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> BinaryOps(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.IsBinaryOp());

        /// <summary>
        /// Determines whether a type is an intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsIntrinsicVector(this Type t)
            => t.IsGenericType 
            && (t.GetGenericTypeDefinition() == typeof(Vector256<>) 
            || t.GetGenericTypeDefinition() == typeof(Vector128<>));

        /// <summary>
        /// Determines whether a method accepts and/or returns at least one intrinsic vector parameter
        /// </summary>
        /// <param name="src">The source stream</param>
        public static bool Vectorized(this MethodInfo m)
            => m.ReturnType.IsIntrinsicVector() || m.ParameterTypes().Any(t => t.IsIntrinsicVector());

        /// <summary>
        /// Selects methods from a stream that accept and/or return at least one intrinsic vector parameter
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> Vectorized(this IEnumerable<MethodInfo> src)
            => src.Where(m => m.Vectorized());


        /// <summary>
        /// Selects the non-public methods from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> NonPublic(this IEnumerable<MethodInfo> src)
            => src.Where(t => !t.IsPublic);

        /// <summary>
        /// Selects the methods from a stream that return a particular type of value
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> Returns<T>(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.ReturnType == typeof(T));

        /// <summary>
        /// Selects the methods from a stream that return a particular type of value
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="returnType">The method return type</param>
        public static IEnumerable<MethodInfo> Returns(this IEnumerable<MethodInfo> src, Type returnType)
            => src.Where(x => x.ReturnType == returnType);

        /// <summary>
        /// Selects methods from a stream that have a specified number of parameters
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="count">The parameter count</param>
        public static IEnumerable<MethodInfo> WithParameterCount(this IEnumerable<MethodInfo> src, int count)
            => src.Where(m => m.GetParameters().Length == count);        

        /// <summary>
        ///  Selects methods from a stream that declare a specific parameter type
        /// </summary>
        /// <param name="src">The method source</param>
        /// <param name="paramtype">The parameter type to match</param>
        public static IEnumerable<MethodInfo> WithParameterType(this IEnumerable<MethodInfo> src, Type paramtype)
            => src.Where(m => m.GetParameters().Length != 0 && m.GetParameters().Any(p => p.ParameterType == paramtype));

        public static IEnumerable<MethodInfo> WithGenericParameterType(this IEnumerable<MethodInfo> src, Type typedef)
            => src.Where(m => m.GetParameters().Length != 0 && m.GetParameters().Any(p => p.ParameterType.IsGenericTypeDefinition && p.ParameterType == typedef));

        /// <summary>
        /// JIT's the method and returns a pointer to the native body
        /// </summary>
        /// <param name="m">The method to JIT</param>
        public static IntPtr Prepare(this MethodInfo m)
        {   
            RuntimeHelpers.PrepareMethod(m.MethodHandle);
            var ptr = m.MethodHandle.GetFunctionPointer();
            return ptr;
        }    

        /// <summary>
        /// JIT's the delegate and returns a pointer to the native body
        /// </summary>
        /// <param name="d">The delegate to JIT</param>
        public static unsafe byte* Jit(this Delegate d)
        {   
            RuntimeHelpers.PrepareDelegate(d);
            return (byte*)d.Method.MethodHandle.GetFunctionPointer();
        }    

        [MethodImpl(Inline)]
        public static IntPtr Jit(this MethodBase method)
        {
            RuntimeHelpers.PrepareMethod(method.MethodHandle);
            return method.MethodHandle.GetFunctionPointer();
        }

        public static void JitMethods(this IEnumerable<MethodBase> methods)
        {
            foreach(var m in methods)
            {
                m.Jit();                
            }
        }
    }
}