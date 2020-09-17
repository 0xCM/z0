//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes an identifier
    /// </summary>
    [Free]
    public interface IIdentified
    {
        string Identifier {get;}

        bool IsEmpty
            => string.IsNullOrWhiteSpace(Identifier);

        bool IsNonEmpty
            => !IsEmpty;
    }

    [Free]
    public interface IIdentified<T> : IIdentified
    {
        T Id {get;}

        string IIdentified.Identifier
            => $"{Id}";
    }
}