//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmRecapture
    {
        readonly IWfShell Wf;

        readonly IAsmContext Asm;

        readonly ApiResCapture ResCapture;

        [MethodImpl(Inline)]
        public AsmRecapture(IWfShell wf, IAsmContext asm)
        {
            Wf = wf;
            Asm = asm;
            Asm.Paths.AppDataRoot.Clear();
            ResCapture = Wf.ApiResCapture();
            ResIndexDir.Clear();
            ResBytesDir.Clear();
            ResBytesUncompiled.Clear();
        }

        /// <summary>
        /// All of your resbytes belong to us
        /// </summary>
        public void Run()
        {
            var resfile = ResBytesCompiled;
            // var captured =Capture(resfile, ResBytesUncompiled);
            // var csvfile = ResIndexDir + FS.file("z0.res.bytes", FileExtensions.Csv);
            // ResCapture.Emit(captured, csvfile);
        }

        public FS.FolderPath ResIndexDir
            => Asm.Paths.ResIndexDir;

        public FS.FolderPath ResBytesDir
            => Asm.Paths.AppDataDir + FS.folder("resbytes");

        // public Index<CapturedApiRes> Capture(FS.FilePath src, FS.FolderPath dst)
        //     => ResCapture.CaptureApiRes(src, dst);

        /// <summary>
        /// The x86 resource assembly output path - which was created by disassembling most of z0
        /// </summary>
        public FS.FilePath ResBytesCompiled
            => FS.path(@"J:\dev\projects\z0-logs\res\bin\lib\netcoreapp3.0\z0.res.dll");

        /// <summary>
        /// The target directory that receives data obtained by disassembling the resource disassembly file <see cref='ResBytesCompiled'/>
        /// </summary>
        public FS.FolderPath ResBytesUncompiled
            => ResBytesDir + FS.folder("asm");
    }
}