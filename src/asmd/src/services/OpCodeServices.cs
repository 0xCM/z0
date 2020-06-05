//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Linq;

    using static Seed;
    using static Memories;
 
    [ApiHost("opcodes")]
    public readonly partial struct OpCodeServices : IApiHost<OpCodeServices>
    {                
        [MethodImpl(Inline)]
        public static OpCodeServices Service(in OpCodeDataset data)
            => new OpCodeServices(data);        

        [MethodImpl(Inline)]
        public static OpCodeServices Service()
            => new OpCodeServices(OpCodeDataset.Create());
        
        [MethodImpl(Inline), Op]
        public ref readonly Token token(InstructionToken id)
            => ref ITokens[(int)id];

        [MethodImpl(Inline), Op]
        public AsmCommandGroup group(string name)
            => new AsmCommandGroup(name);

        [MethodImpl(Inline), Op]
        public AsmCommandGroup group(in AsciCode16 name)
            => new AsmCommandGroup(name);

        public ReadOnlySpan<AsmCommandGroup> groups()
            => Records.Select(r => r.Mnemonic).Distinct().Map(group);


        [MethodImpl(Inline), Op]
        public void EncodeTokenValues(Span<byte> dst)
        {
            var count = ITokenValues.Length;
            ReadOnlySpan<string> src = ITokenValues;
            for(int i=0, j=0; i< count; i++, j+=16)
            {
                ReadOnlySpan<char> value = skip(src,i);
                AC16.encode(value, out var encoded);
                encoded.CopyTo(dst.Slice(j,16));                            
            }
        }

        [MethodImpl(Inline), Op]
        public string identifier(InstructionToken id)
            => ITokenIdentity[(int)id];

        [MethodImpl(Inline), Op]
        public OpCodeIdentifier opcode(int index)
            => OpCodeIdentifiers[index];

        [MethodImpl(Inline), Op]
        public string value(InstructionToken id)
            => ITokenValues[(int)id];

        [MethodImpl(Inline), Op]
        public string purpose(InstructionToken id)
            => ITokenPurpose[(int)id];
        
        [MethodImpl(Inline), Op]
        public OpCodeOperand operand(ulong src, duet index)
            => new OpCodeOperand((ushort)Bits.slice(src, index*16, 16));

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> encode(in EncodedOpCode src)
            => MemoryMarshal.CreateReadOnlySpan(ref refs.edit(in src),1).AsBytes();                     

        [MethodImpl(Inline)]
        public OpCodeSpec Parse(OpCodeExpression src)            
            => new OpCodeSpec(src, src.Data.SplitClean(Chars.Space).Map(c => new OpCodePart(c)));

        [MethodImpl(Inline)]
        public InstructionSpec Parse(InstructionExpression src)     
        {       
            var mnemonic = src.Data.LeftOf(Chars.Space);
            var operands = src.Data.RightOf(Chars.Space).SplitClean(Chars.Comma);
            return new InstructionSpec(src,mnemonic,operands);
        }       
   }
}