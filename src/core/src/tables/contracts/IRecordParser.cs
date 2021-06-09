//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IRecordParser
    {
        char FieldDelimiter => Chars.Pipe;
    }

    public interface IRecordParser<T> : IRecordParser
        where T : struct, IRecord<T>
    {
        Outcome ParseHeader(string src, out RowHeader dst);

        Outcome ParseRow(string src, out T dst);
    }
}