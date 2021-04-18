//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ITableId : ITextual
    {
        Name RecordType {get;}

        Name Identifier {get;}

        string ITextual.Format()
            => Identifier.Format();
    }
}