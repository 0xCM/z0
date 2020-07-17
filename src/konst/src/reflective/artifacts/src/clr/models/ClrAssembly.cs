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
    
    using static Konst;

    public readonly struct ClrAssembly
    {
        public Assembly Metadata {get;}
    
        public ArtifactIdentity Identifier
        {
            [MethodImpl(Inline)]
            get => new ArtifactIdentity(Metadata);
        }

        [MethodImpl(Inline)]
        public ClrAssembly(Assembly src)
        {
            Metadata = src;
        }        

        [MethodImpl(Inline)]
        public static implicit operator Assembly(ClrAssembly src)
            => src.Metadata;
    }
}