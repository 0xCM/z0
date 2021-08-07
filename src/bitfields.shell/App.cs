//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    class BitFieldsShell : WfApp<BitFieldsShell>
    {
        public static void Main(params string[] args)
            => run(args, PartId.BitFields, PartId.BitFieldsShell);

        protected override void Run()
        {
            var flow = Wf.Running();
            CheckFormatting();
            BitfieldChecks.create(Wf).Run();
            Wf.Ran(flow);
        }

        void CheckFormatting()
        {
            var m0 = BitMasks.Literals.b00001111x32;
            var m1 = BitMasks.Literals.Even32;
            var m = (ulong)m0 | ((ulong)m1 << 32);
            var bf = Bitfields.create(m);
            var bytes = bf.Bytes;
            var buffer = CharBlock128.Null;
            var count = BitRender.render4(bytes, buffer.Data);
            var chars = slice(buffer.Data,0,count);
            var fmt = text.format(chars);
            Wf.Row(fmt);
        }
    }
}