//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata;
    using System.Reflection;

    /// <summary>
    /// Captures <see cref='MethodDefinition'/> data in usable form
    /// </summary>
    [Record(TableId)]
    public struct CliMethodDefinition : IRecord<CliMethodDefinition>
    {
        public const string TableId = "cli.method.definition";

        public const byte FieldCount = 5;

        public BinaryCode Signature;

        public string Name;

        public Address32 Rva;

        public MethodAttributes Attributes;

        public MethodImplAttributes ImplAttributes;
    }
}