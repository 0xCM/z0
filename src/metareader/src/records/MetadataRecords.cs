//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public partial class MetadataRecords
    {
        const string Delimiter = " | ";

        [MethodImpl(Inline)]
        internal static Span<T> Alloc<T>(int count)
            => new T[count];

        [MethodImpl(Inline)]
        internal static ReadOnlySpan<byte> FieldWidths<K>(K k) 
            where K : unmanaged, IMetadataRecordSpec
                => k.FieldWidths;

        [MethodImpl(Inline)]
        internal static unsafe V ENumeric<E,V>(E e)
            where E : unmanaged, Enum
            where V : unmanaged
                => Unsafe.Read<V>((V*)(&e));

        [MethodImpl(Inline)]
        internal static ref T Seek<E,T>(Span<T> src, E field)
            where E : unmanaged, Enum
                => ref Control.seek(src, ENumeric<E,byte>(field));

        [MethodImpl(Inline)]
        internal static ref readonly T Skip<E,T>(ReadOnlySpan<T> src, E field)
            where E : unmanaged, Enum
                => ref Control.skip(src, ENumeric<E,byte>(field));

        [MethodImpl(Inline)]
        internal static byte FieldWidth<E>(ReadOnlySpan<byte> src, E field)
            where E : unmanaged, Enum
                => Skip(src,field);

        [MethodImpl(Inline)]
        internal static string RenderHex(int src, int width)
            => src.FormatHex(zpad:true, specifier:true, prespec:false).PadRight(width);

        [MethodImpl(Inline)]
        internal static string Render(int src, int width)
            => src.ToString().PadRight(width);

        [MethodImpl(Inline)]
        internal static string Render<T>(T src, int width)
            where T : ITextual
                => src.Format().PadRight(width);

        [MethodImpl(Inline)]
        internal static string Render(byte[] src, int width)
            => src.FormatHexBytes().PadRight(width);

        [MethodImpl(Inline)]
        internal static string Render(object src, int width)
            => src.ToString().PadRight(width);

        [MethodImpl(Inline)]
        internal static string Render(string src, int width)
            => src.PadRight(width);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<string> HeaderFields<K>(K k) 
            where K : unmanaged, IMetadataRecordSpec
                => k.HeaderFields;

        [MethodImpl(Inline)]
        public static byte FieldCount<K>(K k) 
            where K : unmanaged, IMetadataRecordSpec
                => k.FieldCount;

        [MethodImpl(Inline)]
        public static string HeaderText<K>(K k) 
            where K : unmanaged, IMetadataRecordSpec
                => k.HeaderText;

        [MethodImpl(Inline)]
        internal static ReadOnlySpan<R> EmptySpan<R>()
            => ReadOnlySpan<R>.Empty;

        public static string Delimit(ReadOnlySpan<string> fields, char delimiter = Chars.Pipe)
        {
            var dst = text.build();
            var count = fields.Length;
            for(byte i=0; i<count; i++)
            {
                dst.Append(Control.skip(fields, i));
                if(i != count - 1)
                {
                    dst.Append(delimiter);
                    dst.Append(Chars.Space);
                }
            }
            return dst.ToString();
        }

        public static string FormatHeader(ReadOnlySpan<string> fields, ReadOnlySpan<byte> widths, char delimiter = Chars.Pipe)
        {
            var dst = text.build();
            var count = fields.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var field = ref Control.skip(fields,i);
                ref readonly var width = ref Control.skip(widths,i);
                dst.Append(field.PadRight(width));
                if(i != count - 1)
                {
                    dst.Append(delimiter);
                    dst.Append(Chars.Space);
                }
            }
            return dst.ToString();
        }
    }
}