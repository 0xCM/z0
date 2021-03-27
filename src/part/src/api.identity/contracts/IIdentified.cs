//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes an identifier
    /// </summary>
    [Free]
    public interface IIdentified : ITextual
    {
        string Identifier {get;}

        Identifier _Identifier
            => new Identifier(Identifier);

        bool IsEmpty
            => string.IsNullOrWhiteSpace(Identifier);

        bool IsNonEmpty
            => !IsEmpty;

        string ITextual.Format()
            => Identifier;
    }
}