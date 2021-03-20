//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public class t_bv_xor : t_bits<t_bv_xor>
    {
        public void bvxor_check()
        {
            bvxor_check(z8);
            bvxor_check(z16);
            bvxor_check(z32);
            bvxor_check(z64);
        }

        void bvxor_check<T>(T t = default)
            where T : unmanaged
        {
            var f = BvSvc.xor<T>();

            void check()
            {
                for(var rep=0; rep<RepCount; rep++)
                {
                    var x = Random.BitVector<T>();
                    var y = Random.BitVector<T>();
                    var result = f.Invoke(x,y);
                    var expect = f.Invoke(x.Content,y.Content);
                    Claim.eq(expect,result.Content);
                }

            }

            CheckAction(check, ApiTestIdentity.name(f));
        }
    }
}