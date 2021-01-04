// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Code adapted from https://blogs.msdn.microsoft.com/haibo_luo/2010/04/19/ilvisualizer-2010-solution

using System.IO;

namespace Msil
{
    public class RawILStringToTextWriter : ReadableILStringToTextWriter
    {
        public RawILStringToTextWriter(TextWriter writer)
            : base(writer)
        {
        }

        public override void Process(ILInlineInstruction ilInstruction, string operandString)
        {
            _writer.WriteLine("IL_{0:x4}: {1,-4}| {2, -8}",
                ilInstruction.Offset,
                ilInstruction.OpCode.Value.ToString("x2"),
                operandString);
        }
    }
}
