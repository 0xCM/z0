//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Seed;

    [StructLayout(LayoutKind.Sequential)]
    [Fixed(FixedWidth.W512)]
    public readonly struct Fixed512 : IFixed<Fixed512,W512>
    {
        readonly Fixed256 X0;

        readonly Fixed256 X1;

        public int BitWidth => 512;

        public int ByteCount => 64;

        [MethodImpl(Inline)]
        Fixed512(Fixed256 x0, Fixed256 x1)
        {
            this.X0 = x0;
            this.X1 = x1;
        }

        [MethodImpl(Inline)]
        public static implicit operator Fixed512((Fixed256 x0, Fixed256 x1) x)
            => new Fixed512(x.x0,x.x1);

        public string Format() 
            => Arrays.from(X0,X1).Format();

        public override string ToString() 
            => Format();                      
 
        [MethodImpl(Inline)]
        public bool Equals(Fixed512 src)
            => X0.Equals(src.X0) && X1.Equals(src.X1);

        public override int GetHashCode()
            => HashCode.Combine(X0,X1);
        
        public override bool Equals(object src)
            => src is Fixed512 x && Equals(x);
    }    
}