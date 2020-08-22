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
        protected IPartCaptureArchive TargetArchive
            => Archives.Services.CaptureArchive(UnitDataDir);

        protected new IAsmContext Context;

        public t_asm()
        {
            Context = new AsmContext(Flow.app());
            AsmCheck = AsmTest.tester(Context);
            UnitDataDir.Clear();
        }

        protected readonly TAsmTester AsmCheck;

        protected StreamWriter AsmCaseWriter([Caller] string caller = null)
            => CaseWriter(FileExtensions.Asm,caller);

        protected BufferSeqId Main
            => BufferSeqId.Main;


        protected IMemberCodeWriter HexWriter([Caller] string caller = null)
        {
            var dstPath = TargetArchive.HexPath(FileName.Define(caller, FileExtensions.HexLine));
            return Archives.Services.MemberCodeWriter(dstPath);
        }

        protected IAsmTextWriter AsmWriter([Caller] string caller = null)
        {
            var dst = TargetArchive.AsmPath(FileName.Define($"{caller}", FileExtensions.Asm));
            return AsmCore.Services.AsmWriter(dst, AsmFormatSpec.DefaultStreamFormat);
        }

        protected MemberCode[] ReadHostBits(ApiHostUri host)
        {
            var paths = AppPaths.ForApp(PartId.Control);
            var root = paths.AppCaptureRoot;
            var capture = Archives.Services.CaptureArchive(root);
            return UriCodeReader.Service.Read(capture.HexPath(host)).ToArray();
        }

        protected AsmFxList[] DecodeHostBits(ApiHostUri[] hosts)
        {
            var decoder = AsmCheck.Decoder;

            var totalCount = 0ul;
            var hostCount = 0ul;

            var dst = Root.list<AsmFxList>();

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