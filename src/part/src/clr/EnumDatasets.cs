//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using F = EnumDatasetField;

    public readonly struct EnumDatasets
    {
        [MethodImpl(Inline)]
        public static EnumDatasetEntry untyped<E,T>(in EnumDatasetEntry<E,T> src)
            where E : unmanaged, Enum
            where T : unmanaged
                => new EnumDatasetEntry(src.Token, src.EnumId, src.Index, src.Name, memory.bw64(src.ScalarValue), src.Description);

        /// <summary>
        /// Creates an enumeration dataset predicated on supplied type parameters
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The refined primitive type</typeparam>
        public static EnumDataset<E,T> create<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var src = ClrEnums.details<E,T>();
            var count = src.Length;
            var token = Clr.token<E>();
            var datatype = ClrEnums.@base<E>();
            var description = string.Empty;
            var indices = sys.alloc<uint>(count);
            var names = sys.alloc<string>(count);
            var literals = sys.alloc<E>(count);
            var numeric = sys.alloc<T>(count);
            var descriptions = sys.alloc<string>(count);
            var tokens = sys.alloc<CliToken>(count);
            var dst = new EnumDataset<E,T>(token, description, datatype, tokens, indices,  names, literals, numeric, descriptions);
            for(var i=0; i<count; i++)
            {
                indices[i] = src[i].Position;
                names[i] = src[i].Name;
                literals[i] = src[i].LiteralValue;
                numeric[i] = src[i].PrimalValue;
                descriptions[i] = string.Empty;
                tokens[i] = src[i].Token;
            }

            return dst;
        }

        public static string header<F>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
        {
            var dst = text.build();
            var labels = ClrEnums.literals<F>();
            for(var i=0; i<labels.Length; i++)
                dst.Delimit(labels[i], labels[i].ToString(), delimiter);
            return dst.ToString();
        }

        public static string header(Type src, char delimiter = FieldDelimiter)
        {
            var dst = text.build();
            var labels = ClrEnums.literals<F>();
            for(var i=0; i<labels.Length; i++)
                dst.Delimit(labels[i], labels[i].ToString(), delimiter);
            return dst.ToString();
        }

        public static string format<E,T>(in EnumLiteralInfo<E,T> src, ITextBuffer dst, char delimiter = FieldDelimiter)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            dst.AppendDelimited(F.Token, src.Token);
            dst.AppendDelimited(F.Index, src.Position);
            dst.AppendDelimited(F.Name, src.Name);
            dst.AppendDelimited(F.Scalar, src.Scalar);
            return dst.Emit();
        }

        [MethodImpl(Inline)]
        public static string format<E,T>(in EnumDatasetEntry<E,T> src, char delimiter = FieldDelimiter)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var dst = text.build();
            dst.Delimit(F.Token, src.Token);
            dst.Delimit(F.Index, src.Index);
            dst.Delimit(F.Name, src.Name);
            dst.Delimit(F.Scalar, src.ScalarValue);
            return dst.ToString();
        }

        [MethodImpl(Inline)]
        public static string format<E,T>(in EnumLiteralInfo<E,T> src, char delimiter = FieldDelimiter)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var dst = text.build();
            dst.Delimit(F.Token, src.Token);
            dst.Delimit(F.Index, src.Position);
            dst.Delimit(F.Name, src.Name);
            dst.Delimit(F.Scalar, src.Scalar);
            return dst.ToString();
        }

    }
}