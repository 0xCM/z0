//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;
    using static BlittableKind;
    using static BitFlow.Meta;

    partial struct BitFlow
    {
        [MethodImpl(Inline), Op]
        public static DataType type(BlittableKind kind, BitWidth content, BitWidth storage)
            => new DataType(kind, content, storage);

        [Op]
        public static string format(DataType src)
        {
            const byte Max = 64;
            var i=0u;
            Span<char> dst = stackalloc char[Max];
            text.copy(indicator(src.Kind).Format(), ref i, dst);
            switch(src.Kind)
            {
                case Unsigned:
                case Signed:
                case Float:
                text.copy(src.ContentWidth.ToString(), ref i, dst);
                break;
                case BlittableKind.Char:
                break;
                case BlittableKind.Enum:
                break;
                case Vector:
                break;
                case BlittableKind.Array:
                break;
                case BlittableKind.Tensor:
                break;
                case BlittableKind.Domain:
                break;
                case BlittableKind.Seq:
                break;
                case BlittableKind.Grid:
                break;
                case BlittableKind.Name:
                break;
                default:
                break;
            }

            return text.format(slice(dst,0,i));
        }

        /// <summary>
        /// Specifies a concrete data type
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public readonly struct DataType
        {
            public readonly BlittableKind Kind;

            public readonly uint ContentWidth;

            public readonly uint StorageWidth;

            [MethodImpl(Inline)]
            public DataType(BlittableKind kind, BitWidth content, BitWidth storage)
            {
                Kind = kind;
                ContentWidth = content;
                StorageWidth = storage;
            }

            public string Format()
                => format(this);

            public override string ToString()
                => Format();
        }

        /// <summary>
        /// Specifies a parametric data type
        /// </summary>
        public readonly struct DataType<T>
            where T : ITypeParameter
        {

        }

        public interface ITypeParameter
        {
            text7 ParameterName {get;}
        }

        public interface ITypeParameter<T> : ITypeParameter
            where T : IPrimitive
        {

        }
    }
}