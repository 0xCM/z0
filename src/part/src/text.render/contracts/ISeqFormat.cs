//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ISeqFormat
    {
        string Delimiter {get;}
    }

    public interface ISeqFormat<C> : ISeqFormat
        where C : struct, ISeqFormat
    {

    }
}