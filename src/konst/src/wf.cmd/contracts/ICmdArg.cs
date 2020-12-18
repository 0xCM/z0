//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdArg : ITextual
    {
        /// <summary>
        /// The argument's relative position
        /// </summary>
        ushort Position {get;}

        /// <summary>
        /// The (required) argument value
        /// </summary>
        string Value {get;}

        /// <summary>
        /// The argument prefix, if any; typically either '-', '--', or '/'
        /// </summary>
        string Prefix {get;}

        /// <summary>
        /// The argument name, if any
        /// </summary>
        CmdName Name {get;}

        /// <summary>
        /// The delimiter between an argument name/value pair, typically ' ' or ':'
        /// </summary>
        string Qualifier {get;}

        string ITextual.Format()
            => TextFormatter.setting(Name,Value);
    }

    [Free]
    public interface ICmdArg<T> : ICmdArg
    {
        new T Value {get;}

        string ICmdArg.Value
            => Value?.ToString() ?? string.Empty;
    }

    [Free]
    public interface ICmdArg<K,T> : ICmdArg<T>
        where K : unmanaged
    {


    }
}