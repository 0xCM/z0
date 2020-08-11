//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Reflection;

    public readonly struct ClrGenericParameter
    {
        public int MetadataToken { get; }

        public int Index { get; }

        public GenericParameterAttributes Attributes { get; }

        public string Name { get; }

        public ClrGenericParameter(int metadataToken, int index, GenericParameterAttributes attributes, string name)
        {
            MetadataToken = metadataToken;
            Index = index;
            Attributes = attributes;
            Name = name;
        }
    }
}