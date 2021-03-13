//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public unsafe ref struct AsmTraveler
    {
        [MethodImpl(Inline)]
        public static AsmTraveler create(Span<byte> buffer)
            => new AsmTraveler(buffer);

        Span<byte> Target;

        uint Capacity;

        uint Position;

        ref byte Current
        {
            [MethodImpl(Inline)]
            get => ref seek(Target,Position);
        }

        [MethodImpl(Inline)]
        AsmTraveler(Span<byte> target)
        {
            Target = target;
            Capacity = (uint)target.Length;
            Position = 0;
        }

        JmpInfo Jcc(byte src)
        {
            return JmpInfo.Empty;
        }

        dynamic Interpret()
        {
            ref readonly var current = ref Current;

            return 0;
        }

        bool Next(byte* pSrc)
        {
            var next = pSrc++;
            Position++;

            return true;
        }

        public ReadOnlySpan<byte> Travel(byte* pSrc)
        {
            Position = 0;
            Target.Clear();
            while(Position < Capacity - 1)
            {
                if(!Next(pSrc))
                    break;
            }

            return slice(Target, Position);
        }
    }
}