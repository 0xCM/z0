//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public sealed class AsmServices : IAsmServices
    {
        public static AsmServices init(IWfShell wf, IAsmContext asm)
            => new AsmServices(wf, asm);

        IWfShell Wf {get;}

        IAsmContext Asm {get;}

        [MethodImpl(Inline)]
        AsmServices(IWfShell wf, IAsmContext asm)
        {
            Wf = wf;
            Asm = asm;
        }

        [MethodImpl(Inline), Op]
        public IAsmDecoder Decoder()
            => new AsmRoutineDecoder(Asm.FormatConfig);

        [MethodImpl(Inline), Op]
        public IAsmImmWriter ImmWriter(ApiHostUri host, FS.FolderPath dst)
            => new AsmImmWriter(host, Asm.Formatter, dst);

        [MethodImpl(Inline), Op]
        public AsmSemanticRender SemanticRender()
            => new AsmSemanticRender(Wf);

        [Op]
        public IAsmImmWriter ImmWriter(ApiHostUri host)
            => ImmWriter(host, Wf.Db().ImmRoot());

        [MethodImpl(Inline), Op]
        public static IAsmDecoder Decoder(in AsmFormatConfig config)
            => new AsmRoutineDecoder(config);
    }
}