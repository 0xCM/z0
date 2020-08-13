//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct Flow
    {
        [Op]
        public static FormatPatterns patterns(Type type)            
        {
            var fields = span(type.LiteralFields().Where(f => f.FieldType == typeof(string)));
            var count = fields.Length;            
            var buffer = alloc<FormatPattern>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
            {
                var field = skip(fields,i);
                var value = (string) field.GetRawConstantValue();
                seek(dst,i) = new FormatPattern(field, value);
            }
            return new FormatPatterns(buffer);
        }

        [MethodImpl(Inline), Op]
        static ReadOnlySpan<string> describe(FormatPatterns src)
            => src.Descriptions;

        /// <summary>
        /// Defines the default field delimiter
        /// </summary>
        public const string FieldSep = " | ";

        /// <summary>
        /// Defines the default content separator
        /// </summary>
        public const string ContentSep = ": ";

        /// <summary>
        /// Defines the default file extension part separator
        /// </summary>
        public const string ExtPartSep = ".";

        /// <summary>
        /// Defines the default extension for structured data
        /// </summary>
        public const string DataFileExt = "csv";

        public const string Plural = "s";

        public const string IdMarker = Slot0 + FieldSep;

        public const string ContentMarker = ContentSep + Slot0;

    }
}