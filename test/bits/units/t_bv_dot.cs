//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public class t_bv_dot : t_bits<t_bv_dot>
    {
        public void bvdot_gcheck()
        {
            bvdot_gcheck<byte>();
            bvdot_gcheck<ushort>();
            bvdot_gcheck<uint>();
            bvdot_gcheck<ulong>();
        }

        /// <summary>
        /// Verifies the generic bitvector dot product operation
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        protected void bvdot_gcheck<T>(T t = default)
            where T : unmanaged
        {
            var f = BvSvc.dot<T>();

            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.BitVector<T>();
                    var y = Random.BitVector<T>();
                    var actual = f.Invoke(x,y);
                    var expect = BitVector.modprod(x,y);
                    Claim.require(actual == expect);
                    base.Claim.require(actual == f.Invoke((T)x, (T)y));
                }
            }

            CheckAction(check, CaseName(f));
        }
    }
}