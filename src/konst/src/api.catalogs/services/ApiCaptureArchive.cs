//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

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

        IApiCaptureArchive Archive
            => this;


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
            var kind = FileExtensions.XCsv;
            var files = Archive.ApiExtractFiles(part);
            var result = Clear(files);
            if(result)
                TypeStatus(part, kind, result.Data);
            else
                Wf.Error(result.Message);
            return result;
        }

        Outcome<uint> ClearParsed(PartId part)
        {
            var kind = FileExtensions.PCsv;
            var files = Archive.ParsedExtractFiles(part);
            var result = Clear(files);
            if(result)
                TypeStatus(part, kind, result.Data);
            else
                Wf.Error(result.Message);
            return result;
        }

        Outcome<uint> ClearAsm(PartId part)
        {
            var kind = FileExtensions.Asm;
            var files = Archive.AsmFiles(part);
            var result = Clear(files);
            if(result)
                TypeStatus(part, kind, result.Data);
            else
                Wf.Error(result.Message);
            return result;
        }

        Outcome<uint> ClearHex(PartId part)
        {
            var kind = FileExtensions.Hex;
            var files = Archive.ApiHexFiles(part);
            var result = Clear(files);
            if(result)
                TypeStatus(part, kind, result.Data);
            else
                Wf.Error(result.Message);
            return result;
        }

        Outcome<uint> ClearCil(PartId part)
        {
            var kind = FileExtensions.IlData;
            var files = Archive.CilDataFiles(part);
            var result = Clear(files);
            if(result)
                TypeStatus(part, kind, result.Data);
            else
                Wf.Error(result.Message);
            return result;
        }
    }
}