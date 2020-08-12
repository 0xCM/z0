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
    using Z0.Data;

    using static Konst;
    using static z;

    [ApiHost("api")]
    public readonly partial struct Flow
    {        
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<string> describe(FormatPatterns src)
            => src.Descriptions;

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

        public static string AppName 
        {
            [MethodImpl(Inline), Op]
            get => Assembly.GetEntryAssembly().GetSimpleName();
        }
        
        public static FilePath ConfigPath(IAppContext context)
        {
            var assname = Assembly.GetEntryAssembly().GetSimpleName();
            var filename = FileName.Define(assname, FileExtensions.Json);
            var src = context.AppPaths.ConfigRoot + filename;
            return src;
        }
    }
}