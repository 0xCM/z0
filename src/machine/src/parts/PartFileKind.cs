//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public enum PartFileKind : byte
    {
        None = 0,

        Extract = 1, //*.x.csv

        Parsed = 2, //*.p.csv

        Asm = 3, //*.asm

        Hex = 4, //*.hex
    }   
}