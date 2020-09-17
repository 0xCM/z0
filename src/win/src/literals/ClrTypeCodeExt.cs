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

        public static bool IsPrimitive(this ClrTypeCode src)
        {
            return src >= ClrTypeCode.Bool8 && src <= ClrTypeCode.Float64
                || src == ClrTypeCode.IntI || src == ClrTypeCode.IntU
                || src == ClrTypeCode.Ptr || src == ClrTypeCode.PtrFx;
        }

        public static bool IsValueType(this ClrTypeCode src)
            => src == ClrTypeCode.Struct;

        public static bool IsObjectReference(this ClrTypeCode src)
        {
            return src == ClrTypeCode.String || src == ClrTypeCode.Class
                || src == ClrTypeCode.Array || src == ClrTypeCode.Cells
                || src == ClrTypeCode.Object;
        }

        public static Type GetTypeForElementType(this ClrTypeCode src)
        {
            switch (src)
            {
                case ClrTypeCode.Bool8:
                    return typeof(bool);

                case ClrTypeCode.Char16:
                    return typeof(char);

                case ClrTypeCode.Float64:
                    return typeof(double);

                case ClrTypeCode.Float32:
                    return typeof(float);

                case ClrTypeCode.Ptr:
                case ClrTypeCode.IntI:
                case ClrTypeCode.PtrFx:
                    return typeof(IntPtr);

                case ClrTypeCode.IntU:
                    return typeof(UIntPtr);

                case ClrTypeCode.Int16i:
                    return typeof(short);

                case ClrTypeCode.Int32i:
                    return typeof(int);

                case ClrTypeCode.Int64i:
                    return typeof(long);

                case ClrTypeCode.Int8i:
                    return typeof(sbyte);

                case ClrTypeCode.Int16u:
                    return typeof(ushort);

                case ClrTypeCode.Int32u:
                    return typeof(uint);

                case ClrTypeCode.Int64u:
                    return typeof(ulong);

                case ClrTypeCode.Int8u:
                    return typeof(byte);

                default:
                    return null;
            }
        }

    }
}