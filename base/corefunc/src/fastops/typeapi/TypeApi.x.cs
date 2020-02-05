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
    using System.Linq;
    using System.Collections.Generic;
    using System.ComponentModel;

    using static zfunc;


    partial class FastOpX
    {
        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        public static IEnumerable<OpClosureInfo> Close(this GenericOpSpec op)
            => OpSpecs.close(op);

        /// <summary>
        /// Gets the name of a method to which to Op attribute is applied
        /// </summary>
        /// <param name="m">The source method</param>
        public static string HostName(this Type t)
            => Identity.host(t);

        /// <summary>
        /// Determines whether a type is parametric over the natural numbers
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsNatSpan(this Type t)
            => NatSpanSig.From(t).IsSome();

        /// <summary>
        /// Determines whether a type encodes a natural number
        /// </summary>
        /// <param name="t">The type to test</param>
        public static bool IsNat(this Type t)
            => t.Realizes<ITypeNat>();

        /// <summary>
        /// For a type that encodes a natural number, returns the corresponding value; otherwise, returns none
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Option<ulong> NatValue(this Type t)
            => t.IsNat() ? ((ITypeNat)Activator.CreateInstance(t)).NatValue : default;


        /// <summary>
        /// Returns true if the source type is intrinsic or blocked
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSegmented(this Type t)
            => t.IsBlocked() || t.IsVector();

        /// <summary>
        /// Divines the bit-width of a specified type, if possible
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static FixedWidth Width(this Type t)
        {
            if(VectorType.test(t))
                return VectorType.width(t);
            else if(BlockedType.test(t))
                return BlockedType.width(t);
            if(NumericType.test(t))
                return NumericType.width(t);
            else if(t == typeof(bit))
                return FixedWidth.W1;
            else
                return FixedWidth.None;
        }

        /// <summary>
        /// If type is intrinsic or blocked, returns the primal type over which the segmentation is defined; otherwise, returns none
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Option<Type> SegmentType(this Type t)
            => t.IsSegmented() && t.IsClosedGeneric() ? t.SuppliedTypeArgs().Single() : default;        

        [MethodImpl(Inline)]
        public static TernaryBitLogicKind Next(this TernaryBitLogicKind src)
            => src != TernaryBitLogicKind.XFF 
                ? (TernaryBitLogicKind)((uint)(src) + 1u)
                : TernaryBitLogicKind.X00;        

        /// <summary>
        /// Determines whether a supplied type is predicated on a double, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsDecimal(this Type t)
            => t.IsTypeOf<decimal>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a bool, including nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsBool(this Type t)
            => t.IsTypeOf<bool>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a string, including references
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsString(this Type t)
            => t.IsTypeOf<string>();

        /// <summary>
        /// Determines whether a supplied type is of type Void
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsVoid(this Type t)
            => t == typeof(void);

        /// <summary>
        /// Determines whether a supplied type is predicated on a char, including nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsChar(this Type t)
            => t.IsTypeOf<Char>();


        [MethodImpl(Inline)]
        public static string PrimitiveKeyword(this Type src)
        {
            if(src.IsSByte())
                return "sbyte";
            else if(src.IsByte())
                return "byte";
            else if(src.IsUInt16())
                return "ushort";
            else if(src.IsInt16())
                return "short";
            else if(src.IsInt32())
                return "int";
            else if(src.IsUInt32())
                return "uint";
            else if(src.IsInt64())
                return "long";
            else if(src.IsUInt64())
                return "ulong";
            else if(src.IsSingle())
                return "float";
            else if(src.IsDouble())
                return "double";
            else if(src.IsDecimal())
                return "decimal";
            else if(src.IsBool())
                return "bool";
            else if(src.IsChar())
                return "char";
            else if(src.IsString())
                return "string";
            else if(src.IsVoid())
                return "void";
            else 
                return default;
        }

        [MethodImpl(Inline)]
        public static bool IsPrimalNonNumeric(this Type src)
            => src.IsBool() || src.IsVoid() || src.IsChar() || src.IsString();

        [MethodImpl(Inline)]
        public static bool IsPrimalNumeric(this Type src)
            => NumericType.test(src);

        [MethodImpl(Inline)]
        public static bool IsPrimal(this Type src)
            => src.IsPrimalNumeric() || src.IsPrimalNonNumeric();

        /// <summary>
        /// Constructs a display name for a type
        /// </summary>
        /// <param name="src">The source type</param>
        public static string DisplayName(this Type src)
        {
            if(src == null)
                throw new ArgumentNullException(nameof(src));
                
            if(Attribute.IsDefined(src, typeof(DisplayNameAttribute)))
                return src.GetCustomAttribute<DisplayNameAttribute>().DisplayName;

            if(src.IsEnum)
                return src.Name + AsciSym.Colon + src.GetEnumUnderlyingType().DisplayName();

            if(src.IsPointer)
                return $"{src.GetElementType().DisplayName()}*";
            
            if(src.IsPrimal())
                return src.PrimitiveKeyword().IfBlank(src.Name);

            if(src.IsGenericType && !src.IsRef())
                return src.FormatGeneric();

            if(src.IsRef())
                return src.GetElementType().DisplayName();

            return src.Name;
        }

        static string FormatGeneric(this Type src)
        {
            var name = src.Name;                
            var args = src.GetGenericArguments();
            if(args.Length != 0)
            {
                name = name.Replace($"`{args.Length}", string.Empty);
                name += "<";
                for(var i= 0; i< args.Length; i++)
                {
                    name += args[i].DisplayName();
                    if(i != args.Length - 1)
                        name += ",";
                }                                
                name += ">";
            }
            return name;
        } 


    }
}