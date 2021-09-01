//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static core;

    using static Blit;

    public class BlitMachine : AppService<BlitMachine>
    {

        IPolyrand Random;

        Index<byte> Buffer;


        uint BufferSize;

        protected override void Initialized()
        {
            BufferSize = Pow2.T14;
            Random = Rng.wyhash64();
            Buffer = alloc<byte>(BufferSize);
        }

        [MethodImpl(Inline)]
        Span<T> Cells<T>()
            where T : unmanaged
                => recover<T>(Buffer.Edit);

        [MethodImpl(Inline)]
        Span<T> Cells<T>(uint offset, uint count)
            where T : unmanaged
                => slice(recover<T>(Buffer.Edit),offset,count);

        public void Run()
        {
            var g0 = Factory.g2x2(@readonly(Cells<ulong>(0,4)));
            var g2 = Factory.g2x2(@readonly(Cells<ulong>(2,4)));
            var spec = g2.Spec;
            Write(spec.Format());
            //Factory.g2x2<ulong>()

        }
    }

}