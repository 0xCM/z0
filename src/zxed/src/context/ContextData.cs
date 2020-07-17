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

        public readonly EnumNames[] EnumNames;
        
        public readonly Indexed<FieldInfo> DataFields;

        public readonly Type ContextType;

        public readonly ClrTypes TypeIndex;

        [MethodImpl(Inline), Op]
        public XedContextData(Type t, ClrTypes index, Indexed<FieldInfo> fields, params EnumNames[] names)
        {
            ContextType = t;
            TypeIndex = index;
            EnumNames = names;
            // CategoryNames = names[0];
            // ExtensionNames = names[1];
            // FlagNames = names[2];
            // ClassNames = names[3];
            DataFields = fields;
        }


        public ref readonly EnumNames CategoryNames
        {
            get => ref EnumNames[0];
        }
        
        public ref readonly EnumNames ExtensionNames
        {
            get => ref EnumNames[1];
        }

        public ref readonly EnumNames FlagNames
        {
            get => ref EnumNames[2];
        }

        public ref readonly EnumNames ClassNames
        {
            get => ref EnumNames[3];
        }
    }    
}