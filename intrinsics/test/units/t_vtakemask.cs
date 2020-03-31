//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static Gone;
    using static vgeneric;

    public class t_vtakemask : t_vinx<t_vtakemask>
    {
        public void vtakemask_check()
        {
            vtakemask_check(n128);
            vtakemask_check(n256);
        }

        void vtakemask_check(N128 w)
        {
            vtakemask_check(w,z8);
            vtakemask_check(w,z8i);
            vtakemask_check(w,z16);
            vtakemask_check(w,z16i);
            vtakemask_check(w,z32);
            vtakemask_check(w,z32i);
            vtakemask_check(w,z64);
            vtakemask_check(w,z64i);
            vtakemask_check(w,z32f);
            vtakemask_check(w,z64f);
        }

        void vtakemask_check(N256 w)
        {
            vtakemask_check(w,z8);
            vtakemask_check(w,z8i);
            vtakemask_check(w,z16);
            vtakemask_check(w,z16i);
            vtakemask_check(w,z32);
            vtakemask_check(w,z32i);
            vtakemask_check(w,z64);
            vtakemask_check(w,z64i);
            vtakemask_check(w,z32f);
            vtakemask_check(w,z64f);
        }

        void vtakemask_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            const int count = 16;
            var f = VSvc.vtakemask(w,t);
            var r = Random.VectorEmitter(w,t);

            void check()
            {
                for(var rep=0; rep<RepCount; rep++)
                {
                    var x = r.Invoke();
                    var a = f.Invoke(x);
                    var y = v8u(x);
                    for(var j=0; j<count; j++)
                        Claim.eq(gbits.test(vcell(y,j), 7), gbits.test(a,j));                
                }
            }

            CheckAction(check, CaseName(f));            
        }

        void vtakemask_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            const int count = 32;
            var f = VSvc.vtakemask(w,t);
            var r = Random.VectorEmitter(w,t);
            
            void check()
            {                                
                for(var rep=0; rep<RepCount; rep++)
                {                    
                    var x = r.Invoke();
                    var a = f.Invoke(x);
                    var y = v8u(x);
                    for(var j=0; j<count; j++)
                        Claim.eq(gbits.test(vcell(y,j), 7), gbits.test(a,j));                
                }
            }

            CheckAction(check, CaseName(f));
        }
    }
}