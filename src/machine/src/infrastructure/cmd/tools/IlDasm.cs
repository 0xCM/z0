//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cmd
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct IlDasm : ICmdTool<IlDasm, IlDasm.FlagKind>
    {
        public string Name
            => ToolName;

        public string FlagMarker
            => FlagIndicator;
        
        const string ToolName = "ildasm.exe";
        
        const string FlagIndicator = "/";

        const string METADATA = nameof(METADATA);

        [MethodImpl(Inline)]
        public static CmdOption metadata(MetadataKind kind)
            => (METADATA,$"{kind}");

        public static CmdSpec @default()
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