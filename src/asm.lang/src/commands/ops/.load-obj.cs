//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".load-obj")]
        Outcome LoadObj(CmdArgs args)
        {
            var id = arg(args,0).Value;
            var path = Workspace.ObjPath(id);
            ShoeCoffInfo(path);
            return true;
        }

        void ShoeCoffInfo(FS.FilePath src)
        {
            using var reader = PeReader.create(src);
            var info = reader.ReadCoffInfo();
            var formatter = info.Formatter();
            Write(formatter.Format(info, RecordFormatKind.KeyValuePairs));
        }
    }
}