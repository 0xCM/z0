//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    public readonly ref partial struct AsmRecapture
    {
        readonly IAsmContext Context;

        public FolderPath ResIndexDir
            => Context.Paths.ResIndexDir;

        public FolderPath ResBytesDir
            => Context.Paths.AppDataRoot + FolderName.Define("resbytes");

        /// <summary>
        /// The x86 resource assembly output path - which was created by disassembling most of z0
        /// </summary>
        public FilePath ResBytesCompiled
            => FilePath.Define(@"J:\dev\projects\z0-logs\res\bin\lib\netcoreapp3.0\z0.res.dll");

        /// <summary>
        /// The target directory that receives data obtained by disassembling the resource disassembly file <see cref='ResBytesCompiled'/>
        /// </summary>
        public FolderPath ResBytesUncompiled
            => ResBytesDir + FolderName.Define("asm");

        [MethodImpl(Inline)]
        public AsmRecapture(IAsmContext context)
        {
            Context = context;
            Context.Paths.AppDataRoot.Clear();
            ResIndexDir.Clear();
            ResBytesDir.Clear();
            ResBytesUncompiled.Clear();
        }

        public void Dispose()
        {

        }
    }
}