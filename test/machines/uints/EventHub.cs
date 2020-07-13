//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;

    using Z0.Machines;
    
    public class EventHubTest : UnitTest<EventHubTest>
    {
        public static BinaryCode code(params byte[] src)
            => src;
        
        public const string E1 = "e1";

        public const string E2 = "e2";

        public const string E3 = "e3";

        public void test_1()
        {
            var examples = ExampleEvents.Examples;
            var hub = HubClientExample.create(Receiver);
            
            var d1 = code(0,2,4,8);
            
            var d2 = code(12,24,32,68);
            
            var d3 = code(222,224,232,28);
            
            hub.Broadcast(examples.Event1.Define(E1, d1));
            hub.Broadcast(examples.Event2.Define(E2, d2));
            hub.Broadcast(examples.Event3.Define(E3, d3));

            void Receiver(IEncodedEvent e)
            {
                switch(e.Id)
                {
                    case E1: 
                        Claim.eq(e.Data, d1);
                        break;
                    case E2: 
                        Claim.eq(e.Data, d2);
                        break;
                    case E3: 
                        Claim.eq(e.Data, d3);
                        break;
                }                
            }
        }
    }
}