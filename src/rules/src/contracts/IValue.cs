//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IValue
    {
        RuleModels.DataType Type {get;}

        dynamic Content {get;}
    }

    public interface IValue<T> : IValue
    {
        new T Content {get;}

        dynamic IValue.Content
            => Content;
    }
}