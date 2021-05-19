//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static core;
    using static Typed;

    partial struct Msg
    {
        public static MsgPattern<Count,Count,string> FieldCountMismatch => "The record defines {0} fields however {1} are present in the data '{2}'";
    }

    public abstract class RecordParser<P,T> : AppService<P>
        where T : struct, IRecord<T>
        where P : RecordParser<P,T>, new()
    {
        protected char Delimiter {get; set;} = Chars.Pipe;

        protected byte FieldCount {get;}

        protected RecordParser(byte fields)
        {
            FieldCount = fields;
        }

        public ReadOnlySpan<T> Load(FS.FilePath src)
        {
            if(!src.Exists)
            {
                Wf.Error(FS.Msg.DoesNotExist.Format(src));
                return default;
            }
            else
            {

            }
            return default;
        }

        public Outcome ParseRecord(string src, out T dst)
        {
            dst = default;
            var result = Outcome.Success;
            var cells = @readonly(src.SplitClean(Delimiter));
            var count = cells.Length;
            if(count >= 1)
                result &= ParseField(n0, skip(cells, 0), ref dst);
            if(count >= 2)
                result &= ParseField(n1, skip(cells, 1), ref dst);
            if(count >= 3)
                result &= ParseField(n2, skip(cells, 2), ref dst);
            if(count >= 4)
                result &= ParseField(n3, skip(cells, 3), ref dst);
            if(count >= 5)
                result &= ParseField(n4, skip(cells, 4), ref dst);
            if(count >= 6)
                result &= ParseField(n5, skip(cells, 5), ref dst);
            if(count >= 7)
                result &= ParseField(n6, skip(cells, 6), ref dst);
            if(count >= 8)
                result &= ParseField(n7, skip(cells, 7), ref dst);

            return false;
        }

        protected virtual Outcome ParseField(N0 n, string src, ref T dst)
        {
            return true;
        }

        protected virtual Outcome ParseField(N1 n, string src, ref T dst)
        {
            return true;
        }

        protected virtual Outcome ParseField(N2 n, string src, ref T dst)
        {
            return true;
        }

        protected virtual Outcome ParseField(N3 n, string src, ref T dst)
        {
            return true;
        }

        protected virtual Outcome ParseField(N4 n, string src, ref T dst)
        {
            return true;
        }

        protected virtual Outcome ParseField(N5 n, string src, ref T dst)
        {
            return true;
        }

        protected virtual Outcome ParseField(N6 n, string src, ref T dst)
        {
            return true;
        }

        protected virtual Outcome ParseField(N7 n, string src, ref T dst)
        {
            return true;
        }

    }

    public sealed class BitfieldGenerator : AppService<BitfieldGenerator>
    {
        const char Delimiter = Chars.Pipe;

        const byte FieldCount = BitfieldSpecEntry.FieldCount;

        public ReadOnlySpan<BitfieldSpecEntry> LoadSpecs()
        {
            var src = Db.GenTable<BitfieldSpecEntry>("bitfields");
            if(!src.Exists)
            {
                Wf.Error(FS.Msg.DoesNotExist.Format(src));
                return default;
            }

            var running = Wf.Running(string.Format("Loading {0}", src.ToUri()));
            var lines = src.ReadLines().View;
            var count = lines.Length;
            if(count == 0)
            {
                Wf.Warn(FS.Msg.Empty.Format(src));
                return default;
            }

            var header = first(lines);
            var cells = header.SplitClean(Delimiter);
            if(cells.Length != FieldCount)
            {
                Wf.Error(Msg.FieldCountMismatch.Format(FieldCount, cells.Length,header));
                return default;
            }

            var buffer = alloc<BitfieldSpecEntry>(count - 1);
            ref var dst = ref first(buffer);
            var counter = 0u;
            for(var i=1u; i<count; i++)
            {
                ref readonly var line = ref skip(lines,i);
                ref var entry = ref seek(dst,i-1);
                var result = Parse(line, out entry);
                if(!result)
                {
                    Wf.Error(result.Message);
                    break;
                }
                counter++;
            }

            Wf.Ran(running, counter);

            return buffer;
        }

        Outcome Parse(string src, out BitfieldSpecEntry dst)
        {
            dst = default;
            var result = Outcome.Success;
            var parts = @readonly(src.SplitClean(Delimiter));
            if(parts.Length != FieldCount)
            {
                result = (false, Msg.FieldCountMismatch.Format(FieldCount, parts.Length, src));
            }
            else
            {
                var i = 0;
                result &= DataParser.parse(skip(parts, i++), out dst.Bitfield);
                result &= DataParser.parse(skip(parts, i++), out dst.Index);
                result &= DataParser.parse(skip(parts, i++), out dst.Name);
                result &= DataParser.parse(skip(parts, i++), out dst.Offset);
                result &= DataParser.parse(skip(parts, i++), out dst.Width);
            }
            return result;
        }

        public void Emit(ReadOnlySpan<BitfieldSpecEntry> src, FS.FilePath dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
            {

            }
        }

        public static ReadOnlySpan<uint> SpecOffsets(ReadOnlySpan<BitfieldSpecEntry> src)
        {
            var count = src.Length;
            if(count == 0)
                return default;

            var dst = root.list<uint>();
            var current = utf8.Empty;
            for(var i=0u; i<count; i++)
            {
                ref readonly var entry = ref skip(src, i);
                ref readonly var bf = ref entry.Bitfield;
                if(current.IsEmpty)
                {
                    current = bf;
                    dst.Add(i);
                }

                if(current != bf)
                {
                    current = bf;
                    dst.Add(i);
                }
            }
            return dst.ViewDeposited();
        }
    }

}