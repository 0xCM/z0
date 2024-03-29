//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public abstract class t_asm<U> : UnitTest<U,CheckVectorsHost,ICheckVectors>
        where U : t_asm<U>
    {
        protected IApiPartPaths TargetArchive
            => ApiArchives.capture(UnitDataDir);

        protected ICaptureChecks AsmChecks;

        protected override void OnShellInjected()
        {
            AsmChecks = CaptureChecks.create(Wf);
            UnitDataDir.Clear();
        }

        public t_asm()
        {

        }

        // protected StreamWriter AsmCaseWriter([Caller] string caller = null)
        //     => CaseWriter(FS.Extensions.Asm, caller);

        // protected BufferSeqId Main
        //     => BufferSeqId.Main;

        // protected IApiHexWriter HexWriter([Caller] string caller = null)
        // {
        //     var dstPath = TargetArchive.HexPath(FS.file(caller, FS.Extensions.Hex));
        //     return ApiHexWriter.create(Wf, dstPath);
        // }

        // protected IAsmWriter AsmWriter([Caller] string caller = null)
        //     => Wf.AsmWriter(TargetArchive.AsmPath(FS.file($"{caller}", FS.Extensions.Asm)));

        // protected Index<ApiCodeBlock> ReadHostBits(ApiHostUri host)
        // {
        //     var capture = ApiArchives.capture(Wf.Db().CaptureRoot());
        //     var hex = Wf.ApiHex();
        //     var rows = hex.ReadRows(capture.HexPath(host));
        //     var code = rows.Map(row => new ApiCodeBlock(row.Uri, new CodeBlock(row.Address, row.Data)));
        //     return code;
        // }

        // protected IceInstructionList[] DecodeHostBits(ApiHostUri[] hosts)
        // {
        //     var decoder = AsmChecks.Decoder;

        //     var totalCount = 0ul;
        //     var hostCount = 0ul;

        //     var dst = root.list<IceInstructionList>();

        //     void Decoded(IceInstruction i)
        //     {
        //         hostCount++;
        //         totalCount++;
        //     }

        //     foreach(var host in hosts)
        //     {
        //         hostCount = 0;
        //         var bits = ReadHostBits(host);
        //         foreach(var f in bits)
        //             decoder.Decode(f, Decoded).OnSome(i => dst.Add(i));
        //     }

        //     return dst.ToArray();
        // }
    }
}