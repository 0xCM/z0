//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Iteratees
    {
        public struct Iteratee32 : IIteratee<uint>
        {
            uint A0;

            uint A1;

            uint A2;

            [MethodImpl(Inline)]
            public void Invoke(uint a0, uint a1, uint a2)
            {
                A0 = a1;
                A1 = a1;
                A2 = a2;
            }

            public Triple<uint> Current
            {
                [MethodImpl(Inline)]
                get => root.triple(A0,A1,A2);
            }
        }

        public struct Iteratee8 : IIteratee<byte>
        {
            byte A0;

            byte A1;

            byte A2;

            [MethodImpl(Inline)]
            public void Invoke(byte a0, byte a1, byte a2)
            {
                A0 = a1;
                A1 = a1;
                A2 = a2;
            }

            public Triple<byte> Current
            {
                [MethodImpl(Inline)]
                get => root.triple(A0,A1,A2);
            }
        }
    }
}