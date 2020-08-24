//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [AttributeUsage(AttributeTargets.Struct)]
    public class JsonProviderAttribute : Attribute
    {
        public Type[] Supported {get;}

        public JsonProviderAttribute(params Type[] supported)
        {
            Supported = supported;
        }
    }

    public interface IJsonProvider
    {
        JsonText ToJson(object src);
    }

    public interface IJsonProvider<T> : IJsonProvider
    {
        JsonText ToJson(in T src);

        JsonText IJsonProvider.ToJson(object src)
            => ToJson((T)src);
    }

    public interface IJsonProvider<H,T> : IJsonProvider<T>
        where H : struct, IJsonProvider<H,T>
    {

    }
}