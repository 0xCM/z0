//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Kinds
    {
        public readonly struct Add<W,T> : IArithmeticKind<Add,W,T> where W : unmanaged, ITypeWidth { }

        public readonly struct Sub<W,T> : IArithmeticKind<Sub,W,T> where W : unmanaged, ITypeWidth { }

        public readonly struct Mul<W,T> : IArithmeticKind<Mul,W,T> where W : unmanaged, ITypeWidth { }

        public readonly struct Div<W,T> : IArithmeticKind<Div,W,T> where W : unmanaged, ITypeWidth { }

        public readonly struct Clamp<W,T> : IArithmeticKind<Clamp,W,T> where W : unmanaged, ITypeWidth { }

        public readonly struct Dot<W,T> : IArithmeticKind<Dot,W,T> where W : unmanaged, ITypeWidth { }

        public readonly struct Inc<W,T> : IArithmeticKind<Inc,W,T> where W : unmanaged, ITypeWidth { }

        public readonly struct Dec<W,T> : IArithmeticKind<Dec,W,T> where W : unmanaged, ITypeWidth { }

        public readonly struct Negate<W,T> : IArithmeticKind<Negate,W,T> where W : unmanaged, ITypeWidth { }

        public readonly struct Abs<W,T> : IArithmeticKind<Abs,W,T> where W : unmanaged, ITypeWidth { }

        public readonly struct Square<W,T> : IArithmeticKind<Square,W,T> where W : unmanaged, ITypeWidth { }

        public readonly struct Sqrt<W,T> : IArithmeticKind<Sqrt,W,T> where W : unmanaged, ITypeWidth { }
    }
}