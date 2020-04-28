//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using static Seed;
    using static Memories;
    
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public abstract class t_asm<U> : UnitTest<U,CheckVectors,ICheckVectors>
        where U : t_asm<U>
    {     
        protected ICaptureArchive CodeArchive 
            => Archives.Services.CaptureArchive(DataDir);
        
        protected StreamWriter FileStreamWriter([Caller] string caller = null)
            => CodeArchive.HexPath(FileName.Define(caller)).Writer();

        protected new IAsmContext Context;
        
        public t_asm()
        {
            Context = AsmContext.Create(AppSettings.Empty, Queue, Api);
            AsmCheck = AsmTester.Create(Context);
        }

        protected readonly IAsmTester AsmCheck;

        protected StreamWriter AsmCaseWriter([Caller] string caller = null)
            => CaseFileWriter(FileExtensions.Asm,caller);

        protected BufferSeqId Main => BufferSeqId.Main;

        protected BufferSeqId Left => BufferSeqId.Left;

        protected BufferSeqId Right => BufferSeqId.Right;

        protected IBitArchiveWriter HexWriter([Caller] string caller = null)
        {            
            var dstPath = CodeArchive.HexPath(FileName.Define(caller, FileExtensions.Hex));
            return Archives.Services.BitArchiveWriter(dstPath);
        }

        protected IAsmFunctionWriter AsmWriter([Caller] string caller = null)
        {
            var dst = CodeArchive.AsmPath(FileName.Define($"{caller}", FileExtensions.Asm));
            return AsmCore.Services.AsmWriter(dst, AsmFormatSpec.WithSectionDelimiter);
        }
    }
}