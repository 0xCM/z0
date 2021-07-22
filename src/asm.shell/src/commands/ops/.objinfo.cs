//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".objinfo")]
        Outcome ObjInfo(CmdArgs args)
        {
            var id = arg(args,0).Value;
            var src = AsmWs.ObjPath(id);
            if(!src.Exists)
                return (false,FS.missing(src));
            using var reader = PeReader.create(src);
            var info = reader.ReadCoffInfo();
            var formatter = info.Formatter();
            Write(formatter.Format(info, RecordFormatKind.KeyValuePairs));
            return true;
        }
    }
}