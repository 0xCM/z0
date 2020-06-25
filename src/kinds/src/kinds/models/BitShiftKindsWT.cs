//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Kinds
    {
        public readonly struct Sll<W,T> : IBitShiftKind<Sll,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct Sllv<W,T> : IBitShiftKind<Sllv,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct Srl<W,T> : IBitShiftKind<Srl,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct Srlv<W,T> : IBitShiftKind<Srlv,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct Rotl<W,T> : IBitShiftKind<Rotl,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct Rotr<W,T> : IBitShiftKind<Rotr,W,T> where W : unmanaged, ITypeWidth {}
    }
}