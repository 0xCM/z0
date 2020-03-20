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
    using System.Linq.Expressions;

    using static Root;
    using static ReflectionFlags;
    
    partial class RootReflections
    {
        [MethodImpl(Inline)]
        public static IntPtr Jit(this MethodInfo src)            
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return src.MethodHandle.GetFunctionPointer();
        }

        /// <summary>
        /// Creates a delegate for a static method via the expression api
        /// </summary>
        /// <typeparam name="D">The type of the constructed delegate</typeparam>
        /// <param name="m">The method that will be invoked when delegate is activated</param>
        public static D CreateDelegate<D>(this MethodInfo m)
            where D : Delegate
        {
            var argTypes = m.ParameterTypes().ToArray();
            var dType
                = m.IsAction()
                ? Expression.GetActionType(argTypes)
                : Expression.GetFuncType(argTypes.Concat(array(m.ReturnType)).ToArray());
            return (D)Delegate.CreateDelegate(typeof(D), null, m);
        }

        /// <summary>
        /// Gets the value of a member attribute if it exists 
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="m">The member</param>
        public static Option<A> Tag<A>(this MemberInfo m) 
            where A : Attribute
                => m.GetCustomAttribute<A>();


        /// <summary>
        /// Raises an error if the source method is any flavor of generic
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static void RequireNonGeneric(this MethodInfo src)
        {
            if(src.IsGenericMethod || src.IsConstructedGenericMethod || src.IsGenericMethodDefinition)
                throw AppErrors.GenericMethod(src);
        }

        /// <summary>
        /// Raises an error if the source method is not a constructed generic method
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static void RequireConstructed(this MethodInfo src)
        {
            if(!src.IsConstructedGenericMethod)
                throw AppErrors.NonGenericMethod(src);
        }

        public static Option<MethodInfo> FirstMatchedMethod(this Type declarer, string name, params Type[] paramTypes)
        {
            foreach(var m in declarer.DeclaredMethods())
            {
                var pTypes = m.ParameterTypes(true).ToArray();
                if(pTypes.Length >= paramTypes.Length)
                {
                    var matched = false;
                    for(var i=0; i<paramTypes.Length; i++)
                        matched &= (pTypes[i] == paramTypes[i]);
                    if(matched)
                        return m;
                }
            }
            return none<MethodInfo>();
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

   }
}