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
        /// Raises an error if the source method is any flavor of generic
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static void RequireNonGeneric(this MethodInfo src)
        {
            if(src.IsGenericMethod || src.IsConstructedGenericMethod || src.IsGenericMethodDefinition)
                throw Errors.GenericMethod(src);
        }

        /// <summary>
        /// Raises an error if the source method is not a constructed generic method
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static void RequireConstructed(this MethodInfo src)
        {
            if(!src.IsConstructedGenericMethod)
                throw Errors.NonGenericMethod(src);
        }

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
        /// Searches a type for any method that matches the supplied signature
        /// </summary>
        /// <param name="declarer">The type to search</param>
        /// <param name="name">The name of the method</param>
        /// <param name="paramTypes">The method parameter types in ordinal position</param>
        public static Option<MethodInfo> MatchMethod(this Type declarer, string name, params Type[] paramTypes)
            => paramTypes.Length != 0
                ? declarer.GetMethod(name, bindingAttr: AnyVisibilityOrInstanceType, binder: null, types: paramTypes, modifiers: null)
                : declarer.GetMethod(name, AnyVisibilityOrInstanceType);

        /// <summary>
        /// Selects the concrete (not abstract) methods from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> Concrete(this IEnumerable<MethodInfo> src)
            => src.Where(t => !t.IsAbstract);

        /// <summary>
        /// Selects the methods from a stream where the name is NOT special
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> NonSpecial(this IEnumerable<MethodInfo> src)
            => src.Where(t => !t.IsSpecialName && !t.Name.Contains(AsciSym.Pipe) && !t.Name.Contains(AsciSym.Lt));


        [MethodImpl(Inline)]
        public static IntPtr Jit(this MethodInfo src)            
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return src.MethodHandle.GetFunctionPointer();
        }

    }
}