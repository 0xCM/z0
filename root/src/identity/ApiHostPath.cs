//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static RootShare;

    public readonly struct ApiHostPath
    {
        [MethodImpl(Inline)]
        public static ApiHostPath Define(AssemblyId owner, string name)
            => new ApiHostPath(owner,name);
     
        [MethodImpl(Inline)]
        ApiHostPath(AssemblyId owner, string name)
        {
            this.Owner = owner;
            this.Name = name;
        }

        public readonly AssemblyId Owner;

        public readonly string Name;

        public string Format()
            => $"{Owner.Format()}/{Name}";

        public override string ToString()
            => Format();
    }
}