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
        public static UpperCased UpperCase => default;

        public static LowerCased LowerCase => default;

        public static Number Number => default;

        public static Letter Letter => default;

        public static ASCI ASCI => default;

        [MethodImpl(Inline)]
        public static ref readonly ushort read(in char src)        
            => ref Unsafe.As<char,ushort>(ref edit(src));

        [MethodImpl(Inline)]
        public static ref readonly ushort read(in char src, int offset)        
            => ref read(Unsafe.Add(ref edit(src), offset));

        [MethodImpl(Inline)]
        public static ref ushort write(ref char src)
            => ref Unsafe.As<char,ushort>(ref src);

        [MethodImpl(Inline)]
        public static ref ushort write(ref char src, int offset)        
            => ref write(ref Unsafe.Add(ref edit(src), offset));

        [MethodImpl(Inline)]
        public static ref byte write(ref AsciCharCode src)
            => ref Unsafe.As<AsciCharCode,byte>(ref edit(src));
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