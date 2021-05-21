//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [Record(TableId)]
    public struct JmpStub : IRecord<JmpStub>
    {
        public const string TableId = "jmp.stub";

        public OpIdentity Method;

        public MemoryAddress StubAddress;

        public MemoryAddress TargetAddress;

        public AsmHexCode StubCode;

        public Address32 Displacement;

        public Address32 Offset;
    }
}