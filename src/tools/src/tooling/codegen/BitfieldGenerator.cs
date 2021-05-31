//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static core;

    partial struct Msg
    {
        public static MsgPattern<Count,Count,string> FieldCountMismatch => "The record defines {0} fields however {1} are present in the data '{2}'";
    }

    public sealed class BitfieldGenerator : AppService<BitfieldGenerator>
    {
        const char Delimiter = Chars.Pipe;

        //const byte FieldCount = BitfieldSpecEntry.FieldCount;

        // public ReadOnlySpan<BitfieldSpec> LoadSpecs()
        // {
        //     var src = Db.GenTable<BitfieldSpecEntry>("bitfields");
        //     if(!src.Exists)
        //     {
        //         Wf.Error(FS.Msg.DoesNotExist.Format(src));
        //         return default;
        //     }

        //     var running = Wf.Running(string.Format("Loading {0}", src.ToUri()));
        //     var lines = src.ReadLines().View;
        //     var count = lines.Length;
        //     if(count == 0)
        //     {
        //         Wf.Warn(FS.Msg.Empty.Format(src));
        //         return default;
        //     }

        //     var header = first(lines);
        //     var cells = header.SplitClean(Delimiter);
        //     if(cells.Length != FieldCount)
        //     {
        //         Wf.Error(Msg.FieldCountMismatch.Format(FieldCount, cells.Length,header));
        //         return default;
        //     }

        //     var buffer = alloc<BitfieldSpecEntry>(count - 1);
        //     ref var dst = ref first(buffer);
        //     var counter = 0u;
        //     for(var i=1u; i<count; i++)
        //     {
        //         ref readonly var line = ref skip(lines,i);
        //         ref var entry = ref seek(dst,i-1);
        //         var result = Parse(line, out entry);
        //         if(!result)
        //         {
        //             Wf.Error(result.Message);
        //             break;
        //         }
        //         counter++;
        //     }

        //     Wf.Ran(running, counter);

        //     return Specs(buffer);
        // }

        // Outcome Parse(string src, out BitfieldSpecEntry dst)
        // {
        //     dst = default;
        //     var result = Outcome.Success;
        //     var parts = @readonly(src.SplitClean(Delimiter));
        //     if(parts.Length != FieldCount)
        //     {
        //         result = (false, Msg.FieldCountMismatch.Format(FieldCount, parts.Length, src));
        //     }
        //     else
        //     {
        //         var i = 0;
        //         result &= DataParser.parse(skip(parts, i++), out dst.Bitfield);
        //         result &= DataParser.parse(skip(parts, i++), out dst.Index);
        //         result &= DataParser.parse(skip(parts, i++), out dst.Name);
        //         result &= DataParser.parse(skip(parts, i++), out dst.Offset);
        //         result &= DataParser.parse(skip(parts, i++), out dst.Width);
        //     }
        //     return result;
        // }

    //     public void Emit(ReadOnlySpan<BitfieldSpecEntry> src, FS.FilePath dst)
    //     {
    //         TableEmit(src, dst);
    //     }

    //     public static ReadOnlySpan<BitfieldSpec> Specs(ReadOnlySpan<BitfieldSpecEntry> src)
    //     {
    //         var count = src.Length;
    //         if(count == 0)
    //             return default;

    //         var dst = root.list<BitfieldSpec>();
    //         var current = utf8.Empty;
    //         var i0 = 0u;
    //         var i1 = 0u;
    //         for(var i=0u; i<count; i++)
    //         {
    //             ref readonly var entry = ref skip(src, i);
    //             ref readonly var bf = ref entry.Bitfield;

    //             if(current.IsEmpty)
    //             {
    //                 i0 = i;
    //                 current = bf;
    //             }

    //             if(current != bf)
    //             {
    //                 i1 = i-1;

    //                 dst.Add(new BitfieldSpec(segment(src, i0, i1).ToArray()));

    //                 current = bf;

    //                 i0 = i;
    //             }

    //             if(i == count - 1 && current.IsNonEmpty)
    //             {
    //                 i1 = i-1;
    //                 dst.Add(new BitfieldSpec(segment(src, i0, i1).ToArray()));
    //                 break;
    //             }
    //         }
    //         return dst.ViewDeposited();
    //     }
    }
}