//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public class t_vcompare : IntrinsicTest<t_vcompare>
    {        
        public void cmp_gt_128x8i()
            => cmp_gt_check<sbyte>(n128);

        public void cmp_gt_128x8u()
            => cmp_gt_check<byte>(n128);

        public void cmp_gt_128x16i()
            => cmp_gt_check<short>(n128);

        public void cmp_gt_128x16u()
            => cmp_gt_check<ushort>(n128);

        public void cmp_gt_128x32i()
            => cmp_gt_check<int>(n128);

        public void cmp_gt_128x32u()
            => cmp_gt_check<uint>(n128); 

        public void cmp_gt_128x64i()
            => cmp_gt_check<long>(n128); 

        public void cmp_gt_128x64u()
            => cmp_gt_check<ulong>(n128); 

        public void cmp_gt_256x8i()
            => cmp_gt_check<sbyte>(n256);

        public void cmp_gt_256x8u()
            => cmp_gt_check<byte>(n256);

        public void cmp_gt_256x16i()
            => cmp_gt_check<short>(n256);

        public void cmp_gt_256x16u()
            => cmp_gt_check<ushort>(n256);

        public void cmp_gt_256x32i()
            => cmp_gt_check<int>(n256);

        public void cmp_gt_256x32u()
            => cmp_gt_check<uint>(n256);

        public void cmp_gt_256x64i()
            => cmp_gt_check<long>(n256);

        public void cmp_gt_256x64u()
            => cmp_gt_check<ulong>(n256);


        void Report<T>(Block128<T> x, Block128<T> y, Vector128<T> expect, Vector128<T> actual, Vector128<T> result)
            where T : unmanaged
        {
            var pad = 5;
            Trace("left", x.FormatList(pad:pad));
            Trace("right", y.FormatList(pad:pad));
            Trace("expect", expect.FormatList(pad:pad));
            Trace("actual", actual.FormatList(pad:pad));
            Trace("result", result.FormatList(pad:pad));

        }

        void Report<T>(Block256<T> x, Block256<T> y, Vector256<T> expect, Vector256<T> actual, Vector256<T> result)
            where T : unmanaged
        {
            var pad = 5;
            Trace("left", x.FormatList(pad:pad));
            Trace("right", y.FormatList(pad:pad));
            Trace("expect", expect.FormatList(pad:pad));
            Trace("actual", actual.FormatList(pad:pad));
            Trace("result", result.FormatList(pad:pad));

        }

    }

}