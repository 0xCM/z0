//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public struct AsmInstructionDetail
    {
        public AsmMnemonicCode Mnemonic;
    }

    [ApiHost]
    public class AsmDetailProducer : IReceiver<ApiCodeBlock,AsmInstructionBlock>
    {
        readonly uint Capacity;

        readonly IWfRuntime Wf;

        readonly RegKindConverter RegConverter;

        uint Receipts;

        uint Targets;

        readonly Index<IceInstruction> Received;

        readonly Index<AsmInstructionDetail> Produced;

        public AsmDetailProducer(IWfRuntime wf, uint capacity)
        {
            Wf = wf;
            Capacity = capacity;
            Received = sys.alloc<IceInstruction>(Capacity);
            Produced = sys.alloc<AsmInstructionDetail>(Capacity);
            Receipts = 0;
            Targets = 0;
            RegConverter = RegKindConverter.create();
        }

        public ReadOnlySpan<AsmInstructionDetail> Productions
        {
            [MethodImpl(Inline)]
            get => slice(Produced.View, 0, Targets);
        }

        [Op]
        public void Deposit(in ApiCodeBlock encoded, in AsmInstructionBlock decoded)
        {
            var instructions = decoded.Instructions;
            var count = instructions.Length;
            for(var i=0; i<count; i++)
            {
                if(Receipts < Capacity - 1)
                {
                    ref readonly var instruction = ref skip(instructions,i);
                    Deposit(encoded, instruction);
                    Produce(encoded, instruction);
                }
            }
        }

        [MethodImpl(Inline), Op]
        void Deposit(in ApiCodeBlock block, in IceInstruction src)
        {
            Received[Receipts++] = src;
        }

        [Op]
        void Produce(in ApiCodeBlock block, in IceInstruction src)
        {
            if(src.Mnemonic == IceMnemonic.INVALID)
                return;

            var target = new AsmInstructionDetail();
            AssignMnemonicCode(src, ref target);
            SpecifyOperands(block,src, ref target);

            Produced[Targets++] = target;
        }

        [Op]
        void AssignMnemonicCode(in IceInstruction src, ref AsmInstructionDetail dst)
        {
            var name = src.AsmMnemonic.Format();
            if(Enums.parse<AsmMnemonicCode>(name, out var code))
            {
                dst.Mnemonic = code;
            }
            else
            {
                Wf.Warn(UnrecognizedMnemonic.Format(name));
            }
        }

        void SpecifyOperands(in ApiCodeBlock block, in IceInstruction src, ref AsmInstructionDetail dst)
        {
            var opcount = src.OpCount;
            for(byte i=0; i<opcount; i++)
                SpecifyOperand(block, src, i, ref dst);
        }

        [Op]
        void SpecifyOperand(in ApiCodeBlock block, in IceInstruction src, byte index, ref AsmInstructionDetail dst)
        {
            var kind = IceConverters.opkind(src, index);
            var desc = EmptyString;
            if(IceOpTest.isRegister(kind))
                {}
            else if(IceOpTest.isMem(kind))
                SpecifyOperand(block, IceConverters.meminfo(src, index), ref dst);
            else if (IceOpTest.isBranch(kind))
                SpecifyOperand(block, IceConverters.branch(block.BaseAddress, src, index), ref dst);
            else if(IceOpTest.isImm(kind))
                {}
            else
                SpecifyMysteryOperand(block, src,index, ref dst);
        }

        void SpecifyOperand(in ApiCodeBlock block,  in IceMemoryInfo src, ref AsmInstructionDetail dst)
        {

        }

        void SpecifyOperand(in ApiCodeBlock block, in AsmBranchInfo src, ref AsmInstructionDetail dst)
        {

        }


        void SpecifyMysteryOperand(in ApiCodeBlock block, in IceInstruction src, byte index, ref AsmInstructionDetail dst)
        {

        }

        static MsgPattern<string> UnrecognizedMnemonic => "The mnemonic {0} was not recognized";
    }
}