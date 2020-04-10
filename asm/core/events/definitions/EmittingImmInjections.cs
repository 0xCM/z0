//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using E = AsmEvents.EmittingImmInjections;

    partial class AsmEvents
    {
        public readonly struct EmittingImmInjections : IAppEvent<E, byte[]>
        {
            public byte[] Payload {get;}

            public static E Empty => new E(new byte[]{});

            [MethodImpl(Inline)]
            public static E Define(byte[] imm)
                => new E(imm);

            [MethodImpl(Inline)]
            EmittingImmInjections(byte[] imm)
            {
                this.Payload = imm;
            }
                        
            public string Description
                => $"Emitting immediate specializations {Payload.Format()}";
            
            public string Format()
                => Description;         

            public E Zero => Empty;

        }            
    }
}