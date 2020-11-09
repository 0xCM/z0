//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ILink : ITextual, IIdentified
    {
        string ITextual.Format()
            => Identifier;
    }

    /// <summary>
    /// Characterizes an association between two parties of heterogenous type
    /// </summary>
    /// <typeparam name="S">The first party type</typeparam>
    /// <typeparam name="T">The second party type</typeparam>
    [Free]
    public interface ILink<S,T> : ILink
    {
        S Source {get;}

        T Target {get;}

        string IIdentified.Identifier
            => string.Format("{0} -- {1}", Source, Target);
    }

    // /// <summary>
    // /// Characterizes an association between two parties of homogenous type
    // /// </summary>
    // /// <typeparam name="T">The party type</typeparam>
    // [Free]
    // public interface ILink<T> : ILink<T,T>
    // {

    // }
}