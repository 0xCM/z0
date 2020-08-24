//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IWfStepArg
    {
        string Name {get;}

        string Value {get;}
    }

    public interface IWfStepArg<T> : IWfStepArg
        where T : ITextual
    {
        new T Value {get;}

        string IWfStepArg.Value
            => Value.Format();
    }
}