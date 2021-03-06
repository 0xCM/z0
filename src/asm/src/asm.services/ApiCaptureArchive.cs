//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    class ApiCaptureArchive : WfService<ApiCaptureArchive, IApiCaptureArchive>, IApiCaptureArchive
    {
        public ApiCaptureArchive()
        {

        }

        public void Clear()
        {
            foreach(var part in Wf.Api.PartIdentities)
                Clear(part);
        }

        IDbPaths Paths;

        protected override void OnInit()
        {
            base.OnInit();

            Paths = Wf.Db();
        }

        void Clear(PartId part)
        {
            var total = 0u;
            total += ClearExtracts(part);
            total += ClearParsed(part);
            total += ClearAsm(part);
            total += ClearHex(part);
            total += ClearCil(part);
            TotalStatus(part,total);
        }

        static Outcome<uint> Clear(FS.Files src)
            => src.Delete();

        const string TypeStatusPattern = "Cleared {0} *.{1} {2} files";

        const string TotalStatusPattern = "Cleared {0} total {1} files";

        void TypeStatus(PartId part, FS.FileExt ext, Count count)
            => Wf.Status(string.Format(TypeStatusPattern, count, ext, part.Format()));

        void TotalStatus(PartId part, Count count)
            => Wf.Status(string.Format(TotalStatusPattern, count, part.Format()));

        Outcome<uint> ClearExtracts(PartId part)
        {
            var kind = FS.Extensions.XCsv;
            var files = Paths.RawExtractFiles(part);
            var result = Clear(files);
            if(result)
                TypeStatus(part, kind, result.Data);
            else
                Wf.Error(result.Message);
            return result;
        }

        Outcome<uint> ClearParsed(PartId part)
        {
            var kind = FS.Extensions.PCsv;
            var files = Paths.ParsedExtractFiles(part);
            var result = Clear(files);
            if(result)
                TypeStatus(part, kind, result.Data);
            else
                Wf.Error(result.Message);
            return result;
        }

        Outcome<uint> ClearAsm(PartId part)
        {
            var kind = FS.Extensions.Asm;
            var files = Paths.AsmFiles(part);
            var result = Clear(files);
            if(result)
                TypeStatus(part, kind, result.Data);
            else
                Wf.Error(result.Message);
            return result;
        }

        Outcome<uint> ClearHex(PartId part)
        {
            var kind = FS.Extensions.Hex;
            var files = Paths.ApiHexFiles(part);
            var result = Clear(files);
            if(result)
                TypeStatus(part, kind, result.Data);
            else
                Wf.Error(result.Message);
            return result;
        }

        Outcome<uint> ClearCil(PartId part)
        {
            var kind = FS.Extensions.IlData;
            var files = Paths.CilDataFiles(part);
            var result = Clear(files);
            if(result)
                TypeStatus(part, kind, result.Data);
            else
                Wf.Error(result.Message);
            return result;
        }
    }
}