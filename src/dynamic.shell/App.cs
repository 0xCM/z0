//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static ByteCode;

    class App : WfApp<App>
    {
        public static void Main(params string[] args)
            => run(args, PartId.BitNumbers, PartId.DynamicShell);

        protected override void Run()
        {
            var flow = Wf.Running();


            var result = execute(nameof(mul_8u_8u_8u),mul_8u_8u_8u, 3, 4);
            Wf.Row(result);

            Wf.Ran(flow);
        }

        static ReadOnlySpan<byte> mul_8u_8u_8u
            => new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x0f,0xaf,0xc2,0x0f,0xb6,0xc0,0xc3};

    }
}