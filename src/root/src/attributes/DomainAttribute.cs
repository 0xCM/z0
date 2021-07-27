//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class DomainAttribute : Attribute
    {
        public DomainAttribute(Type src)
        {
            PointSource = src;
        }

        public Type PointSource {get;}
    }
}