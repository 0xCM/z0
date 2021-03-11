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

        void Clear(PartId part)
        {
            var total = 0u;
            total += ClearExtracts(part);
            total += ClearParsed(part);
            total += ClearAsm(part);
            total += ClearHex(part);
            total += ClearCilData(part);
            total += ClearCilCode(part);

            TotalStatus(part,total);
        }

        static Outcome<uint> Clear(FS.Files src)
            => src.Delete();



        const string TypeStatusPattern = "Cleared <{0}> *.<{1}> <{2}> files";

        const string TotalStatusPattern = "Cleared <{0}> total <{1}> files";

        void TypeStatus(PartId part, FS.FileExt ext, Count count)
            => Wf.Status(string.Format(TypeStatusPattern, count, ext, part.Format()));

        void TotalStatus(PartId part, Count count)
            => Wf.Status(string.Format(TotalStatusPattern, count, part.Format()));

        Outcome<uint> ClearExtracts(PartId part)
        {
            var kind = FS.Extensions.XCsv;
            var files = Db.RawExtractFiles(part);
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
            var files = Db.ParsedExtractFiles(part);
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
            var files = Db.AsmFiles(part);
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
            var files = Db.ApiHexFiles(part);
            var result = Clear(files);
            if(result)
                TypeStatus(part, kind, result.Data);
            else
                Wf.Error(result.Message);
            return result;
        }

        Outcome<uint> ClearCilData(PartId part)
        {
            var kind = FS.Extensions.IlData;
            var files = Db.CilDataFiles(part);
            var result = Clear(files);
            if(result)
                TypeStatus(part, kind, result.Data);
            else
                Wf.Error(result.Message);
            return result;
        }

        Outcome<uint> ClearCilCode(PartId part)
        {
            var kind = FS.Extensions.Il;
            var files = Db.CilCodeFiles(part);
            var result = Clear(files);
            if(result)
                TypeStatus(part, kind, result.Data);
            else
                Wf.Error(result.Message);
            return result;
        }

    }
}