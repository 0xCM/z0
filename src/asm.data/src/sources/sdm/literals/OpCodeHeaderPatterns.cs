//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct SdmModels
    {
        public readonly struct OpCodeHeaderPatterns
        {
            static string[] HP0 = new string[]{"Opcode","Instruction", "Op/", "En", "64-bit", "Mode", "Compat/", "Leg Mode", "Description"};

            static string[] HP1 = new string[]{"Opcode/","Instruction", "Op/", "En", "64/32bit", "Mode", "Support", "CPUID", "Feature", "Flag", "Description"};

            static string[] HP2 = new string[]{"Opcode/Instruction","Instruction", "Op/", "En", "64/32", "-bit", "Mode", "CPUID", "Feature", "Flag", "Description"};

            static string[] HP3 = new string[]{"Opcode/","Instruction", "Op/", "En", "64/32-bit", "Mode", "CPUID", "Feature", "Flag", "Description"};

            public static LinePattern HP(N0 n) => HP0;

            public static LinePattern HP(N1 n) => HP1;

            public static LinePattern HP(N2 n) => HP2;

            public static LinePattern HP(N3 n) => HP3;
        }
    }
}