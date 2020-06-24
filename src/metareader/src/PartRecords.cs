//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public partial class PartRecords
    {
        public static StringValueRecord Strings => default;
        
        public static BlobRecord Blobs => default;
        
        public static ConstantRecord Constants => default;

        public static FieldRecord Fields => default;

        public static LiteralRecord Literals => default;

        public static FieldRvaRecord FieldRva => default;

        [MethodImpl(Inline)]
        public static ReadOnlySpan<string> labels<K>(K k) 
            where K : unmanaged, IPartRecordSpec
                => k.HeaderFields;

        [MethodImpl(Inline)]
        public static byte count<K>(K k) 
            where K : unmanaged, IPartRecordSpec
                => k.FieldCount;

        [MethodImpl(Inline)]
        public static string header<K>(K k = default) 
            where K : unmanaged, IPartRecordSpec
                => k.HeaderText;

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> widths<K>(K k) 
            where K : unmanaged, IPartRecordSpec
                => k.FieldWidths;
        [MethodImpl(Inline)]
        public static string hex(int src)
            => src.FormatHex(zpad:true, specifier:true, prespec:false);

        [MethodImpl(Inline)]
        public static string hex(int src, int width)
            => src.FormatHex(zpad:true, specifier:true, prespec:false).PadRight(width);                                                                
    }
}