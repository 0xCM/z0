//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    partial class XTend
    {
        public static string GetName(this ClrHandleKind kind)
            => kind switch
        {
            ClrHandleKind.WeakShort => "weak short handle",
            ClrHandleKind.WeakLong => "weak long handle",
            ClrHandleKind.Strong => "strong handle",
            ClrHandleKind.Pinned => "pinned handle",
            ClrHandleKind.RefCounted => "ref counted handle",
            ClrHandleKind.Dependent => "dependent handle",
            ClrHandleKind.AsyncPinned => "async pinned handle",
            ClrHandleKind.SizedRef => "sized ref handle",
            ClrHandleKind.WeakWinRT => "weak WinRT handle",
            _ => "unknown handle"
        };

        public static bool IsPrimitive(this ClrMdTypeCode src)
        {
            return src >= ClrMdTypeCode.Bool8 && src <= ClrMdTypeCode.Float64
                || src == ClrMdTypeCode.IntI || src == ClrMdTypeCode.IntU
                || src == ClrMdTypeCode.Ptr || src == ClrMdTypeCode.PtrFx;
        }

        public static bool IsValueType(this ClrMdTypeCode src)
            => src == ClrMdTypeCode.Struct;

        public static bool IsObjectReference(this ClrMdTypeCode src)
        {
            return src == ClrMdTypeCode.String || src == ClrMdTypeCode.Class
                || src == ClrMdTypeCode.Array || src == ClrMdTypeCode.Cells
                || src == ClrMdTypeCode.Object;
        }

        public static Type GetTypeForElementType(this ClrMdTypeCode src)
        {
            switch (src)
            {
                case ClrMdTypeCode.Bool8:
                    return typeof(bool);

                case ClrMdTypeCode.Char16:
                    return typeof(char);

                case ClrMdTypeCode.Float64:
                    return typeof(double);

                case ClrMdTypeCode.Float32:
                    return typeof(float);

                case ClrMdTypeCode.Ptr:
                case ClrMdTypeCode.IntI:
                case ClrMdTypeCode.PtrFx:
                    return typeof(IntPtr);

                case ClrMdTypeCode.IntU:
                    return typeof(UIntPtr);

                case ClrMdTypeCode.Int16i:
                    return typeof(short);

                case ClrMdTypeCode.Int32i:
                    return typeof(int);

                case ClrMdTypeCode.Int64i:
                    return typeof(long);

                case ClrMdTypeCode.Int8i:
                    return typeof(sbyte);

                case ClrMdTypeCode.Int16u:
                    return typeof(ushort);

                case ClrMdTypeCode.Int32u:
                    return typeof(uint);

                case ClrMdTypeCode.Int64u:
                    return typeof(ulong);

                case ClrMdTypeCode.Int8u:
                    return typeof(byte);

                default:
                    return null;
            }
        }

    }
}