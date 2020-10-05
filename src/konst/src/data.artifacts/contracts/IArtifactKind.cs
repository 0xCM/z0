//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata.Ecma335;

    public interface IArtifactKind : ITypedLiteral<TableIndex,byte>, ITextual
    {
        TableIndex Index {get;}

        TableIndex ITypedLiteral<TableIndex>.Class
            => Index;

        byte ITypedLiteral<TableIndex,byte>.Value
            => (byte)Index;

        string ITextual.Format()
            => Index.ToString();
    }

    public interface IArtifactKind<K> : IArtifactKind
        where K : unmanaged, IArtifactKind<K>
    {

    }
}