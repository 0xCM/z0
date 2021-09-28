//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static core;

    public class StringLiteralEmitter : AppService<StringLiteralEmitter>
    {
        public void Emit(string name, ReadOnlySpan<char> src, FS.FilePath dst)
        {
            var emitting = EmittingFile(dst);
            using var writer = dst.AsciWriter();
            var i=0;
            var count = src.Length;
            var buffer = text.buffer();
            writer.Write(string.Format("public const string {0} = ", name));
            writer.Write('\"');
            while(i++<count)
            {
                ref readonly var c = ref skip(src,i);
                if(c == 0)
                {
                    writer.Write('\\');
                    writer.Write('0');
                }
                else
                    writer.Write((char)c);
            }
            writer.Write('\"');
            writer.Write(';');
            writer.WriteLine();

            EmittedFile(emitting, 1);
        }
    }
}