//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

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
            var src = Interval.closed(5,12);
            var dst = Partition.measured(src,1);
            var fmt = dst.Map(x => x.ToString()).Concat(", ");
            Claim.eq(src.Length() + 1, dst.Length);            
            ClaimNumeric.eq(Arrays.from(5,6,7,8,9,10,11,12).ToSpan(),dst);
        }

        public void part1()
        {
            var src = Interval.closedL(5,20);
            var dst = Partition.width(src,1);
            var fmt = dst.Map(x => x.ToString()).Concat(" + ");
            Claim.eq(src.Right - src.Left, dst.Length);
            Claim.eq(Interval.closedL(5,6), dst.First());
            Claim.eq(Interval.closedL(19,20), dst.Last());

        }

        public void part2()
        {
            var src = Interval.closed(5,20);
            var dst = Partition.width(src,1);
            var fmt = dst.Map(x => x.ToString()).Concat(" + ");
            Claim.eq(src.Right - src.Left, dst.Length);
            Claim.eq(Interval.closedL(5,6), dst.First());
            Claim.eq(Interval.closed(19,20), dst.Last());
        }

        public void part3()
        {
            var src = Interval.open(5,20);
            var dst = Partition.width(src,1);
            var fmt = dst.Map(x => x.ToString()).Concat(" + ");
            Claim.eq(src.Right - src.Left, dst.Length);
            Claim.eq(Interval.open(5,6), dst.First());
            Claim.eq(Interval.closedL(19,20), dst.Last());
        }


        public void part4()
        {
            var src = Interval.closedR(1,100);
            var dst = Partition.measured(src,10);
            Claim.eq(10,dst.Length);
            Claim.eq(1, dst.First());
            Claim.eq(100, dst.Last());
        }
                
        public void part6()
        {
            var src = Interval.closed(1,103);
            var dst = Partition.width(src,13);
            var fmt = dst.Map(x => x.Format()).Concat(" + ");  
            Claim.require(dst.Last().Closed);
        }

        protected void points_check<T>(T min, T max, T width)
            where T : unmanaged, IComparable<T>, IEquatable<T>
        {
            var points = Partition.measured(Interval.open(min, max), width);
            var len = gmath.sub(max,min);
            var deltaSum = NumericLiterals.zero<T>();
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