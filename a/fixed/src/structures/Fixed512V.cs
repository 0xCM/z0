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
    public struct Fixed512V  : IFixed<Fixed512V>
    {
        Fixed256V X0;

        Fixed256V X1;

        public int BitWidth  { [MethodImpl(Inline)] get => 512; }

        [MethodImpl(Inline)]
        Fixed512V(Fixed256V x0, Fixed256V x1)
        {
            this.X0 = x0;
            this.X1 = x1;
        }

        [MethodImpl(Inline)]
        public static implicit operator Fixed512V((Fixed256V x0, Fixed256V x1) x)
            => new Fixed512V(x.x0,x.x1);

        public string Format() 
            => Arrays.from(X0,X1).FormatDataList();

        [MethodImpl(Inline)]
        public bool Equals(Fixed512V src)
            => X0.Equals(src.X0) && X1.Equals(src.X1);

        public override int GetHashCode()
            => HashCode.Combine(X0,X1);
        
        public override bool Equals(object src)
            => src is Fixed512V x && Equals(x);

        public override string ToString() 
            => Format();                      
    }    
}