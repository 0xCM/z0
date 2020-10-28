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


    [ApiHost(ToolApiNames.Dumpbin, true)]
    public partial struct DumpBin
    {
        readonly IWfShell Wf;

        public ToolInfo Description {get;}

        public FS.FolderPath ToolOutput {get;}

        [Op]
        public static DumpBin create(IWfShell wf)
            => new DumpBin(wf, typeof(DumpBin));

        [Op]
        public static ToolInfo describe()
        {
            var dst = new ToolInfo();
            dst.HostName = nameof(DumpBin);
            dst.RuntimeName = "dumpbin";
            dst.FlagPrefix = "/";
            dst.ArgSpecifier = ":";
            dst.MaxVarCount = 12;
            dst.FlagNames = Enums.names<Flag>();
            return dst;
        }

        public const string FlagPrefix = AsciCharText.FS;

        const byte MaxVarCount = 12;

        const byte MaxVarIndex = MaxVarCount - 1;

        public const string ArgSpecifier = AsciCharText.Colon;

        uint ArgIndex;

        public ToolId Id {get;}

        public CmdOptions<Flag,object> Args {get;}

        [MethodImpl(Inline)]
        internal DumpBin(IWfShell wf, ToolId id)
        {
            Wf = wf;
            Id = Tooling.identify<DumpBin>();;
            Args =  alloc<CmdOption<Flag,object>>(MaxVarCount);
            ArgIndex = 0;
            Description = describe();
            ToolOutput = Wf.Db().ToolOutput(Id);

        }

        public DumpBin With<T>(Flag option, T value)
        {
            if(ArgIndex < MaxVarIndex)
            {
                Args[ArgIndex++] = Cmd.option(option, (object)value);
            }
            return this;
        }
    }
}