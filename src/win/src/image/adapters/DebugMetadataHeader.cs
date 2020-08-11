//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    using System.Collections.Immutable;

    using MS;

    public sealed class DebugMetadataHeader
    {
        public ImmutableArray<byte> Id { get; }
        
        public MethodDefinitionHandle EntryPoint { get; }

        /// <summary>
        /// Gets the offset (in bytes) from the start of the metadata blob to the start of the <see cref="Id"/> blob.
        /// </summary>
        public int IdStartOffset { get; }

        public DebugMetadataHeader(ImmutableArray<byte> id, MethodDefinitionHandle entryPoint, int idStartOffset)
        {
            Id = id;
            EntryPoint = entryPoint;
            IdStartOffset = idStartOffset;
        }
    }
}