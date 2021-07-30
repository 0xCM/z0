//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".outfiles")]
        public Outcome OutFiles(CmdArgs args)
        {
            var result = Outcome.Success;
            ProjectId id = arg(args,0).Value;
            if(args.Length == 2)
            {
                var filter = arg(args,1).Value;
                if(filter.StartsWith(Chars.Dot))
                {
                    var ext = FS.ext(text.slice(filter,1));
                    Files(Projects().OutFiles(id,ext));
                }
                else
                {
                    var folder = FS.folder(filter);
                    Files(Projects().OutFiles(id,folder));
                }
            }
            else if(args.Length == 3)
            {
                var folder = FS.folder(arg(args,1).Value);
                var filter = arg(args,2).Value;
                if(!filter.StartsWith(Chars.Dot))
                    return (false, "File extension filter expected");
                var ext = FS.ext(text.slice(filter,1));
                Files(Projects().OutFiles(id,folder,ext));
            }
            else
                Files(Projects().OutFiles(id));
            return result;
        }

        //.outfiles ll
        //.outfiles ll .obj
        //.outfiles ll dumps
        //.outfiles ll dumps .rawdata.hex
    }
}