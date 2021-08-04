//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".mem")]
        public Outcome Mem(CmdArgs args)
        {
            var map = NativeAddressMap;
            var buffer = text.buffer();
            map.Describe(buffer);
            Write(buffer.Emit());

            var a0 = map.Seg(0);
            var a1 = map.Seg(1);
            var a2 = map.Address(0, 32);
            var d0 = a2 - a0.BaseAddress;
            Write(string.Format("virt({0}) -> direct({1})",d0, a2));

            return true;
        }
    }
}