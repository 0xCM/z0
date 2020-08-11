//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    public enum ImportDefinitionKind
    {
        ImportNamespace = 1,

        ImportAssemblyNamespace = 2,

        ImportType = 3,

        ImportXmlNamespace = 4,

        ImportAssemblyReferenceAlias = 5,

        AliasAssemblyReference = 6,

        AliasNamespace = 7,

        AliasAssemblyNamespace = 8,

        AliasType = 9,
    }
}