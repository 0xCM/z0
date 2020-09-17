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

    [ApiHost]
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
        public static bool primitive(ClrTypeCode src)
        {
            return src >= ClrTypeCode.Bool8 && src <= ClrTypeCode.Float64
                || src == ClrTypeCode.IntI || src == ClrTypeCode.IntU
                || src == ClrTypeCode.Ptr || src == ClrTypeCode.PtrFx;
        }

        [MethodImpl(Inline), Op]
        public static bool valuetype(ClrTypeCode src)
            => src == ClrTypeCode.Struct;

        [MethodImpl(Inline), Op]
        public static bool objref(ClrTypeCode src)
        {
            return src == ClrTypeCode.String || src == ClrTypeCode.Class
                || src == ClrTypeCode.Array || src == ClrTypeCode.Cells
                || src == ClrTypeCode.Object;
        }

        /// <summary>
        /// Gets the <see cref='System.Type' /> represented by the <see cref='ClrTypeCode'/>
        /// </summary>
        /// <param name="src">The model element type</param>
        [Op]
        public static Type represented(ClrTypeCode src)
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