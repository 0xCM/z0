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

    public abstract class t_asm<U> : UnitTest<U,CheckVectors,ICheckVectors>
        where U : t_asm<U>
    {
        protected IPartCapturePaths TargetArchive
            => ApiArchives.capture(UnitDataDir);

        protected new IAsmContext Context;

        public t_asm()
        {
            Context = new AsmContext(Apps.context());
            AsmCheck = AsmTest.tester(Context);
            UnitDataDir.Clear();
        }

        protected readonly TAsmTester AsmCheck;

        protected StreamWriter AsmCaseWriter([Caller] string caller = null)
            => CaseWriter(FileExtensions.Asm,caller);

        protected BufferSeqId Main
            => BufferSeqId.Main;

        protected IApiCodeWriter HexWriter([Caller] string caller = null)
        {
            var dstPath = TargetArchive.HexPath(FileName.define(caller, FileExtensions.HexLine));
            return ApiArchives.hexwriter<ApiCodeWriter>(FS.path(dstPath.Name));
        }

        protected IAsmWriter AsmWriter([Caller] string caller = null)
        {
            var dst = TargetArchive.AsmPath(FileName.define($"{caller}", FileExtensions.Asm));
            return AsmServices.Services.AsmWriter(dst, AsmFormatConfig.DefaultStreamFormat);
        }

        protected ApiCodeBlock[] ReadHostBits(ApiHostUri host)
        {
            var paths = AppPaths.ForApp(PartId.Control);
            var root = paths.AppCaptureRoot;
            var capture = ApiArchives.capture(root);
            var archive = ApiArchives.hex(FS.dir(root.Name));
            return archive.Read(capture.HexPath(host)).ToArray();
        }

        protected AsmFxList[] DecodeHostBits(ApiHostUri[] hosts)
        {
            var decoder = AsmCheck.Decoder;

            var totalCount = 0ul;
            var hostCount = 0ul;

            var dst = z.list<AsmFxList>();

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
                    decoder.Decode(f, Decoded).OnSome(i => dst.Add(i));
            }

            return dst.ToArray();
        }
    }
}