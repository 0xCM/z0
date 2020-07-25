//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Buffers;
    using System.Reflection;

    partial struct ClrDataModel
    {
        public readonly struct ClrGenericParameter
        {
            public int MetadataToken { get; }

            public int Index { get; }

            public GenericParameterAttributes Attributes { get; }

            public string Name { get; }

            internal ClrGenericParameter(int metadataToken, int index, GenericParameterAttributes attributes, string name)
            {
                MetadataToken = metadataToken;
                Index = index;
                Attributes = attributes;
                Name = name;
            }
        }
    }
}