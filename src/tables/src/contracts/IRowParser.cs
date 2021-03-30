//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IRowParser
    {
        char FieldDelimiter => Chars.Pipe;
    }

    public interface IRowParser<T> : IRowParser
        where T : struct, IRecord<T>
    {
        Outcome ParseHeader(string src, out RowHeader dst);

        Outcome ParseRow(string src, out T dst);
    }
}