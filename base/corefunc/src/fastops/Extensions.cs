//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;
    using System.ComponentModel;

    using static zfunc;
    
    public static partial class FastOpX
    {        
        /// <summary>
        /// Returns a kind-identified system type if possible; throws an exception otherwise
        /// </summary>
        /// <param name="k">The identifying kind</param>
        [MethodImpl(Inline)]
        public static Option<Type> ToClrType(this NumericKind k)
        {
            var nt = k.NumericType();
            return nt.IsSome() ? some(nt.Subject) : none<Type>();
        }

        [MethodImpl(Inline)]
        public static Option<char> NumericIndicator(this Type t)
        {
            if(t == typeof(bit))
                return AsciLower.u;                        
            var i = t.NumericKind().Indicator();
            return i.IsSome() ? some(i.Character()) : none<char>();
        }

        /// <summary>
        /// Gets the name of a method to which to Op attribute is applied
        /// </summary>
        /// <param name="m">The source method</param>
        public static string HostName(this Type t)
            => Identity.host(t);

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
        /// Determines whether a method has intrinsic parameters or return type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsKind(this MethodInfo m, VKT.Vec hk, bool total = false)        
            => m.IsVectorized(total);

        /// <summary>
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsKind(this MethodInfo m, VKT.Vec128 hk, bool total)        
            => m.IsVectorized(128,total);

        /// <summary>
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsKind(this MethodInfo m, VKT.Vec256 hk, bool total)        
            => m.IsVectorized(256,total);

        /// <summary>
        /// Selects methods from a stream that accept and/or return intrinsic vectors
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> OfKind(this IEnumerable<MethodInfo> src, VKT.Vec128 hk, bool total = false)
            => src.Where(m => m.IsKind(hk,total));

        /// <summary>
        /// Selects methods from a stream that accept and/or return intrinsic vectors
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> OfKind(this IEnumerable<MethodInfo> src, VKT.Vec256 hk, bool total = false)
            => src.Where(m => m.IsKind(hk,total));

        [MethodImpl(Inline)]
        public static bool IsOperator(this IFunc f)
            => (f.Kind & FunctionKind.Operator) != 0;

        [MethodImpl(Inline)]
        public static bool IsEmitter(this IFunc f)
            => (f.Kind & FunctionKind.Emitter) != 0;

        [MethodImpl(Inline)]
        public static bool IsMeasure(this IFunc f)
            => (f.Kind & FunctionKind.Measure) != 0;

        [MethodImpl(Inline)]
        public static bool IsUnary(this IFunc f)
            => (f.Kind & FunctionKind.UnaryFunc) != 0;

        [MethodImpl(Inline)]
        public static bool IsBinary(this IFunc f)
            => (f.Kind & FunctionKind.BinaryFunc) != 0;

        [MethodImpl(Inline)]
        public static bool IsVectorized(this IFunc f)
            => (f.Kind & FunctionKind.Vectorized) != 0;

        [MethodImpl(Inline)]
        public static bool IsPredicate(this IFunc f)
            => (f.Kind & FunctionKind.Predicate) != 0;

        [MethodImpl(Inline)]
        public static bool AcceptsImmediate(this IFunc f)
            => (f.Kind & FunctionKind.Imm) != 0;

        [MethodImpl(Inline)]
        public static bool AcceptsV128(this IFunc f)
            => (f.Kind & FunctionKind.V128) != 0;

        [MethodImpl(Inline)]
        public static bool AcceptsV256(this IFunc f)
            => (f.Kind & FunctionKind.V256) != 0;         

        public static string FormatBits<T>(this T src)
            where T : unmanaged, IFixed
                => BitConvert.GetBytes(in src).FormatBits();

        public static string Format<T>(this T src, NumericKind kind)
            where T : unmanaged, IFixed
        {
            var dst = BitConvert.GetBytes(in src);
            switch(kind)
            {
                case NumericKind.I8:
                    return dst.As<sbyte>().FormatList();
                case NumericKind.U8:
                    return dst.As<byte>().FormatList();
                case NumericKind.I16:
                    return dst.As<short>().FormatList();
                case NumericKind.U16:
                    return dst.As<ushort>().FormatList();
                case NumericKind.I32:
                    return dst.As<int>().FormatList();
                case NumericKind.U32:
                    return dst.As<uint>().FormatList();
                case NumericKind.I64:
                    return dst.As<long>().FormatList();
                case NumericKind.U64:
                    return dst.As<ulong>().FormatList();
                case NumericKind.F32:
                    return dst.As<float>().FormatList();
                case NumericKind.F64:
                    return dst.As<double>().FormatList();
                default:
                    throw unsupported(kind);
            }
        }
    }
}