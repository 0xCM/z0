//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IApiUri : IIdentified
    {
        string UriText {get;}

        string IIdentified.Identifier
            => UriText;
    }

    public interface IApiUri<T> : IApiUri, IIdentification<T>
        where T : IApiUri<T>, new()
    {

    }
}