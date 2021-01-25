//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using Z0;

/// <summary>
/// Identifies a formal operation for inclusing in the identity assignment and catalog system
/// </summary>
public class OpAttribute : ApiPartAttribute
{
    public string GroupName {get;}

    public ApiClass ClassId {get;}

    public ApiAsmClass AsmId {get;}

    public OpAttribute()
    {
        GroupName = "";
    }

    public OpAttribute(ApiClass id, ApiAsmClass asm = 0)
        : base((ulong)id)
    {
        ClassId = id;
        AsmId = 0;

    }

    public OpAttribute(string group, ApiAsmClass asm = 0)
    {
        GroupName = group;
        AsmId = asm;
    }

    public override string ToString()
        => GroupName;
}
