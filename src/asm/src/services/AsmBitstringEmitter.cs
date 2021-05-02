//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;
    using static memory;

    public class AsmBitstringEmitter : AppService<AsmBitstringEmitter>
    {
        public void EmitBitstrings(ReadOnlySpan<AsmThumbprint> src)
        {
            var bitstrings = AsmBitstrings.service();
            var count = src.Length;
            var dst = Db.IndexRoot() + IndexFileName;
            var emitting = Wf.EmittingFile(dst);
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
            {
                ref readonly var tp = ref skip(src,i);
                var line1 = AsmRender.format(tp);
                var bits = bitstrings.Format(tp.Encoded);
                var line2 = string.Format(BitLinePattern, Chars.Space, bits);
                writer.WriteLine(line1);
                writer.WriteLine(line2);
            }
            Wf.EmittedFile(emitting, count);
        }

        public Index<AsmEncodingInfo> EmitBitstrings(ReadOnlySpan<AsmApiStatement> src)
        {
            var collecting = Wf.Running(Msg.CollectingBitstrings.Format(src.Length));
            var bitstrings = AsmBitstrings.service();
            var collected = root.hashset<AsmEncodingInfo>();
            var count = src.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var statement = ref skip(src,i);
                var content = bitstrings.Format(statement.Encoded);
                if(collected.Add(new AsmEncodingInfo(statement.Expression, statement.Sig, statement.OpCode, statement.Encoded, content)))
                    counter++;
            }

            Wf.Ran(collecting, Msg.CollectedBitstrings.Format(counter));

            var sorted = collected.Array();
            Array.Sort(sorted);
            var dst = Db.IndexRoot() + IndexFileName;
            var emitting = Wf.EmittingFile(dst);
            using var writer = dst.Writer();
            var input = @readonly(sorted);
            for(var i=0; i<counter; i++)
            {
                ref readonly var bitstring = ref skip(input,i);
                var line1 = string.Format(AsmLinePattern, bitstring.Statement, bitstring.Sig, bitstring.OpCode, bitstring.Encoded.Size, bitstring.Encoded);
                var line2 = string.Format(BitLinePattern, Chars.Space, bitstring.Format());
                writer.WriteLine(line1);
                writer.WriteLine(line2);
            }

            Wf.EmittedFile(emitting, counter);

            return sorted;
        }

        FS.FileName IndexFileName
            => FS.file("asm.bitstrings", FS.Asm);

        const string BitLinePattern = "{0,-46} ; {1}";

        const string AsmLinePattern = "{0,-46} ; ({1})<{2}>[3] => {4}";
    }
}