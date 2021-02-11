//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.IO;
    using System.Linq;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public abstract class t_asm<U> : UnitTest<U,CheckVectors,ICheckVectors>
        where U : t_asm<U>
    {
        protected IPartCapturePaths TargetArchive
            => Archives.capture(UnitDataDir);

        protected new IAsmContext Context;

        AsmServices Services;

        public t_asm()
        {
            Context = AsmServices.context(Wf);
            AsmCheck = Z0.AsmChecks.tester(Context);
            UnitDataDir.Clear();
            Services = AsmServices.create(Wf,Context);
        }

        protected readonly IAsmChecker AsmCheck;

        protected StreamWriter AsmCaseWriter([Caller] string caller = null)
            => CaseWriter(FileExtensions.Asm,caller);

        protected BufferSeqId Main
            => BufferSeqId.Main;

        protected IApiHexWriter HexWriter([Caller] string caller = null)
        {

            var dstPath = TargetArchive.HexPath(FS.file(caller, FileExtensions.Hex));
            return Archives.hexwriter<ApiExtractWriter>(dstPath);
        }

        protected IAsmWriter AsmWriter([Caller] string caller = null)
            => Services.AsmWriter(TargetArchive.AsmPath(FS.file($"{caller}", FileExtensions.Asm)), AsmFormatConfig.DefaultStreamFormat);

        protected Index<ApiCodeBlock> ReadHostBits(ApiHostUri host)
        {
            var paths = AppPaths.ForApp();
            var root = paths.AppCaptureRoot;
            var capture = Archives.capture(root);
            var archive = Archives.extract(Wf, root);
            return archive.Read(capture.HexPath(host));
        }

        protected IceInstructionList[] DecodeHostBits(ApiHostUri[] hosts)
        {
            var decoder = AsmCheck.Decoder;

            var totalCount = 0ul;
            var hostCount = 0ul;

            var dst = z.list<IceInstructionList>();

            void Decoded(IceInstruction i)
            {
                hostCount++;
                totalCount++;
            }

            foreach(var host in hosts)
            {
                hostCount = 0;
                var bits = ReadHostBits(host);
                foreach(var f in bits)
                    decoder.Decode(f, Decoded).OnSome(i => dst.Add(i));
            }

            return dst.ToArray();
        }
    }
}