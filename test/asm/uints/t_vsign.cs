//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using D = CellDelegates;

    public class t_vsign : t_dynamic<t_vsign>
    {
        static Cell8 add(Cell8 a, Cell8 b)
            => math.add(a,b);

        public void check_vsign_8i()
        {
            var fp = memoryco.fptr<D.BinaryOp8>(add);
        }
    }
}