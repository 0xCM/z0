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

    [ApiHost("tools.external.dumpbin", true)]
    public partial struct DumpBin
    {
        [MethodImpl(Inline), Op]
        public static DumpBin create()
            => new DumpBin(typeof(DumpBin));

        [Op]
        public static CmdExpr headers(FS.FilePath src, FS.FolderPath dst)
        {
            var output = dst + src.FileName.ChangeExtension(Patterns.HeadersExt);
            return Cmd.format(Patterns.Headers,
                src.Format(PathSeparator.BS),
                output.Format(PathSeparator.BS)
                );
        }

        [Op]
        public static CmdExpr disasm(FS.FilePath src, FS.FolderPath dst)
        {
            var output = dst + src.FileName.ChangeExtension(Patterns.DisasmExt);
            return Cmd.format(Patterns.Disasm,
                src.Format(PathSeparator.BS),
                output.Format(PathSeparator.BS)
                );
        }


        public const string FlagPrefix = AsciCharText.FS;

        public const string ToolName = "dumpbin";

        public static ToolId ToolId => Tooling.identify<DumpBin>();

        public const string FlagDelimiter = AsciCharText.Colon;

        const byte MaxArgCount = 12;

        const byte MaxArgIndex = MaxArgCount - 1;

        public const string ArgSpecifier = AsciCharText.Colon;

        uint ArgIndex;

        public ToolId Id {get;}

        public CmdOptions<Flag,object> Args {get;}

        [MethodImpl(Inline)]
        internal DumpBin(ToolId id)
        {
            Id = id;
            Args =  alloc<CmdOption<Flag,object>>(MaxArgCount);
            ArgIndex = 0;
        }

        public DumpBin With<T>(Flag option, T value)
        {
            if(ArgIndex < MaxArgIndex)
            {
                Args[ArgIndex++] = Cmd.option(option, (object)value);
            }
            return this;
        }
    }
}