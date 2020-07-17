//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    
    using static Konst;

    using Xed;

    public readonly struct XedContextData
    {
        public readonly EnumNames CategoryNames;

        public readonly EnumNames ExtensionNames;

        public readonly EnumNames FlagNames;

        public readonly EnumNames ClassNames;
        
        public readonly Indexed<FieldInfo> DataFields;

        public readonly Type ContextType;

        public readonly KeyedValues<ArtifactIdentity,Type> TypeIndex;


        [MethodImpl(Inline), Op]
        public XedContextData(Type t, KeyedValues<ArtifactIdentity,Type> index, Indexed<FieldInfo> fields, params EnumNames[] names)
        {
            ContextType = t;
            TypeIndex = index;
            CategoryNames = names[0];
            ExtensionNames = names[1];
            FlagNames = names[2];
            ClassNames = names[3];
            DataFields = fields;
        }
    }    
}