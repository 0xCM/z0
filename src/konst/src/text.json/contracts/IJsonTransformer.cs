//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    using static Konst;

    public interface IJsonTransformer
    {
        Type KeyType {get;}

        string Project(object src);

        object Project(string src);
    }

    public interface IJsonTransformer<T> : IJsonTransformer
    {
        Type IJsonTransformer.KeyType => typeof(T);

        string Project(T src);

        new T Project(string src);

        string IJsonTransformer.Project(object src)
            => Project((T)src);

        object IJsonTransformer.Project(string src)
            => Project(src);
    }

    public interface IJsonTransformer<H,T> : IJsonTransformer<T>
        where H : struct, IJsonTransformer<H,T>
    {

    }

}