// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Z0
{
    partial struct Cil
    {
        public enum OpCodeType : byte
        {
            Annotation = 0,

            Macro = 1,

            Nternal = 2,

            Objmodel = 3,

            Prefix = 4,

            Primitive = 5,
        }
    }
}