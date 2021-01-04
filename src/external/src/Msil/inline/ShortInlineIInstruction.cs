// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Code adapted from https://blogs.msdn.microsoft.com/haibo_luo/2010/04/19/ilvisualizer-2010-solution
using System.Reflection.Emit;

namespace Msil
{
    public sealed class ShortInlineIInstruction : ILInlineInstruction
    {
        public sbyte Value {get;}

        internal ShortInlineIInstruction(int offset, OpCode opCode, sbyte value)
            : base(offset, opCode)
        {
            Value = value;
        }


        public override void Accept(ILInstructionVisitor visitor) 
            => visitor.VisitShortInlineIInstruction(this);
    }
}