//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using static V0;
    using static V0d;
    using static Typed;
    public class t_vsign : t_dynamic<t_vsign>
    {

        public void check_vsign_8i()
        {
            var x = V0.vincrements<sbyte>(w128);
            var y = vnegate(x);
            var z = vzero<sbyte>(w128);
            var a = vsign(x);
            var b = vsign(y);
            var c = vsign(z);

            Trace("x", x.ToString());
            Trace("vsign(x)", a.ToString());

            Trace("vnegate(x)", y.ToString());
            Trace("vsign(vnegate(x))", b.ToString());

        }
    }
}