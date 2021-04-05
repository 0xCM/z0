//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static memory;

    [ApiHost]
    public class VectorMachine : WfService<VectorMachine>
    {
        IPolySource Source;

        Index<Cell128> LeftBuffer;

        Index<Cell128> RightBuffer;

        Index<Cell128> TargetBuffer;

        uint Position;

        uint Count;

        uint Cycle;

        public VectorMachine()
        {
            Count = 1024;
            LeftBuffer = alloc<Cell128>(Count);
            RightBuffer = alloc<Cell128>(Count);
            TargetBuffer= alloc<Cell128>(Count);
        }

        [MethodImpl(Inline)]
        ref Cell128 Target()
            => ref TargetBuffer[Position];

        [MethodImpl(Inline)]
        Span<ulong> Left(W64 w)
            =>  recover<Cell128,ulong>(LeftBuffer.Edit);

        [MethodImpl(Inline)]
        Span<ulong> Right(W64 w)
            =>  recover<Cell128,ulong>(RightBuffer.Edit);

        [MethodImpl(Inline)]
        Span<byte> Left(W8 w)
            =>  recover<Cell128,byte>(LeftBuffer.Edit);

        [MethodImpl(Inline)]
        Span<byte> Right(W8 w)
            =>  recover<Cell128,byte>(RightBuffer.Edit);

        [MethodImpl(Inline)]
        Span<byte> Target(W8 w)
            =>  recover<Cell128,byte>(TargetBuffer.Edit);

        [MethodImpl(Inline), Op]
        bool NextPair(W8 w, out Vector128<byte> a, out Vector128<byte> b)
        {
            if(Position < Count - 1)
            {
                a = gcpu.vload(w128, Left(w));
                b = gcpu.vload(w128, Right(w));
                Position++;
                return true;
            }
            else
            {
                a = default;
                b = default;
                return false;
            }
        }

        protected override void OnInit()
        {
            Source = Rng.@default();
        }

        void Refill()
        {
            Source.Fill(Left(w64));
            Source.Fill(Right(w64));
            Position = 0;
        }

        [MethodImpl(Inline), Op]
        void Process(Vector128<byte> a, Vector128<byte> b)
        {
            var c = cpu.vand(a,b);
            var d = cpu.vxor(a,b);
            var e = cpu.vor(c,d);
            Deposit(e);
        }

        [MethodImpl(Inline), Op]
        void Deposit(Vector128<byte> src)
        {
            gcpu.vstore<byte>(src, ref Target());
        }

        [MethodImpl(Inline), Op]
        uint RunCycle()
        {
            var counter = 0u;
            while(NextPair(w8, out var a, out var b))
            {
                Process(a,b);
                counter++;
            }
            return counter;
        }

        [Op]
        public uint Run(uint cycles)
        {
            var counter = 0u;
            Cycle = 0;
            while(Cycle++ < cycles)
            {
                Refill();
                counter += RunCycle();
            }
            return counter;
        }
    }
}