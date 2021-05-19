//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static core;
    using static Typed;

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
}