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

    public ulong ClassData {get;}

    public OpAttribute()
    {
        GroupName = "";
    }

    public OpAttribute(ApiClass id, ulong data)
    {
        ClassId = id;
        ClassData = data;
    }

    public OpAttribute(ApiClass id)
        : base((ulong)id)
    {
        ClassId = id;

    }

    public OpAttribute(string group)
    {
        GroupName = group;
    }

    public override string ToString()
        => GroupName;
}
