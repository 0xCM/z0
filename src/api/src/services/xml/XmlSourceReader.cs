//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public abstract class XmlSourceReader<T>
        where T : IXmlSource
    {
        protected T Source {get;}

        protected XmlSourceReader(T source)
        {
            Source = source;
        }
    }
}