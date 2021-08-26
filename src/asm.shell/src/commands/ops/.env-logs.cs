//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    public struct EnvVarSet
    {
        public string Name;

        public FS.FilePath Source;

        public EnvVars Vars;
    }

    partial class AsmCmdService
    {
        [CmdOp(".winsdk")]
        Outcome WinSdk(CmdArgs args)
        {
            var result = Outcome.Success;

            return result;
        }

        [CmdOp(".env-logs")]
        Outcome EnvLogs(CmdArgs args)
        {
            var result = Outcome.Success;
            var ext = FS.ext("env") + FS.Log;
            var paths = Ws.Tools().AdminFiles(ext);
            var formatter = Tables.formatter<EnvVarSet>();
            foreach(var path in paths)
            {
                result = parse(path, out EnvVarSet dst);
                if(result.Fail)
                    return result;
                Write(formatter.Format(dst, RecordFormatKind.KeyValuePairs));
            }

            return result;
        }

        static Outcome parse(FS.FilePath src, out EnvVarSet dst)
        {
            var result = Outcome.Success;
            dst.Source = src;
            dst.Name = text.left(src.FileName.Format(), Chars.Dot);
            dst.Vars = new();

            var vars = list<EnvVar>();
            using var reader = src.Utf8LineReader();
            while(reader.Next(out var line))
            {
                var content = line.Content;
                var i = text.index(content,Chars.Eq);
                if(i > 0)
                {
                    var name = text.left(content,i);
                    var value = text.right(content,i);
                    vars.Add((name,value));
                }
            }
            dst.Vars = vars;

            return result;
        }
    }
}