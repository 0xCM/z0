//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Typed;
    using static core;
    
    public readonly struct OpCodeModel : ITextual
    {
        readonly Vector512<ulong> Locations;

        public StringRef Identifier
        {
            [MethodImpl(Inline)]
            get => memref(Locations[n0]);
        }  

        public StringRef Expression
        {
            [MethodImpl(Inline)]
            get => memref(Locations[n1]);
        }  

        public StringRef Instruction
        {
            [MethodImpl(Inline)]
            get => memref(Locations[n2]);
        }  

        [MethodImpl(Inline)]
        public OpCodeModel(string id, string cx, string ix)
        {            
            Locations = core.v512<ulong>(memref(id), memref(cx), memref(ix), MemRef.Empty);
        }  

        public string Format()
            => StringRefs.join(" ", Identifier, Expression, Instruction);

        public string Format(bool diagnostic)
            => text.concat(
                nameof(Identifier), " := ", Identifier.Address, text.bracket(Identifier.Length), Space, text.embrace(Identifier.Text),
                nameof(Expression), " := ", Expression.Address, text.bracket(Expression.Length), Space, text.embrace(Expression.Text),
                nameof(Instruction), " := ", Instruction.Address, text.bracket(Instruction.Length), Space, text.embrace(Instruction.Text)
                );            
    }
}