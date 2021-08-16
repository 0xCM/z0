//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".api-host-list")]
        Outcome ApiHostList(CmdArgs args)
        {
            var result = Outcome.Success;

            var src = ApiArchive.HexPackRoot();
            var ext = FS.ext(FS.ext("parsed"), FS.XPack);
            var files = src.Files(ext).ToReadOnlySpan();
            var count = files.Length;
            for(var i=0; i<count; i++)
            {
                var file = skip(files,i);
                var elements = file.FileName.Format().Split(Chars.Dot).ToReadOnlySpan();
                if(elements.Length < 2)
                    continue;

                var part = skip(elements,0);
                var id = ApiPartIdParser.single(part);
                if(id == 0)
                    continue;

                var uri = ApiHostUri.define(id,skip(elements,1));
                Write(uri);

                result = Z0.HexPacks.load(file, out var pack);
                if(result.Fail)
                    return result;
            }

            return result;
        }
    }
}