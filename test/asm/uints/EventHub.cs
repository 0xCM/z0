//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static CheckPrimalSeq;

    public class EventHubTest : UnitTest<EventHubTest>
    {
        public static BinaryCode code(params byte[] src)
            => src;

        public const string E1 = "e1";

        public const string E2 = "e2";

        public const string E3 = "e3";

        public static BinaryCode D1 => code(0,2,4,8);

        public static BinaryCode D2 => code(12,24,32,68);

        public static BinaryCode D3 => code(222,224,232,28);

        public void test_1()
        {
            var examples = ExampleEvents.Examples;
            var hub = HubClientExample.create(WfBrokers.relay(x => Receiver(x)));

            hub.Broadcast(examples.Event1.Define(E1, D1));
            hub.Broadcast(examples.Event2.Define(E2, D2));
            hub.Broadcast(examples.Event3.Define(E3, D3));

            static void Receiver(IDataEvent e)
            {
                switch(e.Id)
                {
                    case E1:
                        ClaimEq(e.Encoded, D1);
                        break;
                    case E2:
                        ClaimEq(e.Encoded, D2);
                        break;
                    case E3:
                        ClaimEq(e.Encoded, D3);
                        break;
                }
            }
        }
    }
}