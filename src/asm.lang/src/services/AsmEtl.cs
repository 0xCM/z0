//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;
    using static core;

    [ApiHost]
    public class AsmEtl : AppService<AsmEtl>
    {
        public static void traverse(FS.FilePath src, Receiver<ProcessAsmRecord> dst)
        {
            var counter = 1u;
            using var reader = src.Utf8Reader();
            var header = reader.ReadLine();
            var line = reader.ReadLine();
            var result = Outcome.Success;
            while(line != null && result.Ok)
            {
                result = AsmParser.parse(counter++, line, out var row);
                if(result.Ok)
                    dst(row);
                line = reader.ReadLine();
            }
        }

        [Op]
        public static HexVector32 offsets(ReadOnlySpan<ProcessAsmRecord> src)
        {
            var count = src.Length;
            var buffer = alloc<Hex32>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst,i) = skip(src,i).GlobalOffset;
            return buffer;
        }

        public static uint load(FS.FilePath src, List<AsmLine> dst)
        {
            var counter = 0u;
            using var reader = src.AsciLineReader();
            while(reader.Next(out var line))
            {
                if(AsmParser.parse(line, out AsmBlockLabel label, out AsmExpr expr))
                {
                    if(AsmParser.parse(label, out AsmOffsetLabel offset))
                    {
                        dst.Add(asm.line(offset, expr));
                        counter++;
                    }
                    else
                    {
                        if(expr.IsNonEmpty)
                        {
                            dst.Add(asm.line(label, expr));
                            counter++;
                        }
                        else
                        {
                            dst.Add(asm.line(label));
                            counter++;
                        }
                    }
                }
            }
            return counter;
        }

        public ReadOnlySpan<AsmThumbprint> LoadThumbprints(FS.FilePath src)
        {
            var dst = list<AsmThumbprint>();
            using var reader = src.Utf8Reader();
            while(!reader.EndOfStream)
            {
                var data = reader.ReadLine();
                var statement = asm.expr(data.LeftOfFirst(Chars.Semicolon));
                var tpResult = AsmParser.thumbprint(data, out var thumbprint);
                if(tpResult)
                    dst.Add(thumbprint);
                else
                    Error(tpResult.Message);
            }
            return dst.ToArray();
        }

        public ReadOnlySpan<TextLine> EmitThumbprints(SortedSpan<AsmEncodingInfo> src, FS.FilePath dst)
        {
            var count = src.Length;
            var emitting = EmittingFile(dst);
            var lines = span<TextLine>(count);
            using var writer = dst.Writer();
            for(var i=0u; i<count; i++)
            {
                var content = AsmRender.thumbprint(SortedSpans.skip(src,i));
                writer.WriteLine(content);
                seek(lines,i) = (i,content);
            }
            EmittedFile(emitting, count);
            return lines;
        }

        public void EmitThumbprints(SortedSpan<ProcessAsmRecord> src, FS.FilePath dst)
            => EmitThumbprints(DistinctEncodings(src), dst);

        public void EmitThumbprints(ReadOnlySpan<AsmThumbprint> src, FS.FilePath dst)
        {
            var flow = EmittingFile(dst);
            var count = src.Length;
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
                writer.WriteLine(AsmRender.format(skip(src,i)));
            EmittedFile(flow, count);
        }

        public ReadOnlySpan<TextLine> EmitThumbprints(SortedSpan<AsmThumbprint> src, FS.FilePath dst)
        {
            var count = src.Length;
            var emitting = EmittingFile(dst);
            var lines = span<TextLine>(count);
            using var writer = dst.Writer();
            for(var i=0u; i<count; i++)
            {
                var content = AsmRender.thumbprint(SortedSpans.skip(src,i), true);
                writer.WriteLine(content);
                seek(lines,i) = (i,content);
            }
            EmittedFile(emitting, count);
            return lines;
        }

        public SortedSpan<AsmThumbprint> DistinctThumbprints(ReadOnlySpan<HostAsmRecord> src)
        {
            var distinct = hashset<AsmThumbprint>();
            iter(src, s => distinct.Add(asm.thumbprint(s)));
            return distinct.Array().ToSortedSpan();
        }

        public SortedSpan<AsmThumbprint> EmitThumbprints(ReadOnlySpan<HostAsmRecord> src, FS.FilePath dst)
        {
            var distinct = DistinctThumbprints(src);
            EmitThumbprints(distinct, dst);
            return distinct;
        }

        [MethodImpl(Inline), Op]
        public static BinaryCode code(in CodeBlock src, uint offset, byte size)
            => slice(src.View, offset, size).ToArray();

        public static SortedSpan<AsmEncodingInfo> DistinctEncodings(ReadOnlySpan<ProcessAsmRecord> src)
        {
            var collected = hashset<AsmEncodingInfo>();
            var count = src.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var statement = ref skip(src,i);
                if(collected.Add(AsmEncoder.describe(statement)))
                    counter++;
            }
            return collected.Array().ToSortedSpan();
        }

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static AsmRowSet<T> rowset<T>(T key, AsmDetailRow[] src)
            => new AsmRowSet<T>(key,src);
    }
}