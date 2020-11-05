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
    public interface IIdentified : ITextual
    {
        string Identifier {get;}

        bool IsEmpty
            => string.IsNullOrWhiteSpace(Identifier);

        bool IsNonEmpty
            => !IsEmpty;
        string ITextual.Format()
            => Identifier;
    }

    [Free]
    public interface IIdentified<T>
    {
        T Id {get;}
    }

    [Free]
    public interface IIdentified<H,T> : IIdentified<T>
        where H : struct, IIdentified<H,T>
    {

    }
}