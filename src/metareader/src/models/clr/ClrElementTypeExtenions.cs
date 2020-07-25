//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Immutable;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    using static ClrDataModel;

    internal static class ClrElementTypeExtensions
    {
        internal static ImmutableArray<T> AsImmutableArray<T>(this T[] array)
        {
            Debug.Assert(Unsafe.SizeOf<T[]>() == Unsafe.SizeOf<ImmutableArray<T>>());
            return Unsafe.As<T[], ImmutableArray<T>>(ref array);
        }

        internal static ImmutableArray<T> MoveOrCopyToImmutable<T>(this ImmutableArray<T>.Builder builder)
        {
            return builder.Capacity == builder.Count ? builder.MoveToImmutable() : builder.ToImmutable();
        }
        
        public static bool IsPrimitive(this ClrElementType cet)
        {
            return cet >= ClrElementType.Boolean && cet <= ClrElementType.Double
                || cet == ClrElementType.NativeInt || cet == ClrElementType.NativeUInt
                || cet == ClrElementType.Pointer || cet == ClrElementType.FunctionPointer;
        }

        public static bool IsValueType(this ClrElementType cet)
        {
            return cet == ClrElementType.Struct;
        }

        public static bool IsObjectReference(this ClrElementType cet)
        {
            return cet == ClrElementType.String || cet == ClrElementType.Class
                || cet == ClrElementType.Array || cet == ClrElementType.SZArray
                || cet == ClrElementType.Object;
        }

        public static Type GetTypeForElementType(this ClrElementType type)
        {
            switch (type)
            {
                case ClrElementType.Boolean:
                    return typeof(bool);

                case ClrElementType.Char:
                    return typeof(char);

                case ClrElementType.Double:
                    return typeof(double);

                case ClrElementType.Float:
                    return typeof(float);

                case ClrElementType.Pointer:
                case ClrElementType.NativeInt:
                case ClrElementType.FunctionPointer:
                    return typeof(IntPtr);

                case ClrElementType.NativeUInt:
                    return typeof(UIntPtr);

                case ClrElementType.Int16:
                    return typeof(short);

                case ClrElementType.Int32:
                    return typeof(int);

                case ClrElementType.Int64:
                    return typeof(long);

                case ClrElementType.Int8:
                    return typeof(sbyte);

                case ClrElementType.UInt16:
                    return typeof(ushort);

                case ClrElementType.UInt32:
                    return typeof(uint);

                case ClrElementType.UInt64:
                    return typeof(ulong);

                case ClrElementType.UInt8:
                    return typeof(byte);

                default:
                    return null;
            }
        }
    }
}