//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;

    using static Konst;    

    public readonly struct FunctionPointers
    {
        [MethodImpl(Inline)]
        public static FunctionPointer<D> pointer<D>(D f)
            where D : Delegate
                => new FunctionPointer<D>(f, Marshal.GetFunctionPointerForDelegate<D>(f));
    

    }    
    public readonly struct FunctionPointer<D>
        where D : Delegate
    {
        public readonly D F;

        public readonly MemoryAddress Address;
        
        [MethodImpl(Inline)]
        public FunctionPointer(D f, MemoryAddress address)
        {
            F = f;
            Address = address;
        }

    }

    public class t_vsign : t_dynamic<t_vsign>
    {
        public void check_vsign_8i()
        {
            var fp = FunctionPointers.pointer<BinaryOp<uint>>(math.add);
            term.print(fp.Address);

        }
    }
}