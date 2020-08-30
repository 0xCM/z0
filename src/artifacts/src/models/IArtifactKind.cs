//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata.Ecma335;

    public interface IArtifactKind : ITypedLiteral<TableIndex,byte>
    {
        TableIndex Index {get;}

        TableIndex ITypedLiteral<TableIndex>.Class
            => Index;

        byte ITypedLiteral<TableIndex,byte>.Value
            => (byte)Index;
    }

    public interface IArtifactKind<K> : IArtifactKind
        where K : unmanaged, IArtifactKind<K>
    {

    }
}