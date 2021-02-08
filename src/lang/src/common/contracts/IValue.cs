//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{

    public interface IValue
    {
        DataType Type {get;}

        dynamic Content {get;}
    }

    public interface IValue<T> : IValue
    {
        new T Content {get;}

        dynamic IValue.Content
            => Content;
    }
}
