//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public struct Fsm32A
    {
        public static Fsm32A init(Index<uint> terms, Index<uint> rules, uint4 s0, uint limit)
            => new Fsm32A(terms, rules, s0, limit);

        readonly Index<uint> Terms;

        readonly Index<uint> Rules;

        readonly uint Limit;

        uint4 State;

        uint Sum;

        uint Counter;

        public Fsm32A(Index<uint> terms, Index<uint> rules, uint4 s0, uint limit)
        {
            Terms = terms;
            Rules = rules;
            State = s0;
            Limit = limit;
            Sum = 0;
            Counter = 0;
        }

        bool Finished => Sum >= Limit;

        public bool Accepting => !Finished;

        public uint Processed => Counter;

        [Op]
        public void Run()
        {
            var term = 0u;
            while(Accepting)
                Compute(term++);
        }

        [Op]
        public void Compute(uint4 term)
        {
            if(Finished)
                goto End;

            var input = (byte)term;

            switch((byte)State)
            {
                case 0:
                    switch(input)
                    {
                        case 0: goto Term0x0;
                        case 1: goto Term0x1;
                        case 2: goto Term0x2;
                        case 3: goto Term0x3;
                        case 4: goto Term0x4;
                        case 5: goto Term0x5;
                        case 6: goto Term0x6;
                    }
                break;
                case 1:
                    switch(input)
                    {
                        case 0: goto Term1x0;
                        case 1: goto Term1x1;
                        case 2: goto Term1x2;
                        case 3: goto Term1x3;
                        case 4: goto Term1x4;
                        case 5: goto Term1x5;
                        case 6: goto Term1x6;
                    }
                break;
                case 2:
                    switch(input)
                    {
                        case 0: goto Term2x0;
                        case 1: goto Term2x1;
                        case 2: goto Term2x2;
                        case 3: goto Term2x3;
                        case 4: goto Term2x4;
                        case 5: goto Term2x5;
                        case 6: goto Term2x6;
                    }
                break;
                case 3:
                    switch(input)
                    {
                        case 0: goto Term3x0;
                        case 1: goto Term3x1;
                        case 2: goto Term3x2;
                        case 3: goto Term3x3;
                        case 4: goto Term3x4;
                        case 5: goto Term3x5;
                        case 6: goto Term3x6;
                    }
                break;
                case 4:
                    switch(input)
                    {
                        case 0: goto Term4x0;
                        case 1: goto Term4x1;
                        case 2: goto Term4x2;
                        case 3: goto Term4x3;
                        case 4: goto Term4x4;
                        case 5: goto Term4x5;
                        case 6: goto Term4x6;
                    }
                break;
            }

            Term0x0:
                Sum += 0*Terms[0];
                goto Transition;
            Term0x1:
                Sum += 0*Terms[1];
                goto Transition;
            Term0x2:
                Sum += 0*Terms[2];
                goto Transition;
            Term0x3:
                Sum += 0*Terms[3];
                goto Transition;
            Term0x4:
                Sum += 0*Terms[4];
                goto Transition;
            Term0x5:
                Sum += 0*Terms[5];
                goto Transition;
            Term0x6:
                Sum += 0*Terms[6];
                goto Transition;

            Term1x0:
                Sum += 1*Terms[0];
                goto Transition;
            Term1x1:
                Sum += 1*Terms[1];
                goto Transition;
            Term1x2:
                Sum += 1*Terms[2];
                goto Transition;
            Term1x3:
                Sum += 1*Terms[3];
                goto Transition;
            Term1x4:
                Sum += 1*Terms[4];
                goto Transition;
            Term1x5:
                Sum += 1*Terms[5];
                goto Transition;
            Term1x6:
                Sum += 1*Terms[6];
                goto Transition;

            Term2x0:
                Sum += 2*Terms[0];
                goto Transition;
            Term2x1:
                Sum += 2*Terms[1];
                goto Transition;
            Term2x2:
                Sum += 2*Terms[2];
                goto Transition;
            Term2x3:
                Sum += 2*Terms[3];
                goto Transition;
            Term2x4:
                Sum += 2*Terms[4];
                goto Transition;
            Term2x5:
                Sum += 2*Terms[5];
                goto Transition;
            Term2x6:
                Sum += 2*Terms[6];
                goto Transition;

            Term3x0:
                Sum += 3*Terms[0];
                goto Transition;
            Term3x1:
                Sum += 3*Terms[1];
                goto Transition;
            Term3x2:
                Sum += 3*Terms[2];
                goto Transition;
            Term3x3:
                Sum += 3*Terms[3];
                goto Transition;
            Term3x4:
                Sum += 3*Terms[4];
                goto Transition;
            Term3x5:
                Sum += 3*Terms[5];
                goto Transition;
            Term3x6:
                Sum += 3*Terms[6];
                goto Transition;

            Term4x0:
                Sum += 4*Terms[0];
                goto Transition;
            Term4x1:
                Sum += 4*Terms[1];
                goto Transition;
            Term4x2:
                Sum += 4*Terms[2];
                goto Transition;
            Term4x3:
                Sum += 4*Terms[3];
                goto Transition;
            Term4x4:
                Sum += 4*Terms[4];
                goto Transition;
            Term4x5:
                Sum += 4*Terms[5];
                goto Transition;
            Term4x6:
                Sum += 4*Terms[6];
                goto Transition;

            Transition:
                Counter++;
            End:
            return;
        }
    }
}
