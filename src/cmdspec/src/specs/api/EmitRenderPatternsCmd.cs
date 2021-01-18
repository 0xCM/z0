//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Cmd]
    public struct EmitRenderPatternsCmd : ICmd<EmitRenderPatternsCmd>
    {
        public ClrType Source;

        public FS.FilePath Target;
    }

    partial class XCmd
    {
        [Op]
        public static EmitRenderPatternsCmd EmitRenderPatterns(this CmdBuilder builder, Type src)
        {
            var cmd = new EmitRenderPatternsCmd();
            cmd.Source = src;
            cmd.Target = builder.Db.Doc("render.patterns", src.Name, FileExtensions.Csv);
            return cmd;
        }
    }
}