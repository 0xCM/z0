//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    partial class Reflective
    {
        /// <summary>
        /// If a type is non-generic, returns an emtpy list.
        /// If a type is open generic, returns a list of generic arguments
        /// If a type is closed generic, returns a list of the types that were supplied as arguments to construct the type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static Type[] GenericParameters(this Type src, bool effective = true)
        {
            var t = effective ? src.EffectiveType() : src;
            return !(t.IsGenericType && !t.IsGenericTypeDefinition) ? new Type[]{} 
               : t.IsConstructedGenericType
               ? t.GetGenericArguments()
               : t.GetGenericTypeDefinition().GetGenericArguments();
        }

        /// <summary>
        /// For a non-constructed generic type or a generic type definition, returns an
        /// array of the method's type parameters; otherwise, returns an empty array
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static Type[] OpenTypeParameters(this Type t)
        {
            var effective = t.EffectiveType();
            return effective.ContainsGenericParameters ? effective.GetGenericTypeDefinition().GetGenericArguments()
             : effective.IsGenericTypeDefinition ? effective.GetGenericArguments()
             : new Type[]{};
        }

        public static int OpenTypeParameterCount(this Type t)
            => t.OpenTypeParameters().Length;

        public static int TypeParamerCount(this Type t)
            => t.GenericParameters().Length;

        public static IEnumerable<Type> SuppliedTypeArgs(this Type t)
        {
            var x = t.EffectiveType();
            if(x.IsConstructedGenericType)
                return x.GetGenericArguments();
            else
                return  new Type[]{};
        }


        /// <summary>
        /// For a generic type or reference to a generic type, retrieves the generic type definition;
        /// otherwise, returns the void type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Type GenericDefinition2(this Type t)
        {
            var effective = t.EffectiveType();
            if(effective.IsConstructedGenericType)
                return effective.GetGenericTypeDefinition();
            else if(effective.IsGenericTypeDefinition)
                return effective;
            else
                return typeof(void);            
        }

        /// <summary>
        /// Recursively close an IEnumerable generic type
        /// </summary>
        /// <param name="stype">The sequence type</param>
        /// <remarks>
        /// Adapted from https://blogs.msdn.microsoft.com/mattwar/2007/07/30/linq-building-an-iqueryable-provider-part-i/
        /// </remarks>
        public static Type CloseEnumerableType(this Type stype)
        {
            if (stype == typeof(string))
                return typeof(void);

            if (stype.IsArray)
                return typeof(IEnumerable<>).MakeGenericType(stype.GetElementType());

            if (stype.IsGenericType)
            {
                foreach (var arg in stype.GetGenericArguments())
                {
                    var enumerable = typeof(IEnumerable<>).MakeGenericType(arg);
                    if (enumerable.IsAssignableFrom(stype))
                        return enumerable;
                }
            }

            var interfaces = stype.Interfaces().ToList();
            if (interfaces.Count > 0)
            {
                foreach (var i in interfaces)
                {
                    var ienum = CloseEnumerableType(i);
                    if (ienum.IsSome())
                        return ienum;
                }
            }

            if (stype.BaseType != null && stype.BaseType != typeof(object))
                return CloseEnumerableType(stype.BaseType);
            
            return typeof(void);
        }

        /// <summary>
        /// If a value type and not an enum, returns the type; 
        /// If an enum returns the unerlying integral type; 
        /// If a nullable value typethat is not an enum, returns the underlying type; 
        /// if nullable enum, returns the non-nullable underlying integral type
        /// If a pointer returns the pointee type
        /// Otherwise, reurns the effective type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Type GetRootType(this Type t)
        {
            if (t.IsNullableType())
            {
                var _t = Nullable.GetUnderlyingType(t);
                return _t.IsEnum ? _t.GetEnumUnderlyingType() : _t;
            }
            else if(t.IsEnum)
                return t.GetEnumUnderlyingType();
            else if(t.IsPointer)
                return t.GetElementType() ?? typeof(void);
            else
                return t.EffectiveType();
        }
    }
}