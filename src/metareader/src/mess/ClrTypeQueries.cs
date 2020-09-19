//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using SRM = System.Reflection.Metadata;

    using static Konst;

    public readonly struct ClrTypeQueries
    {
        [MethodImpl(Inline), Op]
        public static SRM.BlobHandle blob(uint id)
        {
            var dst = default(SRM.BlobHandle);
            z.seek<SRM.BlobHandle,uint>(dst,0) = id;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<HexCodeLo> digits(SRM.BlobHandle src)
        {
            return Structures.digits(src, LowerCase);
        }

        [MethodImpl(Inline), Op]
        public static string format(SRM.BlobHandle src)
            => Structures.format(src);

        [MethodImpl(Inline), Op]
        public static bool primitive(ClrMdTypeCode src)
        {
            return src >= ClrMdTypeCode.Bool8 && src <= ClrMdTypeCode.Float64
                || src == ClrMdTypeCode.IntI || src == ClrMdTypeCode.IntU
                || src == ClrMdTypeCode.Ptr || src == ClrMdTypeCode.PtrFx;
        }

        [MethodImpl(Inline), Op]
        public static bool valuetype(ClrMdTypeCode src)
            => src == ClrMdTypeCode.Struct;

        [MethodImpl(Inline), Op]
        public static bool objref(ClrMdTypeCode src)
        {
            return src == ClrMdTypeCode.String || src == ClrMdTypeCode.Class
                || src == ClrMdTypeCode.Array || src == ClrMdTypeCode.Cells
                || src == ClrMdTypeCode.Object;
        }

        /// <summary>
        /// Gets the <see cref='System.Type' /> represented by the <see cref='ClrMdTypeCode'/>
        /// </summary>
        /// <param name="src">The model element type</param>
        [Op]
        public static Type represented(ClrMdTypeCode src)
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