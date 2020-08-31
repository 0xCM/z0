//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ISequenceFormatConfig 
    {
        string Delimiter {get;}
    }

    public interface ISequenceFormatConfig<C> : ISequenceFormatConfig
        where C : struct, ISequenceFormatConfig
    {

    }
}