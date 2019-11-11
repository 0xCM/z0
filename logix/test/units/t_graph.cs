//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{        
    using System;
    using System.Linq;
    using System.Threading;
    using static zfunc;

    public class t_graph : UnitTest<t_graph>
    {
        public void Create8()
        {                    
            var m = BitMatrix8.From(
                0b00001000, //0 -> 3
                0b01000000, //1 -> 6
                0b01000000, //2 -> 6
                0b00100000, //3 -> 5
                0b00100000, //4 -> 5
                0b10000010, //5 -> [1, 7]
                0b00100100, //6 -> [2, 5]
                0b01100000  //7 -> [5, 6]
                );
            var g = m.ToGraph();
            
            Claim.eq(8, g.VertexCount);
            Claim.eq(11, g.EdgeCount);
        }
 
        public void Create64()
        {
            var first = 0;
            var last = 63;
            var penultimate = last - 1;

            // creates a dag with 
            // a) one node per level
            // b) Except for the last level, the node on level i is directly 
            // connected to a single node at level i + 1 or greater
            var m = BitMatrix64.Alloc();
            m[first] = Pow2.T01;
            m[last] = 0;
            for(var i=1; i<last; i++)
            {
                if(i == penultimate)
                    m[i] = Pow2.pow(last);
                else
                    m[i] = Random.Pow2<ulong>(i + 1, penultimate);            
            }
            var g = BitGraph.graph(m);

            Claim.eq(64,g.VertexCount);
            Claim.eq(63,g.EdgeCount);
        
            // Trace(m.Format());
            // Trace(g.Format());                
        }

    }

}