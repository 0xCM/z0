//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed1024 Emitter1024();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed1024 BinaryOp1024(Fixed1024 a, Fixed1024 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed1024 UnaryOp1024(Fixed1024 a);

    [StructLayout(LayoutKind.Sequential)]
    public struct Fixed1024  : IFixed<Fixed1024>
    {
        public const int BitWidth = 1024;        

        Fixed512 X0;

        Fixed512 X1;

        public int FixedBitCount  { [MethodImpl(Inline)] get => BitWidth; }

        [MethodImpl(Inline)]
        Fixed1024(Fixed512 x0, Fixed512 x1)
        {
            this.X0 = x0;
            this.X1 = x1;
        }

        [MethodImpl(Inline)]
        public static implicit operator Fixed1024((Fixed512 x0, Fixed512 x1) x)
            => new Fixed1024(x.x0,x.x1);

        public string Format() 
            => array(X0,X1).FormatDataList();

        [MethodImpl(Inline)]
        public bool Equals(Fixed1024 src)
            => X0.Equals(src.X0) && X1.Equals(src.X1);

        public override int GetHashCode()
            => HashCode.Combine(X0,X1);
        
        public override bool Equals(object src)
            => src is Fixed1024 x && Equals(x);

        public override string ToString() 
            => Format();                      
    }    
}