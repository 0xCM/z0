//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;

    public abstract class Part<P> : IPart<P>
        where P : IPart<P>, new()
    {
        public string Format()
            =>  (this as IPartIdentity).Id.Format();
        
        public override string ToString()
            => Format();
    }
}