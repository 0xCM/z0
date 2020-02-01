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

    using static zfunc;
    using static NumericKind;
    
    public static class DataTypeX
    {
        /// <summary>
        /// Returns a kind-identified system type if possible; throws an exception otherwise
        /// </summary>
        /// <param name="k">The identifying kind</param>
        [MethodImpl(Inline)]
        public static Option<Type> ToClrType(this NumericKind k)
            => k switch {
                U8 => typeof(byte),
                I8 => typeof(sbyte),
                U16 => typeof(ushort),
                I16 => typeof(short),
                U32 => typeof(uint),
                I32 => typeof(int),
                I64 => typeof(long),
                U64 => typeof(ulong),
                F32 => typeof(float),
                F64 => typeof(double),
                _ => default
            };

        /// <summary>
        /// Determines a sub-classification c := {'u' | 'i' | 'f'} according to whether a classified primal type
        /// is unsigned integral, signed integral or floating-point
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static NumericIndicator Indicator(this NumericKind k)
            => NumericType.indicator(k);

        /// <summary>
        /// Specifies the bit-width of a classified cpu vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static string Signature(this NumericKind k)
            => NumericType.signature(k);

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
        /// For a type that encodes a natural number, returns the corresponding value; otherwise, returns null
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Option<ulong> NatValue(this Type t)
            => t.IsNat() ? ((ITypeNat)Activator.CreateInstance(t)).NatValue : default;

        public static Option<Moniker> NatSpanIdentity(this Type src)
        {
            if(src.IsNatSpan())
            {
                var typeargs = src.GetGenericArguments().ToArray();                    
                var text = "ns";
                text += typeargs[0].NatValue();
                text += Moniker.SegSep;
                text += NumericType.signature(typeargs[1]);
                return Moniker.Parse(text);
            }
            else
                return default;
        }

        /// <summary>
        /// Determines whether a type is parametric over the natural numbers
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSpan(this Type t, bool includeReadOnly = true)
            => (t.GenericDefinition() == typeof(Span<>))||(includeReadOnly && t.GenericDefinition() == typeof(ReadOnlySpan<>));
            
        /// <summary>
        /// Specifies the bit-width of a classified cpu vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static int BitWidth(this VectorKind k)
            => VectorType.width(k);

        /// <summary>
        /// Determines whether kind has a nonzero value
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSome(this VectorKind k)
            => k != VectorKind.None;

        /// <summary>
        /// Determines whether a type is an intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsVector(this Type t)
            => VectorType.test(t);

        /// <summary>
        /// Determines whether kind has a nonzero value
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSome(this BlockKind k)
            => k != BlockKind.None;

        /// <summary>
        /// Determines whether a type is blocked memory store
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsBlocked(this Type t)
            => BlockedType.test(t);

        /// <summary>
        /// Returns true if the source type is intrinsic or blocked
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSegmented(this Type t)
            => Types.segmented(t);

        /// <summary>
        /// Divines the bit-width of a specified type, if possible
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static FixedWidth Width(this Type t)
            => Types.width(t);

        [MethodImpl(Inline)]
        public static string PrimalKeyword(this Type src)
            => DataTypes.keyword(src).ValueOrDefault(string.Empty);

        [MethodImpl(Inline)]
        public static bool IsPrimal(this Type src)
            => src.IsPrimalNumeric() || src.IsBool() || src.IsVoid() || src.IsChar() || src.IsString();

        /// <summary>
        /// Retrives the primal kind of the first type parameter, if any
        /// </summary>
        /// <param name="method">The method to test</param>
        /// <param name="n">The generic parameter selector</param>
        [MethodImpl(Inline)]
        public static NumericKind TypeParameterKind(this MethodInfo method, N1 n)
            => (method.IsGenericMethod ? method.GetGenericArguments() : array<Type>()).FirstOrDefault()?.NumericKind() ?? Z0.NumericKind.None;

        [MethodImpl(Inline)]
        public static TernaryBitLogicKind Next(this TernaryBitLogicKind src)
            => src != TernaryBitLogicKind.XFF 
                ? (TernaryBitLogicKind)((uint)(src) + 1u)
                : TernaryBitLogicKind.X00;        
    }
}