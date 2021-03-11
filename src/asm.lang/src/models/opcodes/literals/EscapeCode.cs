//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using H = Hex8Seq;

    /// <summary>
    /// Defines the escape op code byte as specified by Intel Vol II, 2.1.2
    /// </summary>
    public enum EscapeCode : byte
    {
        None = 0,

        x0f = H.x0f,

        x66 = H.x66,
    }
}