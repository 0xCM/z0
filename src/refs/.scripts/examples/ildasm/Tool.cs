//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = Tools;

    using P2 = Pow2x16;


    public readonly struct IlDasm : ITextual
    {

        [MethodImpl(Inline), Op]
        public IlDasm ildasm(params string[] args)
            => new IlDasm(Paths.IlDasm, args);


        public FS.FilePath IlDasm {get;}
            = FS.path(@"J:\lang\net\runtime\artifacts\toolset\ilasm\ildasm.exe");

        [MethodImpl(Inline)]
        public static implicit operator ToolCommand(IlDasm src)
            => new ToolCommand(src.ToolPath, src.Args);

        public FS.FilePath ToolPath {get;}

        public ToolArgs Args {get;}

        [MethodImpl(Inline)]
        public IlDasm(FS.FilePath path, ToolArgs args)
        {
            ToolPath = path;
            Args = args;
        }

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        [Flags]
        public enum FlagKind : ushort
        {
            None,
            NOBAR = P2.P2ᐞ00,

            BYTES = P2.P2ᐞ01,

            TOKENS = P2.P2ᐞ02,

            RAWEH = P2.P2ᐞ03,

            LINENUM = P2.P2ᐞ04,

            TYPELIST = P2.P2ᐞ05,

            HEADERS = P2.P2ᐞ06,

            STATS = P2.P2ᐞ07,

            CLASSLIST = P2.P2ᐞ08,

            METADATA = P2.P2ᐞ09,
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