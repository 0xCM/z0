//-----------------------------------------------------------------------------
// Copyright   : Intel Corporation, 2020
// License     : Apache
// Source      : xed-operand-storage.h
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct XedModels
    {
        [SymSource(xed)]
        public enum EffectiveWidth : byte
        {
            None = 0,

            W8 = 8,

            W16 = 16,

            W32 = 32,

            W64 = 64
        }
    }
}