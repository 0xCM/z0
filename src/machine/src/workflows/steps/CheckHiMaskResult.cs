//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public struct CheckHiMaskResult<T>
    {
        public byte Count;

        public byte PopCount;

        public T Mask;

        public uint1 Check1;

        public uint1 Check2;

        public T Lowered;

        public uint1 Check3;

        public byte EffectiveWidth;
    }
}