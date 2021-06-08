//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class IntrinsicsModels
    {
        public struct Intrinsic
        {
            public const string ElementName = "intrinsic";

            public string tech;

            public string name;

            public string content;

            public InstructionTypes types;

            public CpuId CPUID;

            public Category category;

            public Return @return;

            public Parameters parameters;

            public Description description;

            public Operation operation;

            public Instructions instructions;

            public Header header;

            public string Format()
                => IntrinsicsModels.format(this);

            public override string ToString()
                => Format();
        }
    }
}