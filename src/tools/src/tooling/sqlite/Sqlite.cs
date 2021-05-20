//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    public readonly partial struct Sqlite
    {
        public static void render(Command src, ITextBuffer dst)
            => dst.AppendLine(src.Content);

        public static void render(ReadOnlySpan<Command> src, ITextBuffer dst)
            => root.iter(src, cmd => render(cmd,dst));

        static Identifier identifier(Identifier? id, FS.FileName file)
            =>id != null ? id.Value.Format() : file.WithoutExtension.Format();
    }
}