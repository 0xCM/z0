//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    class Runner
    {
        public static void Main(params string[] args)
            => Apps.react(args);

        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly CmdBuilder Builder;

        readonly IWfDb Db;

        Runner(IWfShell wf)
        {
            Host = WfShell.host(typeof(Runner));
            Wf = wf.WithHost(Host);
            Builder = wf.CmdBuilder();
            Db = wf.Db();
        }


        void CheckFlags()
        {
            var flags = Clr.@enum<Windows.MinidumpType>();
            var summary = flags.Summary();
            var count = summary.FieldCount;
            var details = summary.LiteralDetails;

            if(count == 0)
                Wf.Error("No flags");

            for(var i=0; i<count; i++)
            {
                ref readonly var detail = ref skip(details,i);
                var description = string.Format("{0,-12} | {1,-48} | {2}", detail.Position, detail.Name, detail.ScalarValue.FormatHex());
                Wf.Row(description);
            }
        }

        static Address32 displacement(BinaryCode instruction)
        {
            var opcode = instruction[0];
            root.require(opcode == 0xe8, () => $"Expected an opcode of e8h, but instead there is {opcode.FormatAsmHex()}");
            var len = instruction.Length - 1;
            var bytes = slice(instruction.View, 1);
            return Numeric.take32u(bytes);
        }

        void CalcAddress()
        {
            // ; BaseAddress = 7ffc56862280h
            // 0025h call 7ffc52e94420h                      ; CALL rel32                       | E8 cd                            | 5   | e8 76 21 63 fc
            // Expected: 7ffc56862310h
            const ulong FunctionBase = 0x7ffc56862280;
            const ulong CallOffset = 0x25;
            const ulong CallInstructionSize = 0x5;
            const ulong CallDisplacement = 0xfc632176;
            var instruction = array<byte>(0xe8, 0x76, 0x21, 0x63, 0xfc);
            var dx = displacement(instruction);

            MemoryAddress Expected = 0x7ffc56862310;
            MemoryAddress Encoded =  0x7ffc52e94420;
            MemoryAddress next = FunctionBase + CallOffset + CallInstructionSize;
            MemoryAddress target = next + CallDisplacement;
            MemoryAddress encoded = 0x7ffc52e94420;

            Wf.Status($"Computed:{target} | Expected:{Expected} | Encoded:{encoded} | Computed2:{dx}");
        }
    }
}