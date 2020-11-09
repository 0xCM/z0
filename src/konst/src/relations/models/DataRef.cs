//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct DataRef<T>
        where T : struct
    {
        public ClrArtifactKey Target {get;}

        [MethodImpl(Inline)]
        public DataRef(ClrArtifactKey dst)
            => Target = dst;

        [MethodImpl(Inline)]
        public static implicit operator DataRef<T>(ClrArtifactKey dst)
            => new DataRef<T>(dst);
    }
}