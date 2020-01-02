//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_partition : t_gmath<t_partition>
    {        

        public void part_points_32i()
        {
            points_check(0, 99, 1);
            points_check(0, 99, 1);
            points_check(100, 233, 5);
            points_check(100, 234, 5);
            points_check(100, 235, 5);
            points_check(-100, 75, 3);
        }

        public void part_points_32u()
        {
            points_check(0u, 99u, 1u);

        }

        public void part_points_64i()
        {
            points_check(0L, 99L, 1L);
        }

        public void part_points_64u()
        {
            points_check(0ul,99ul, 1ul);
        }

        public void part_points_32f()
        {
            points_check(-250.75f, 100.20f, 1.0f);
        }

        public void part_points_64f()
        {
            points_check(0.0, 99.0, 1.0);
            points_check(0.0, 100, 0.5);
            points_check(-250.75, 100.20, 1.0);
        }

        public void part0()
        {
            var src = ldomain(5,12);
            var dst = src.PartPoints();
            var fmt = dst.Map(x => x.ToString()).Concat(", ");
            Claim.eq(src.Length() + 1, dst.Length);            
            Claim.eq(items(5,6,7,8,9,10,11,12).ToSpan(),dst);
        }

        public void part1()
        {
            var src = ldomain(5,20);
            var dst = src.Partition();
            var fmt = dst.Map(x => x.ToString()).Concat(" + ");
            Claim.eq(src.Right - src.Left, dst.Length);
            Claim.eq(ldomain(5,6), dst.First());
            Claim.eq(ldomain(19,20), dst.Last());

        }

        public void part2()
        {
            var src = domain(5,20);
            var dst = src.Partition();
            var fmt = dst.Map(x => x.ToString()).Concat(" + ");
            Claim.eq(src.Right - src.Left, dst.Length);
            Claim.eq(ldomain(5,6), dst.First());
            Claim.eq(domain(19,20), dst.Last());
        }

        public void part3()
        {
            var src = open(5,20);
            var dst = src.Partition();
            var fmt = dst.Map(x => x.ToString()).Concat(" + ");
            Claim.eq(src.Right - src.Left, dst.Length);
            Claim.eq(open(5,6), dst.First());
            Claim.eq(ldomain(19,20), dst.Last());
        }


        public void part4()
        {
            var src = rdomain(1,100);
            var dst = src.PartPointByCount(10);
            Claim.eq(10,dst.Length);
            Claim.eq(1, dst.First());
            Claim.eq(100, dst.Last());
        }
        
        public void part6()
        {
            var src = domain(1,103);
            var dst = src.Partition(13);            
            var fmt = dst.Map(x => x.Format()).Concat(" + ");  
            Claim.yea(dst.Last().Closed);
        }

        protected void points_check<T>(T min, T max, T width)
            where T : unmanaged
        {
            var points = open(min, max).PartPoints(width); 
            var len = gmath.sub(max,min);
            var deltaSum = gmath.zero<T>();
            for(var i=0; i<points.Length - 1; i++)           
            {
                var left = points[i];
                var right = points[i + 1];                
                deltaSum = gmath.add<T>(deltaSum, gmath.sub(right,left));                
            }

            Claim.eq(len, deltaSum);                        
        }
    }
}