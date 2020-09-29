//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata;

    partial struct Cil
    {
        public readonly struct Nop : ICilOpCode<Nop>
        {
            public const string OpCodeName = "nop";

            public ILOpCode Id => ILOpCode.Nop;

            public string Name => OpCodeName;
        }

        public readonly struct Break : ICilOpCode<Break>
        {
            public const string OpCodeName = "break";

            public const ILOpCode OpCodeId = ILOpCode.Break;

            public string Name => OpCodeName;

            public ILOpCode Id => Id;
        }

        public readonly struct LdArg0 : ICilOpCode<LdArg0>
        {
            public const string OpCodeName = "ldarg.0";

            public const ILOpCode OpCodeId = ILOpCode.Ldarg_0;

            public string Name => OpCodeName;

            public ILOpCode Id => OpCodeId;
        }

        public readonly struct LdArg1 : ICilOpCode<LdArg1>
        {
            public const string OpCodeName = "ldarg.1";

            public const ILOpCode OpCodeId = ILOpCode.Ldarg_1;

            public string Name => OpCodeName;

            public ILOpCode Id => OpCodeId;
        }

        public readonly struct LdArg2 : ICilOpCode<LdArg2>
        {
            public const string OpCodeName = "ldarg.2";

            public const ILOpCode OpCodeId = ILOpCode.Ldarg_1;

            public string Name => OpCodeName;

            public ILOpCode Id => OpCodeId;
        }

        public readonly struct LdArg3 : ICilOpCode<LdArg3>
        {
            public const string OpCodeName = "ldarg.3";

            public const ILOpCode OpCodeId = ILOpCode.Ldarg_3;

            public string Name => OpCodeName;

            public ILOpCode Id => OpCodeId;
        }
    }
}