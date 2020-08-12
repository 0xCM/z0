//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    
    using api = Tooling;

    public partial struct IlDasm
    {
        [MethodImpl(Inline), Op]
        public static ToolSpec specify(IlDasm.FlagKind[] flags, ToolOption[] options)
            => api.specify(flags, options, default(IlDasm));

        [MethodImpl(Inline), Op]
        public static ToolOption option(IlDasm.OptionKind kind, string value)
            => api.value(kind, value);

        [MethodImpl(Inline), Op]
        public static string name(IlDasm.FlagKind @enum)
            => api.name<IlDasm.FlagKind>(@enum);
                
        public const string ToolName = "ildasm";
        
        public const string FlagIndicator = "/";

        const string METADATA = nameof(METADATA);

        [MethodImpl(Inline)]
        public static ToolOption metadata(MetadataKind kind)
            => (METADATA,$"{kind}");

        public static ToolSpec @default()
            => default;        
        
        [Flags]
        public enum FlagKind : ushort
        {
            NOBAR,
            
            BYTES,
            
            TOKENS,
            
            RAWEH,
            
            LINENUM,

            TYPELIST,

            HEADERS,

            STATS,

            CLASSLIST,

            METADATA,
        }

        [Flags]
        public enum MetadataKind : byte
        {
            MDHEADER,
            
            HEX,
            
            HEAPS,
            
            RAW,
            
            UNREX
        }

        public enum OptionKind : byte
        {
            Metadata,

            Out
        }
    }
}