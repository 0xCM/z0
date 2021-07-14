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
        where T : struct
    {
        Outcome ParseHeader(TextLine src, out RowHeader dst);

        Outcome ParseRow(TextLine src, out T dst);
    }
}