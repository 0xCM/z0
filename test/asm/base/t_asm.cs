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
    
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public abstract class t_asm<U> : UnitTest<U,CheckVectors,TCheckVectors>
        where U : t_asm<U>
    {     
        protected TCaptureArchive TargetArchive 
            => Archives.Services.CaptureArchive(UnitDataDir);
        
        protected StreamWriter FileStreamWriter([Caller] string caller = null)
            => TargetArchive.HexPath(FileName.Define(caller)).Writer();

        protected new IAsmContext Context;
        
        IAppContext AppContext 
            => Z0.AppContext.Create(Api, Random, base.Context.Settings, Queue);
        
        public t_asm()
        {
            Context = AsmContext.Create(AppContext);
            AsmCheck = AsmTester.Create(Context);
            UnitDataDir.Clear();
        }

        protected readonly TAsmTester AsmCheck;

        protected StreamWriter AsmCaseWriter([Caller] string caller = null)
            => CaseWriter(FileExtensions.Asm,caller);

        protected BufferSeqId Main 
            => BufferSeqId.Main;

        protected BufferSeqId Left 
            => BufferSeqId.Left;

        protected BufferSeqId Right 
            => BufferSeqId.Right;

        protected IMemberCodeWriter HexWriter([Caller] string caller = null)
        {            
            var dstPath = TargetArchive.HexPath(FileName.Define(caller, FileExtensions.Hex));
            return Archives.Services.MemberCodeWriter(dstPath);
        }

        protected IAsmFunctionWriter AsmWriter([Caller] string caller = null)
        {
            var dst = TargetArchive.AsmPath(FileName.Define($"{caller}", FileExtensions.Asm));
            return AsmCore.Services.AsmWriter(dst, AsmFormatSpec.WithSectionDelimiter);
        }

        protected MemberCode[] ReadHostBits(ApiHostUri host)
        {            
            var paths = AppPaths.ForApp(PartId.Control);
            var root = paths.AppCaptureRoot;
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