//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static CheckPrimalSeq;
    using static core;

    public class t_eventhub : UnitTest<t_eventhub>
    {
        public static BinaryCode code(params byte[] src)
            => src;

        public const ulong E1 = 1;

        public const ulong E2 = 2;

        public const ulong E3 = 3;

        public static BinaryCode D1 => code(0,2,4,8);

        public static BinaryCode D2 => code(12,24,32,68);

        public static BinaryCode D3 => code(222,224,232,28);

        public void test_1()
        {
            var received = hashset<IDataEvent>();
            void Receiver(IDataEvent e)
            {
                received.Add(e);
                switch(e.Id)
                {
                    case E1:
                        eq(e.Encoded, D1);
                        break;
                    case E2:
                        eq(e.Encoded, D2);
                        break;
                    case E3:
                        eq(e.Encoded, D3);
                        break;
                }
            }

            var examples = ExampleEvents.Examples;
            var hub = HubClientExample.create(EventHubs.relay(x => Receiver(x)));
            var e1 = examples.Event1.Define(E1, D1);
            var e2 = examples.Event2.Define(E2, D2);
            var e3 = examples.Event3.Define(E3, D3);

            hub.Broadcast(e1);
            hub.Broadcast(e2);
            hub.Broadcast(e3);

            Claim.contains(received, e1);
            Claim.contains(received, e2);
            Claim.contains(received, e3);
        }
    }
}