//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Control;
        
    [ApiHost("api")]
    public partial class Symbolic : IApiHost<Symbolic>
    {
        [MethodImpl(Inline)]
        public static ref readonly ushort read(in char src)        
            => ref SymBits.read(src);

        [MethodImpl(Inline)]
        public static ref readonly ushort read(in char src, int offset)        
            => ref SymBits.read(src,offset);

        [MethodImpl(Inline)]
        public static ref ushort write(ref char src)
            => ref SymBits.write(ref src);

        [MethodImpl(Inline)]
        public static ref ushort write(ref char src, int offset)        
            => ref SymBits.write(ref src, offset);

        [MethodImpl(Inline)]
        public static ref byte write(ref AsciCharCode src)
            => ref SymBits.write(ref src);
    }

    [ApiHost]
    public partial class SymTest : IApiHost<SymTest>
    {

    }

    [ApiHost("data")]
    public partial class SymbolicData : IApiHost<SymbolicData>
    {

    }

    public static partial class XTend
    {
        
    }
}