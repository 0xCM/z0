//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_nbc_span : t_bc<t_nbc_span>
    {

        public void nbc_span_63x64u()
            => nbc_span_check<N63,ulong>();

        public void nbc_span_13x16u()
            => nbc_span_check<N13,ushort>();

        public void nbc_span_32x32u()
            => nbc_span_check<N32,uint>();
    }

}