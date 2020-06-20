//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using static Konst;
    using static Memories;
    
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public abstract class t_asm<U> : UnitTest<U,CheckVectors,ICheckVectors>
        where U : t_asm<U>
    {     
        protected ICaptureArchive CodeArchive 
            => Archives.Services.CaptureArchive(UnitRoot);
        
        protected StreamWriter FileStreamWriter([Caller] string caller = null)
            => CodeArchive.HexPath(FileName.Define(caller)).Writer();

        protected new IAsmContext Context;
        
        public t_asm()
        {
            Context = AsmContext.Create(AppSettings.Empty, Queue, Api);
            AsmCheck = AsmTester.Create(Context);
            UnitRoot.Clear();
        }

        protected readonly IAsmTester AsmCheck;

        protected StreamWriter AsmCaseWriter([Caller] string caller = null)
            => CaseWriter(FileExtensions.Asm,caller);

        protected BufferSeqId Main 
            => BufferSeqId.Main;

        protected BufferSeqId Left 
            => BufferSeqId.Left;

        protected BufferSeqId Right 
            => BufferSeqId.Right;

        protected IUriCodeWriter HexWriter([Caller] string caller = null)
        {            
            var dstPath = CodeArchive.HexPath(FileName.Define(caller, FileExtensions.Hex));
            return Archives.Services.UriCodeWriter(dstPath);
        }

        protected IAsmFunctionWriter AsmWriter([Caller] string caller = null)
        {
            var dst = CodeArchive.AsmPath(FileName.Define($"{caller}", FileExtensions.Asm));
            return AsmCore.Services.AsmWriter(dst, AsmFormatSpec.WithSectionDelimiter);
        }

        protected UriCode[] ReadHostBits(ApiHostUri host)
        {            
            var paths = AppPaths.ForApp(PartId.Control);
            var root = paths.AppCapturePath;
            var capture = Archives.Services.CaptureArchive(root);
            return UriCodeReader.Service.Read(capture.HexPath(host)).ToArray();
        }

        protected AsmInstructionList[] DecodeHostBits(ApiHostUri[] hosts)
        {
            var decoder = AsmCheck.Decoder;

            var totalCount = 0ul;
            var hostCount = 0ul;

            var dst = Root.list<AsmInstructionList>();

            void Decoded(Instruction i)
            {
                hostCount++;
                totalCount++;                
            }

            foreach(var host in hosts)
            {
                hostCount = 0;
                var bits = ReadHostBits(host).ToArray();
                foreach(var f in bits) 
                    decoder.Decode(f.Encoded, Decoded).OnSome(i => dst.Add(i));                    
            }

            return dst.ToArray();
        }

    }
}