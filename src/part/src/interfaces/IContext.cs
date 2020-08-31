//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a shared execution environment that may be stateful or stateless
    /// </summary>
    public interface IContext
    {

    }

    readonly struct DefaultContext : IContext
    {
        public static IContext Default => default(DefaultContext);
    }

    /// <summary>
    /// Characterizes a component that maintains readonly-access to encapsulated state, here and throughout referred to as a context
    /// </summary>
    public interface IContextual<C>
    {
        C Context {get;}
    }
}