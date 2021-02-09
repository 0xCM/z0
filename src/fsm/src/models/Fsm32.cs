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
    public struct Fsm32
    {
        public static Fsm32 init(Index<uint> terms, Index<uint> rules, uint s0, uint s1)
            => new Fsm32(terms, rules, s0, s1);

        [Op]
        public static void Run(IWfShell wf, Fsm32 fsm)
        {
            var term = 0u;
            while(fsm.Accepting)
                fsm.Process(term++);
        }

        readonly Index<uint> Terms;

        readonly Index<uint> Rules;

        readonly uint EndState;

        uint Current;

        uint Counter;

        public Fsm32(Index<uint> terms, Index<uint> rules, uint s0, uint s1)
        {
            Terms = terms;
            Rules = rules;
            Current = s0;
            EndState = s1;
            Counter = 0;
        }

        public bool Accepting => !Finished;

        bool Finished => Current >= EndState;

        public uint Processed => Counter;

        public void Run()
        {
            var term = 0u;
            while(Accepting)
                Process(term++);

        }
        [Op]
        public bool Process(uint term)
        {
            if(Finished)
                return false;

            switch((uint)Current)
            {
                case 0:
                {
                    switch(term)
                    {
                        case 0:
                            Handle0x0();
                        break;

                        case 1:
                            Handle0x1();
                        break;

                        case 2:
                            Handle0x2();
                        break;

                        case 3:
                            Handle0x3();
                        break;

                        case 4:
                            Handle0x4();
                        break;

                        case 5:
                            Handle0x5();
                        break;

                        case 6:
                            Handle0x6();
                        break;

                        default:
                        break;
                    }
                }
                break;
                case 1:
                {
                    switch(term)
                    {
                        case 0:
                            Handle1x0();
                        break;

                        case 1:
                            Handle1x1();
                        break;

                        case 2:
                            Handle1x2();
                        break;

                        case 3:
                            Handle1x3();
                        break;

                        case 4:
                            Handle1x4();
                        break;

                        case 5:
                            Handle1x5();
                        break;

                        case 6:
                            Handle1x6();
                        break;
                        default:
                        break;
                    }

                }
                break;

                case 2:
                {
                    switch(term)
                    {
                        case 0:
                            Handle2x0();
                        break;

                        case 1:
                            Handle2x1();
                        break;

                        case 2:
                            Handle2x2();
                        break;

                        case 3:
                            Handle2x3();
                        break;

                        case 4:
                            Handle2x4();
                        break;

                        case 5:
                            Handle2x5();
                        break;

                        case 6:
                            Handle2x6();
                        break;
                        default:
                        break;
                    }
                }
                break;

                case 3:
                {
                    switch(term)
                    {
                        case 0:
                            Handle3x0();
                        break;

                        case 1:
                            Handle3x1();
                        break;

                        case 2:
                            Handle3x2();
                        break;

                        case 3:
                            Handle3x3();
                        break;

                        case 4:
                            Handle3x4();
                        break;

                        case 5:
                            Handle3x5();
                        break;

                        case 6:
                            Handle3x6();
                        break;
                        default:
                        break;
                    }

                }
                break;
                default:
                    break;
            }

            Counter++;
            return Current >= EndState;
        }

        [MethodImpl(NotInline), Op]
        void Handle0x0()
        {

            Current += 0*Rules[0];
        }

        [MethodImpl(NotInline), Op]
        void Handle0x1()
        {
            Current += 0*Rules[1];

        }

        [MethodImpl(NotInline), Op]
        void Handle0x2()
        {
            Current += 0*Rules[2];
        }

        [MethodImpl(NotInline), Op]
        void Handle0x3()
        {
            Current += 0*Rules[3];
        }

        [MethodImpl(NotInline), Op]
        void Handle0x4()
        {
            Current += 0*Rules[4];
        }

        [MethodImpl(NotInline), Op]
        void Handle0x5()
        {
            Current += 0*Rules[5];
        }

        [MethodImpl(NotInline), Op]
        void Handle0x6()
        {
            Current += 0*Rules[6];
        }


        [MethodImpl(NotInline), Op]
        void Handle1x0()
        {
            Current += 1*Rules[0];
        }

        [MethodImpl(NotInline), Op]
        void Handle1x1()
        {
             Current += 1*Rules[1];

        }

        [MethodImpl(NotInline), Op]
        void Handle1x2()
        {
             Current += 1*Rules[2];
        }

        [MethodImpl(NotInline), Op]
        void Handle1x3()
        {
             Current += 1*Rules[3];
        }

        [MethodImpl(NotInline), Op]
        void Handle1x4()
        {
             Current += 1*Rules[4];
        }

        [MethodImpl(NotInline), Op]
        void Handle1x5()
        {
             Current += 1*Rules[5];
        }

        [MethodImpl(NotInline), Op]
        void Handle1x6()
        {
             Current += 1*Rules[6];
        }

        [MethodImpl(NotInline), Op]
        void Handle2x0()
        {
            Current += 2*Rules[0];
        }

        [MethodImpl(NotInline), Op]
        void Handle2x1()
        {
             Current += 2*Rules[1];

        }

        [MethodImpl(NotInline), Op]
        void Handle2x2()
        {
             Current += 2*Rules[2];
        }

        [MethodImpl(NotInline), Op]
        void Handle2x3()
        {
             Current += 2*Rules[3];
        }

        [MethodImpl(NotInline), Op]
        void Handle2x4()
        {
             Current += 2*Rules[4];
        }

        [MethodImpl(NotInline), Op]
        void Handle2x5()
        {
             Current += 2*Rules[5];
        }

        [MethodImpl(NotInline), Op]
        void Handle2x6()
        {
             Current += 2*Rules[6];
        }

        [MethodImpl(NotInline), Op]
        void Handle3x0()
        {
            Current += 3*Rules[0];
        }

        [MethodImpl(NotInline), Op]
        void Handle3x1()
        {
             Current += 3*Rules[1];

        }

        [MethodImpl(NotInline)]
        void Handle3x2()
        {
             Current += 3*Rules[2];
        }

        [MethodImpl(NotInline), Op]
        void Handle3x3()
        {
             Current += 3*Rules[3];
        }

        [MethodImpl(NotInline), Op]
        void Handle3x4()
        {
             Current += 3*Rules[4];
        }

        [MethodImpl(NotInline), Op]
        void Handle3x5()
        {
             Current += 3*Rules[5];
        }

        [MethodImpl(NotInline), Op]
        void Handle3x6()
        {
             Current += 3*Rules[6];
        }
    }
}